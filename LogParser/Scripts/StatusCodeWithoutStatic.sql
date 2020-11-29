SELECT 
    sc-status as Status, 
    COUNT(*) as Hits, 
    MUL(PROPCOUNT(*),100) as % 
FROM 
    '<%FILENAME%>'
WHERE 
	(cs-uri-stem not like '%.png')
	and (cs-uri-stem not like '%.js')
	and (cs-uri-stem not like '%.html')
	and (cs-uri-stem not like '%.css')
	and (cs-uri-stem not like '%.gif')
	and (cs-uri-stem not like '%.doc')
	and (cs-uri-stem not like '%.jpg')
	and (cs-uri-stem not like '%.ico')
	and NOT(sc-status = 500)
GROUP BY 
    Status
