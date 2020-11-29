
select distinct
case strcnt(cs(user-agent),'Android') when 1 THEN 'Android'
else case strcnt(cs(user-agent),'Windows+NT+6.3') when 1 THEN 'Windows 8.1'
else case strcnt(cs(user-agent),'Windows+NT+6.2') when 1 THEN 'Windows 8'
else case strcnt(cs(user-agent),'Windows+NT+6.1') when 1 THEN 'Windows 7'
else case strcnt(cs(user-agent),'Windows+7') when 1 THEN 'Windows 7'
else case strcnt(cs(user-agent),'Windows+NT+6.0') when 1 THEN 'Windows Vista'
else case strcnt(cs(user-agent),'Windows+Vista') when 1 THEN 'Windows Vista'
else case strcnt(cs(user-agent),'Windows+NT+5.2') when 1 THEN 'Windows Server 2003 / Windows XP x64 Edition'
else case strcnt(cs(user-agent),'Windows+NT+5.1') when 1 THEN 'Windows XP'
else case strcnt(cs(user-agent),'Windows+NT+5') when 1 THEN 'Windows 2000'
else case strcnt(cs(user-agent),'Windows+NT+4') when 1 THEN 'Microsoft Windows NT 4.0'
else case strcnt(cs(user-agent),'Windows+98') when 1 THEN 'Windows 98'
else case strcnt(cs(user-agent),'Windows+95') when 1 THEN 'Windows 95'
else case strcnt(cs(user-agent),'Windows+CE') when 1 THEN 'Windows CE'
else case strcnt(cs(user-agent),'Darwin/14') when 1 THEN 'iOS' /* Darwin 14 iPad3+ & iOS7 */
else case strcnt(cs(user-agent),'Darwin/13') when 1 THEN 'iOS' /* Darwin 13 iPhone 4S */
else case strcnt(cs(user-agent),'iPhone') when 1 THEN 'iOS' /* iPhone */
else case strcnt(cs(user-agent),'iPad') when 1 THEN 'iOS' /* iPad */
else case strcnt(cs(user-agent),'OS+X') when 1 THEN 'Mac OSX'
else case strcnt(cs(user-agent),'Symbian') when 1 THEN 'Symbian'
else case strcnt(cs(user-agent),'Windows+Phone') when 1 THEN 'Windows phone'
else case strcnt(cs(user-agent),'CrOS') when 1 THEN 'Chrome OS'
else case strcnt(cs(user-agent),'Unix') when 1 THEN 'Unix'
else case strcnt(cs(user-agent),'BlackBerry+') when 1 THEN 'BlackBerry'
else case strcnt(cs(user-agent),'BB10') when 1 THEN 'BlackBerry'
/* else case strcnt(cs(user-agent),'iTunes') when 1 THEN 'iTunes application' */
else case strcnt(cs(user-agent),'Linux') when 1 THEN 'Linux'
ELSE 'Unknown'
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
End
as Platform/Device,
COUNT(c-ip) as Hits
FROM '<%FILENAME%>'

/* Dont display any cs(User-Agent) which has an entry of nothing */

WHERE cs(User-Agent) is not NULL

/* Dont display any cs(User-Agent) which are created by Bots */

AND cs(User-Agent) NOT LIKE '%java%'
AND cs(User-Agent) NOT LIKE '%moodle%'
AND cs(User-Agent) NOT LIKE '%twitter%'
AND cs(User-Agent) NOT LIKE '%mymmu%'
AND cs(User-Agent) NOT LIKE '%MMU%'
AND cs(User-Agent) NOT LIKE '%ADmant%'
AND cs(User-Agent) NOT LIKE '%contextAd%'
AND cs(User-Agent) NOT LIKE '%bingbot%'
AND cs(User-Agent) NOT LIKE '%genieo%'
AND cs(User-Agent) NOT LIKE '%proximic%'
AND cs(User-Agent) NOT LIKE '%PageBot%'
AND cs(User-Agent) NOT LIKE '%feedfetcher%'
AND cs(User-Agent) NOT LIKE '%wordpress%'
AND cs(User-Agent) NOT LIKE '%PictureBot%'
AND cs(User-Agent) NOT LIKE '%WeSEE%'
AND cs(User-Agent) NOT LIKE '%Sogou%'
AND cs(User-Agent) NOT LIKE '%msnbot%'
AND cs(User-Agent) NOT LIKE '%Mediapartner%'
AND cs(User-Agent) NOT LIKE '%MagpieRSS%'
AND cs(User-Agent) NOT LIKE '%Affectv%'
AND cs(User-Agent) NOT LIKE '%Nutch%'
AND cs(User-Agent) NOT LIKE '%SkimBot%'
AND cs(User-Agent) NOT LIKE '%WhatWeb%'
AND cs(User-Agent) NOT LIKE '%Googlebot%'
AND cs(User-Agent) NOT LIKE '%Yahoo%'
AND cs(User-Agent) NOT LIKE '%Netcraft%'
AND cs(User-Agent) NOT LIKE '%AhrefsBot%'
AND cs(User-Agent) NOT LIKE '%SemrushBot%'
AND cs(User-Agent) NOT LIKE '%MJ12bot%'
AND cs(User-Agent) NOT LIKE '%DotBot%'
AND cs(User-Agent) NOT LIKE '%Vagabondo%'
AND cs(User-Agent) NOT LIKE '%NetSeer%'
AND cs(User-Agent) NOT LIKE '%PHP%'
GROUP by Platform/Device
ORDER by Hits DESC
