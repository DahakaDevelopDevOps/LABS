--lab7
use UNIVER
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ИТ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
--1
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ТОВ'
group by rollup( PROGRESS.SUBJECT, GROUPS.PROFESSION)
--2
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ТОВ'
group by cube( PROGRESS.SUBJECT, GROUPS.PROFESSION)
--3
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ТОВ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
union
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ХТиТ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
--
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ТОВ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
union all
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ХТиТ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
--4
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ТОВ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
INTERSECT
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ХТиТ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
--5
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ТОВ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
EXCEPT
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[Средняя оценка]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = 'ХТиТ'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION/
--task6

use S_MyBase
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('1')
group by Работники.ID
--
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Наименование_операции = Работники.Операции
inner join Детали on Операции.Признак_сложности = Детали.Сложность
where Работники.ID in ('1')
group by rollup (Операции.Наименование_операции)
--
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('1')
group by cube (Работники.ID)
--
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('1')
group by Работники.ID
union
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('2')
group by Работники.ID
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('1')
group by Работники.ID
union all
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('2')
group by Работники.ID
--4
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('1')
group by Работники.ID
INTERSECT
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('2')
group by Работники.ID
--5
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('1')
group by Работники.ID
EXCEPT
select Операции.Наименование_операции, avg(Операции.Признак_сложности)[Средняя оценка]
from Операции inner join Работники on Операции.Признак_сложности = Работники.Стаж
inner join Детали on Работники.ID = Детали.Коэффициент_сложности_на_количество_деталей
where Работники.ID in ('2')
group by Работники.ID