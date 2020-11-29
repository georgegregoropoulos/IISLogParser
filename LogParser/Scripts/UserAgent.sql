SELECT
	EXTRACT_TOKEN(cs(User-Agent),1,';') as Browser,
	COUNT(*) as Hits
FROM
	'<%FILENAME%>'
GROUP BY
	Browser