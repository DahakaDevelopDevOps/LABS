use UNIVER
--1
DECLARE @DisciplineList NVARCHAR(MAX) = '';

SELECT @DisciplineList = @DisciplineList + RTRIM(SUBJECT) + ', '
FROM SUBJECT
WHERE PULPIT = 'ศั่า'

SELECT LEFT(@DisciplineList, LEN(@DisciplineList) - 1) AS DisciplineList


