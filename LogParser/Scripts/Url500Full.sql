SELECT 
    cs-method as Method, 
    CompleteUrl, 
    sc-substatus as SSubStatus, 
    sc-win32-status as Win32Status 
USING 
    STRCAT(cs-uri-stem, 
        REPLACE_IF_NOT_NULL(cs-uri-query, STRCAT('?', cs-uri-query))) as CompleteUrl 
FROM 
    '<%FILENAME%>' 
WHERE 
    sc-status = 500
