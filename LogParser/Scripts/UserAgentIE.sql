SELECT
		SUBSTR(cs(User-Agent), INDEX_OF(cs(User-Agent), 'MSIE'), 8) as IE,
		COUNT(*) as Hits
FROM
	'<%FILENAME%>'

GROUP BY
	IE