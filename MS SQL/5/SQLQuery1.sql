--task1
USE Univer
Select PROFESSION.FACULTY
From FACULTY, PULPIT, PROFESSION 
	 where PROFESSION.PROFESSION_NAME in (select PROFESSION.PROFESSION_NAME from PROFESSION
							where PROFESSION.PROFESSION_NAME Like '%технологи[я, и]%')
--task2
Use UNIVER 
SELECT PROFESSION.FACULTY
	from PROFESSION INNER JOIN PULPIT
	ON PROFESSION.FACULTY = PULPIT.FACULTY
	where PROFESSION.PROFESSION_NAME IN (select PROFESSION.PROFESSION_NAME from PROFESSION 
							where (PROFESSION.PROFESSION_NAME like '%технологи[я, и]%'))
--task3 
USE UNIVER
select PROFESSION.FACULTY, PULPIT.PULPIT_NAME, FACULTY.FACULTY
	from PROFESSION inner join PULPIT
	ON PROFESSION.FACULTY = PULPIT.FACULTY
	inner join FACULTY
	ON FACULTY.FACULTY = PULPIT.FACULTY
	where (PROFESSION.PROFESSION_NAME like '%технологи[я, и]%')
--task4
use UNIVER
select AUDITORIUM.AUDITORIUM_CAPACITY, AUDITORIUM_TYPE
from AUDITORIUM
where AUDITORIUM.AUDITORIUM_CAPACITY = (
	Select TOP 1 AUDITORIUM.AUDITORIUM_CAPACITY
	where AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM.AUDITORIUM_TYPE
	ORDER BY AUDITORIUM.AUDITORIUM_CAPACITY DESC)
	ORDER BY AUDITORIUM_TYPE ASC, AUDITORIUM_CAPACITY DESC
--task5
USE UNIVER
select FACULTY.FACULTY_NAME, PULPIT.FACULTY
from FACULTY, PULPIT
where not exists (select * from PULPIT
					where FACULTY_NAME = PULPIT_NAME)
--task6
USE UNIVER 
select top 1 
 (select avg(PROGRESS.NOTE) from PROGRESS
  where PROGRESS.SUBJECT like 'ОАиП')
  (select AVG(PROGRESS.NOTE) from PROGRESS
  where PROGRESS.SUBJECT like 'БД')
  (select AVG(PROGRESS.NOTE) from PROGRESS
  where PROGRESS.SUBJECT like 'СУБД')
--task7
use UNIVER
select PROGRESS.SUBJECT, PROGRESS.NOTE 
from PROGRESS
where PROGRESS.IDSTUDENT >=all (select PROGRESS.NOTE from PROGRESS
where PROGRESS.NOTE = 4)
--task 8
SELECT PROGRESS.IDSTUDENT
FROM PROGRESS
WHERE PROGRESS.IDSTUDENT = ANY (SELECT PROGRESS.IDSTUDENT FROM PROGRESS WHERE PROGRESS.NOTE = '4');
--task9
use S_MyBase
select Работники.Фамилия
from Работники
where Работники.Отчество in (select Работники.Отчество from Работники Where Работники.Фамилия like '%Иванов%')
SELECT Работники.ID
	from Работники INNER JOIN Детали
	ON Работники.Операции = Детали.Сложность
	where Работники.Отчество in (select Работники.Отчество from Работники Where Работники.Фамилия like '%Иванов%')
	---------------------------------------
select Работники.Стаж, Операции.Наименование_операции, Детали.Сложность
	from Работники inner join Детали
	ON Работники.Стаж = Детали.Сложность
	inner join Операции
	ON Операции.Наименование_операции = Работники.ID
	where Работники.Отчество in (select Работники.Отчество from Работники Where Работники.Фамилия like '%Иванов%')
	---------------------------------------
select Работники.Стаж, Работники.Операции
from Работники
where Работники.Стаж = (
	Select TOP 1 Работники.Стаж
	where Работники.ID = Работники.Операции
	ORDER BY Работники.Стаж DESC)
	ORDER BY Работники.Операции ASC, Работники.Стаж DESC
	---------------------------------------
select Детали.Сложность, Работники.Стаж
from Детали, Работники
where exists (select * from Работники
					where Работники.Стаж = Детали.Сложность)
	----------------------------------------------------- 
select top 1 
 (select avg(Работники.ID) from Работники
  where Работники.Стаж like 1)
  (select AVG(Работники.ID) from Работники
  where Работники.Стаж like 2)
  (select AVG(Работники.ID) from Работники
  where Работники.Стаж like 3)
  --------------------------------------------
select Работники.Стаж, Работники.ID 
from Работники
where Работники.ID >=all (select Работники.Стаж from Работники
where Работники.Стаж = 3)
	----------------------------------------
SELECT Работники.ID
FROM Работники
WHERE Работники.ID = ANY (SELECT Работники.ID FROM Работники WHERE Работники.Стаж = 3);



