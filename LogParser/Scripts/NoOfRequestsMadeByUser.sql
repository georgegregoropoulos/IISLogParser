SELECT TOP 25 
    cs-username As User, 
    COUNT(*) as Hits 
FROM '<%FILENAME%>' 
WHERE User Is Not Null 
GROUP BY User