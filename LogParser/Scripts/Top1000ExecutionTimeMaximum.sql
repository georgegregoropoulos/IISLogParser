SELECT
	TOP 1000 cs-uri-stem as Url,
	time-taken as ExecutionTime,
	time as TimeGMT
FROM
	<%FILENAME%>
WHERE
	NOT(sc-status = 500)
ORDER BY
	ExecutionTime DESC
