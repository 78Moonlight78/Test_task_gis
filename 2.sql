SELECT
    u.UserName AS "ФИО работника",
    COUNT(DISTINCT d.DataID) AS "Количество документов"
FROM
    DAT.PUBLIC.USER u
LEFT JOIN
    DAT.PUBLIC.COMMON c ON u.UserID = c.UserID
LEFT JOIN
    DAT.PUBLIC.DOC d ON c.DataID = d.DataID
WHERE
    d.DataConfidLevel = 'Коммерческая тайна'
GROUP BY
    u.UserName;
