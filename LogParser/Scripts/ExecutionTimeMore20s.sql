SELECT
	cs-uri-stem as Url,
	AVG(time-taken) as AverageExecutionTime,
	COUNT(*) as Hits
FROM
	'<%FILENAME%>'
WHERE
	NOT(sc-status = 500)
	AND time-taken > '20000'
GROUP BY
	Url
ORDER BY
	Hits DESC
