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
use S_MyBase
go
create view [Работник]
as select Работники.ID [Код] , Работники.Фамилия [Фамилия], Работники.Телефон[Данные] 
from Работники;
go
--7,2
create view [Кол-во работников]
as select Работники.ID[Идентификация], count(*)[кол-во работнииков]
from Работники inner join Операции on Работники.Стаж = Операции.Признак_сложности
group by Работники.ID;
go
--7,3
create view [Работники_со_стажем_2_года]
as select Работники.Фамилия [Отношение], Работники.Стаж [Стаж]
from Работники
where Работники.Стаж = 2
go
--7,4
create view [Работники_со_стажем_2_года_с_условием]
as select Работники.Фамилия [Отношение], Работники.Стаж [Стаж]
from Работники
where Работники.Стаж = 2 with check option
go
--5
create view [Самые опытные работники]
as select top 5 Работники.ID [Код],Работники.Телефон [Номер]
from Работники
order by Работники.ID desc;
go
----6
alter view [Кол-во работников] with schemabinding
as select Работники.ID[Идентификация], count(*)[кол-во работнииков]
from Работники inner join Операции on Работники.Стаж = Операции.Признак_сложности
group by Работники.ID;
go


drop table Работник 

insert [Кол-во работников] values (1, 1111, 2,3)