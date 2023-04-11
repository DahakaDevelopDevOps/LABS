use UNIVER
--1
DECLARE @DisciplineList NVARCHAR(MAX) = '';

SELECT @DisciplineList = @DisciplineList + RTRIM(SUBJECT) + ', '
FROM SUBJECT
WHERE PULPIT = 'ИСиТ'

SELECT LEFT(@DisciplineList, LEN(@DisciplineList) - 1) AS DisciplineList
go
--3.1
use UNIVER
DECLARE @Speciality char(20), @Name char(100), @Faculty char(10)
DECLARE pulpit_cursor CURSOR STATIC FOR
SELECT PULPIT.PULPIT, PULPIT.PULPIT_NAME, PULPIT.FACULTY FROM PULPIT
OPEN pulpit_cursor
UPDATE PULPIT
	SET PULPIT.PULPIT_NAME = 'Информационных систем и технологий'
	WHERE PULPIT.PULPIT_NAME = 'Информационных систем и убогих технологий';
FETCH NEXT FROM pulpit_cursor INTO @Speciality, @Name, @Faculty
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @Name + @Faculty + @Speciality
    FETCH NEXT FROM pulpit_cursor INTO @Speciality, @Name, @Faculty
END
CLOSE pulpit_cursor
DEALLOCATE pulpit_cursor
go
--
--2
DECLARE c_all_subjects CURSOR FOR SELECT * FROM SUBJECT;
OPEN c_all_subjects;

DECLARE @subject_id char;
DECLARE @subject_name VARCHAR(50);
DECLARE @pulpit VARCHAR(50);

FETCH NEXT FROM c_all_subjects INTO @subject_id, @subject_name, @pulpit;

WHILE @@FETCH_STATUS = 0
BEGIN
    IF @pulpit = 'ИСиТ'
    BEGIN
        PRINT @subject_name;
    END
    
    FETCH NEXT FROM c_all_subjects INTO @subject_id, @subject_name, @pulpit;
END

CLOSE c_all_subjects;
DEALLOCATE c_all_subjects;
go
--3.2
use UNIVER
DECLARE @Speciality char(20), @Name char(100), @Faculty char(10)
DECLARE pulpit_cursor CURSOR DYNAMIC FOR
SELECT PULPIT.PULPIT, PULPIT.PULPIT_NAME, PULPIT.FACULTY FROM PULPIT
OPEN pulpit_cursor
UPDATE PULPIT
	SET PULPIT.PULPIT_NAME = 'Информационных систем и технологий'
	WHERE PULPIT.PULPIT_NAME = 'Информационных систем и убогих технологий';
FETCH NEXT FROM pulpit_cursor INTO @Speciality, @Name, @Faculty
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @Name + @Faculty + @Speciality
    FETCH NEXT FROM pulpit_cursor INTO @Speciality, @Name, @Faculty
END
CLOSE pulpit_cursor
DEALLOCATE pulpit_cursor
go 
use UNIVER
DECLARE @Speciality char(20), @Name char(100), @Faculty char(10)
DECLARE pulpit_cursor LOCAL STATIC FOR
SELECT PULPIT.PULPIT, PULPIT.PULPIT_NAME, PULPIT.FACULTY FROM PULPIT
OPEN pulpit_cursor
UPDATE PULPIT
	SET PULPIT.PULPIT_NAME = 'Информационных систем и технологий'
	WHERE PULPIT.PULPIT_NAME = 'Информационных систем и убогих технологий';
FETCH NEXT FROM pulpit_cursor INTO @Speciality, @Name, @Faculty
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @Name + @Faculty + @Speciality
    FETCH NEXT FROM pulpit_cursor INTO @Speciality, @Name, @Faculty
END
CLOSE pulpit_cursor
DEALLOCATE pulpit_cursor
go 
--4
USE UNIVER

-- Declare a cursor with the SCROLL attribute to enable navigating the result set in any direction
DECLARE student_cursor CURSOR SCROLL FOR
SELECT * FROM STUDENT

-- Open the cursor and fetch the first row
OPEN student_cursor
FETCH FIRST FROM student_cursor

