using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace IISLogParser.LogParser
{
  public class LogParser
  {
    public event pf_OneQueryExecuted eOneQueryExecuted;
    public delegate void pf_OneQueryExecuted(int i, string scriptName);

    public event pf_DoneExecution eDoneExecution;
    public delegate void pf_DoneExecution(string message);

    private LogParser()
    { }

    private List<string> _logFilesName;
    public LogParser(List<string> sLogFiles)
    {
      _logFilesName = sLogFiles;
    }

    public static int NumberOfQueriesToExecute
    {
      get { return _scripts.Length; }
      private set { }
    }
    public Dictionary<string, string> Run()
    {
      return Run(null);
    }
    public Dictionary<string, string> Run(List<string> scripts)
    {
      string strTmpPath = System.IO.Path.GetTempPath();
      string strPath = System.IO.Path.Combine(strTmpPath, System.IO.Path.GetRandomFileName());
      Dictionary<string, string> res = new Dictionary<string, string>();
      bool bUseResources = false;

      if (scripts == null || scripts.Count == 0)
      {
        scripts = _scripts.ToList();
        bUseResources = true;
      }

      try
      {
        DirectoryInfo dirInfo = System.IO.Directory.CreateDirectory(strPath);

        CreateLogParserExe(dirInfo.FullName);
        CreateLogParserDll(dirInfo.FullName);

        CreateAllScripts(scripts, dirInfo.FullName, _logFilesName, bUseResources);
        
        int index = 0;
        foreach (var it in scripts)
        {

          if (eOneQueryExecuted != null)
          {
            eOneQueryExecuted(index, it);
          }
          ProcessStartInfo si = new ProcessStartInfo();
          string resFile;
          if (bUseResources)
          {
            resFile = System.IO.Path.GetFileNameWithoutExtension(it) + ".txt";
            si.Arguments = string.Format("file:{0} -i:IISW3C -o:TSV ", System.IO.Path.Combine(strPath, it));
          }
          else
          {
            resFile = System.IO.Path.GetFileNameWithoutExtension(String.Format("customScript_{0}.sql", index)) + ".txt";
            si.Arguments = string.Format("file:{0} -i:IISW3C -o:TSV ", System.IO.Path.Combine(strPath, String.Format("customScript_{0}.sql", index)));
          }
          
          si.WorkingDirectory = strPath;
          si.FileName = System.IO.Path.Combine(strPath, "LogParser.exe");
          si.RedirectStandardError = true;
          si.RedirectStandardOutput = true;
          si.UseShellExecute = false;
          si.CreateNoWindow = true;
          //si.WindowStyle = ProcessWindowStyle.Minimized;
          Process s = Process.Start(si);
          using (s)
          {
            //s.BeginErrorReadLine();
            //string error = s.StandardError.ReadToEnd();
            string result = s.StandardOutput.ReadToEnd();
            s.WaitForExit();
            if (bUseResources)
            {
              if (res.ContainsKey(System.IO.Path.GetFileNameWithoutExtension(it)))
              {
                string rest = res[System.IO.Path.GetFileNameWithoutExtension(it)];
                int nFirstLine = result.IndexOf(System.Environment.NewLine);
                result = result.Remove(0, nFirstLine + 2);
                rest = rest += result;
                res.Remove(System.IO.Path.GetFileNameWithoutExtension(it));
                res.Add(System.IO.Path.GetFileNameWithoutExtension(it), rest);
              }
              else
              {
                res.Add(System.IO.Path.GetFileNameWithoutExtension(it), result);
              }
            }
            else
            {
              res.Add(String.Format("customScript_{0}", index), result);
            }

            if (eOneQueryExecuted != null)
            {
              eOneQueryExecuted(index, it);
            }
          }
          index++;
        }
      }
      catch (Exception ex)
      {
        System.Diagnostics.Debug.WriteLine(ex.ToString());
      }
      finally
      {
        System.IO.Directory.Delete(strPath, true);
        eDoneExecution?.Invoke("Finised!");
      }
      return res;
    }

    void CreateLogParserExe(string strPath)
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      var input = assembly.GetManifestResourceStream("IISLogParser.LogParser.Bin.LogParser.exe");
      var output = File.Open(System.IO.Path.Combine(strPath, "LogParser.exe"), FileMode.Create);
      CopyStream(input, output);
      input.Dispose();
      output.Dispose();
    }

    void CreateLogParserDll(string strPath)
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      var input = assembly.GetManifestResourceStream("IISLogParser.LogParser.Bin.LogParser.dll");
      var output = File.Open(System.IO.Path.Combine(strPath, "LogParser.dll"), FileMode.Create);
      CopyStream(input, output);
      input.Dispose();
      output.Dispose();
    }

    const string _replaceName = "<%FILENAME%>";
    void CreateOneSqlScript(string scriptName, int index, List<string> logFileNames, string strPath, bool isResource)
    {
      string r = string.Empty;
      if(logFileNames==null || logFileNames.Count == 0) {
        throw new ArgumentNullException("logfilenames");
      }

      if (isResource)
      {
        Assembly assembly = Assembly.GetExecutingAssembly();
        var input = assembly.GetManifestResourceStream(String.Format("IISLogParser.LogParser.Scripts.{0}", scriptName));

        using (input)
        {
          StreamReader sw = new StreamReader(input);
          using (sw)
          {
            r = sw.ReadToEnd();
          }
        }
      }
      else
      {
        r = scriptName;
        scriptName = String.Format("customScript_{0}.sql", index);
      }
      if (logFileNames.Count == 1) {
        r = r.Replace(_replaceName, logFileNames.First());
      }
      else {
        r = r.Replace(_replaceName, String.Join(",", logFileNames.ToArray()));
      }

      var output = File.Open(System.IO.Path.Combine(strPath, String.Format("{0}", scriptName)), FileMode.Create);
      using (output)
      {
        CopyStream(ToStream(r), output);
      }
    }

    private Stream ToStream(string str)
    {
      MemoryStream stream = new MemoryStream();
      StreamWriter writer = new StreamWriter(stream);
      writer.Write(str);
      writer.Flush();
      stream.Position = 0;
      return stream;
    }

    void CreateAllScripts(List<string> scripts, string strPath, List<string> sLogFilenames, bool isResource)
    {
      int index = 0;
      foreach (var it in scripts)
      {
        CreateOneSqlScript(it, index, sLogFilenames, strPath, isResource);
        index++;
      }
    }

    static private string[] _scripts = new string[] {
      "AverageExecutionTime.sql",
      "ExecutionTimeMinAvMax.sql",
      "ExecutionTimeMore10s.sql",
      "ExecutionTimeMore20s.sql",
      "HitsByExtension.sql",
      "HitsByDateHour.sql",
      "HitsByHour.sql",
      "IPs.sql",
      "StatusCode.sql",
      "StatusCodeWithoutStatic.sql",
      "Top1000ExecutionTimeMaximum.sql",
      "UniqueIPs.sql",
      "Url404.sql",
      //"Url400.sql",
      "Url500.sql",
      "Url500Full.sql",
      "UserAgent.sql",
      "UserAgentFireFox.sql",
      "UserAgentFull.sql",
      "UserAgentIE.sql",
      "UserAgentOpera.sql",
      //"FindOS.sql",
      "NoOfRequestsMadeByUser.sql"
    };

    private void CopyStream(Stream input, Stream output)
    {
      byte[] buffer = new byte[32768];
      while (true)
      {
        int read = input.Read(buffer, 0, buffer.Length);
        if (read <= 0)
          return;
        output.Write(buffer, 0, read);
      }
    }
  }
}
