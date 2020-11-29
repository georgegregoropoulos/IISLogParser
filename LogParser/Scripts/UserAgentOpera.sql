SELECT
		SUBSTR(cs(User-Agent), INDEX_OF(cs(User-Agent), 'Opera'), 7) as Opera,
		COUNT(*) as Hits
FROM
	'<%FILENAME%>'

GROUP BY
	Opera