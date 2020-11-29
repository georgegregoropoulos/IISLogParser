SELECT
	cs(User-Agent) as UserAgent,
	COUNT(*) as Hits
FROM
	'<%FILENAME%>'
GROUP BY
	UserAgent