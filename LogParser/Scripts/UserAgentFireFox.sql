SELECT
		SUBSTR(cs(User-Agent), INDEX_OF(cs(User-Agent), 'Firefox'), 9) as Firefox,
		COUNT(*) as Hits
FROM
	'<%FILENAME%>'

GROUP BY
	Firefox