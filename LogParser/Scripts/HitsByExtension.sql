SELECT
	EXTRACT_EXTENSION(TO_LOWERCASE(cs-uri-stem)) as Extension,
	COUNT(*) as Hits
FROM
	'<%FILENAME%>'
GROUP BY
	Extension
ORDER BY
	Hits DESC
