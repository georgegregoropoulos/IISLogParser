SELECT
		DISTINCT c-ip as IP, count(*) as Hits
FROM
	'<%FILENAME%>'
GROUP BY
	c-ip