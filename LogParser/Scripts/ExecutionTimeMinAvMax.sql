SELECT
	MIN(time-taken) as MinExecutionTime,
	AVG(time-taken) as AverageExecutionTime,
	MAX(time-taken) as MaxExecutionTime,
	COUNT(*) as Hits,
	cs-uri-stem as Url
FROM '<%FILENAME%>'
WHERE 
	(cs-uri-stem not like '%.gif')
	and (cs-uri-stem not like '%.css')
	and (cs-uri-stem not like '%.js')
	and (cs-uri-stem not like '%.jpg')
	and NOT(sc-status = 500)
GROUP BY
	Url
ORDER BY
	Hits DESC