-- Fetch the previous row from the current position (if available)
FETCH PRIOR FROM student_cursor
IF @@FETCH_STATUS = 0
    PRINT 'Fetched previous row: ' + CAST(CURRENT_TIMESTAMP AS VARCHAR(30))

-- Fetch the next row from the current position (if available)
FETCH NEXT FROM student_cursor
IF @@FETCH_STATUS = 0
    PRINT 'Fetched next row: ' + CAST(CURRENT_TIMESTAMP AS VARCHAR(30))

-- Fetch the absolute row at position 5
FETCH ABSOLUTE 5 FROM student_cursor
IF @@FETCH_STATUS = 0
    PRINT 'Fetched absolute row 5: ' + CAST(CURRENT_TIMESTAMP AS VARCHAR(30))

-- Fetch the relative row at position -3 (3 rows before the current position)
FETCH RELATIVE -3 FROM student_cursor
IF @@FETCH_STATUS = 0
    PRINT 'Fetched relative row -3: ' + CAST(CURRENT_TIMESTAMP AS VARCHAR(30))

-- Close and deallocate the cursor
CLOSE student_cursor
DEALLOCATE student_cursor
go
-- 5
USE UNIVER
DECLARE @pulpit_id INT, @pulpit_name NVARCHAR(100)
DECLARE pulpit_cursor CURSOR FOR
SELECT PULPIT, PULPIT_NAME
FROM PULPIT
WHERE FACULTY = 'ИТ'
OPEN pulpit_cursor
FETCH NEXT FROM pulpit_cursor INTO @pulpit_id, @pulpit_name
WHILE @@FETCH_STATUS = 0
BEGIN
    -- UPDATE statement using CURRENT OF clause
    UPDATE PULPIT
    SET PULPIT_NAME = @pulpit_name + ' (updated)'
    WHERE CURRENT OF pulpit_cursor
    
    -- DELETE statement using CURRENT OF clause
    DELETE FROM PULPIT
    WHERE CURRENT OF pulpit_cursor
    
    FETCH NEXT FROM pulpit_cursor INTO @pulpit_id, @pulpit_name
END
CLOSE pulpit_cursor
DEALLOCATE pulpit_cursor
go
--6
DELETE FROM PROGRESS
WHERE NOTE < 4 AND IDSTUDENT IN (
    SELECT s.IDSTUDENT
    FROM STUDENT s
    JOIN GROUPS g ON s.IDGROUP = g.IDGROUP
    JOIN PROGRESS p ON s.IDSTUDENT = p.IDSTUDENT
);
UPDATE PROGRESS
SET NOTE = NOTE + 1
WHERE IDSTUDENT = 1001
go 
--
USE UNIVER

DECLARE @StudentId INT
DECLARE progress_cursor CURSOR FOR
SELECT P.IDSTUDENT
FROM PROGRESS P
INNER JOIN STUDENT S ON P.IDSTUDENT = S.IDSTUDENT
INNER JOIN GROUPS G ON S.IDGROUP = G.IDGROUP
WHERE P.NOTE < 4

OPEN progress_cursor

FETCH NEXT FROM progress_cursor INTO @StudentId

WHILE @@FETCH_STATUS = 0
BEGIN
    DELETE FROM PROGRESS WHERE IDSTUDENT = @StudentId
    FETCH NEXT FROM progress_cursor INTO @StudentId
END

CLOSE progress_cursor
DEALLOCATE progress_cursor
go
--
USE UNIVER

DECLARE @StudentId INT
DECLARE progress_cursor CURSOR FOR
SELECT IDSTUDENT
FROM STUDENT
WHERE IDSTUDENT = 1001

OPEN progress_cursor

FETCH NEXT FROM progress_cursor INTO @StudentId

WHILE @@FETCH_STATUS = 0
BEGIN
    UPDATE PROGRESS SET NOTE = NOTE + 1 WHERE IDSTUDENT = @StudentId
    FETCH NEXT FROM progress_cursor INTO @StudentId
END

CLOSE progress_cursor
DEALLOCATE progress_cursor
go




