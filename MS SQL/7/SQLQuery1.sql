--select TEACHER[Код], TEACHER_NAME [Имя], GENDER[Пол], PULPIT[Кафедра]
--from TEACHER;
use UNIVER
go
create view [Преподователь]
as select TEACHER[Код], TEACHER_NAME [Имя], GENDER[Пол], PULPIT[Кафедра]
from TEACHER;
go
select * from [Преподователь]
go
--2
create view [Количество кафедр]
as select FACULTY_NAME[факультет], COUNT(*)[количество кафедр ]
from PULPIT inner join FACULTY on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY_NAME
go
--3
create view [Аудитории]
as select AUDITORIUM[Код], AUDITORIUM_TYPE[Наименование аудитории]
from AUDITORIUM
where AUDITORIUM_TYPE like 'ЛК%'
go
insert [Аудитории] 
--4
create view [Лекционные_аудитории]
as select AUDITORIUM, AUDITORIUM_TYPE
from AUDITORIUM
where AUDITORIUM_TYPE like 'ЛК%' with check option;
go
--5
create view [Дисциплины]
as select top 10 SUBJECT.SUBJECT[Код], SUBJECT.SUBJECT_NAME[наименование дисциплины ], SUBJECT.PULPIT[код кафедры]
from SUBJECT
order by SUBJECT_NAME
go
--6
alter view [Количество_кафедр] with schemabinding
as select FACULTY_NAME[факультет], COUNT(*)[количество кафедр ]
from dbo.PULPIT inner join  dbo.FACULTY on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY_NAME;
go

--7
--7,1
USE S_MyBase;
GO
CREATE VIEW Детали_простые
AS
SELECT * FROM Детали WHERE Сложность = 1;
--7,2
CREATE VIEW Операции_простые
AS
SELECT * FROM Операции WHERE Признак_сложности <= 5;
--7,3
CREATE VIEW Сотрудники_операции
AS
SELECT Работники.ID, Работники.Фамилия, Работники.Отчество, Операции.Наименование_операции AS Операция
FROM Работники JOIN Операции ON Работники.Операции = Операции.Признак_сложности;
--7,4
CREATE VIEW Работники_адреса
AS
SELECT * FROM Работники WHERE Адрес IS NOT NULL;
go
--5
CREATE VIEW Детали_с_коэффициентом_больше_500
AS
SELECT * FROM Детали WHERE Коэффициент_сложности_на_количество_деталей > 500;
----6
alter view [Кол-во работников] with schemabinding
as select Работники.ID[обозначение], count(*)[кол-во работников]
from dbo.Работники_адреса inner join dbo.Детали_простые on Работники_адреса.Стаж = Детали_простые.Коэффициент_сложности_на_количество_деталей
group by Работники.ID;
go


