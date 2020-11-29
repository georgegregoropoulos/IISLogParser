SELECT
	cs-uri-stem as Url,
	COUNT(*) as Hits
FROM
	'<%FILENAME%>'
WHERE
	sc-status = 400
GROUP BY
	cs-uri-stem
ORDER BY Hits DESC