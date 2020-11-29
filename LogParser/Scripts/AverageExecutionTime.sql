SELECT AVG(time-taken) as AverageExecutionTime, COUNT(*) as Hits, cs-uri-stem as Url
FROM '<%FILENAME%>'
WHERE 
	(cs-uri-stem not like '%.gif')
	and (cs-uri-stem not like '%.css')
	and (cs-uri-stem not like '%.js')
	and (cs-uri-stem not like '%.jpg')
GROUP BY
	Url
ORDER BY
	AverageExecutionTime DESC