--task1
USE Univer
Select PROFESSION.FACULTY
From FACULTY, PULPIT, PROFESSION 
	 where PROFESSION.PROFESSION_NAME in (select PROFESSION.PROFESSION_NAME from PROFESSION
							where PROFESSION.PROFESSION_NAME Like '%���������[�, �]%')
--task2
Use UNIVER 
SELECT PROFESSION.FACULTY
	from PROFESSION INNER JOIN PULPIT
	ON PROFESSION.FACULTY = PULPIT.FACULTY
	where PROFESSION.PROFESSION_NAME IN (select PROFESSION.PROFESSION_NAME from PROFESSION 
							where (PROFESSION.PROFESSION_NAME like '%���������[�, �]%'))
--task3 
USE UNIVER
select PROFESSION.FACULTY, PULPIT.PULPIT_NAME, FACULTY.FACULTY
	from PROFESSION inner join PULPIT
	ON PROFESSION.FACULTY = PULPIT.FACULTY
	inner join FACULTY
	ON FACULTY.FACULTY = PULPIT.FACULTY
	where (PROFESSION.PROFESSION_NAME like '%���������[�, �]%')
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
  where PROGRESS.SUBJECT like '����')
  (select AVG(PROGRESS.NOTE) from PROGRESS
  where PROGRESS.SUBJECT like '��')
  (select AVG(PROGRESS.NOTE) from PROGRESS
  where PROGRESS.SUBJECT like '����')
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
select ���������.�������
from ���������
where ���������.�������� in (select ���������.�������� from ��������� Where ���������.������� like '%������%')
SELECT ���������.ID
	from ��������� INNER JOIN ������
	ON ���������.�������� = ������.���������
	where ���������.�������� in (select ���������.�������� from ��������� Where ���������.������� like '%������%')
	---------------------------------------
select ���������.����, ��������.������������_��������, ������.���������
	from ��������� inner join ������
	ON ���������.���� = ������.���������
	inner join ��������
	ON ��������.������������_�������� = ���������.ID
	where ���������.�������� in (select ���������.�������� from ��������� Where ���������.������� like '%������%')
	---------------------------------------
select ���������.����, ���������.��������
from ���������
where ���������.���� = (
	Select TOP 1 ���������.����
	where ���������.ID = ���������.��������
	ORDER BY ���������.���� DESC)
	ORDER BY ���������.�������� ASC, ���������.���� DESC
	---------------------------------------
select ������.���������, ���������.����
from ������, ���������
where exists (select * from ���������
					where ���������.���� = ������.���������)
	----------------------------------------------------- 
select top 1 
 (select avg(���������.ID) from ���������
  where ���������.���� like 1)
  (select AVG(���������.ID) from ���������
  where ���������.���� like 2)
  (select AVG(���������.ID) from ���������
  where ���������.���� like 3)
  --------------------------------------------
select ���������.����, ���������.ID 
from ���������
where ���������.ID >=all (select ���������.���� from ���������
where ���������.���� = 3)
	----------------------------------------
SELECT ���������.ID
FROM ���������
WHERE ���������.ID = ANY (SELECT ���������.ID FROM ��������� WHERE ���������.���� = 3);



