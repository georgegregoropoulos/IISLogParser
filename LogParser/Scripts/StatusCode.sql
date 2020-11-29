SELECT 
    sc-status as Status, 
	COUNT(*) as Hits, 
    MUL(PROPCOUNT(*),100) as % 
FROM 
    '<%FILENAME%>'
GROUP BY 
    sc-status
