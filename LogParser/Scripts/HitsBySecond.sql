SELECT
	time AS TimeGMT,
	COUNT(*) AS Hits
FROM
	'<%FILENAME%>'
GROUP BY
	TimeGMT
ORDER BY
	TimeGMT ASC