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

