--lab7
use UNIVER
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '��'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
--1
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '���'
group by rollup( PROGRESS.SUBJECT, GROUPS.PROFESSION)
--2
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '���'
group by cube( PROGRESS.SUBJECT, GROUPS.PROFESSION)
--3
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '���'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
union
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '����'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
--
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '���'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
union all
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '����'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
--4
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '���'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
INTERSECT
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '����'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
--5
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '���'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION
EXCEPT
select PROGRESS.SUBJECT, GROUPS.PROFESSION, avg(PROGRESS.NOTE)[������� ������]
from FACULTY inner join GROUPS on FACULTY.FACULTY = GROUPS.FACULTY
inner join STUDENT on STUDENT.IDGROUP =GROUPS.IDGROUP
inner join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where FACULTY.FACULTY = '����'
group by PROGRESS.SUBJECT, GROUPS.PROFESSION/
--task6

use S_MyBase
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('1')
group by ���������.ID
--
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.������������_�������� = ���������.��������
inner join ������ on ��������.�������_��������� = ������.���������
where ���������.ID in ('1')
group by rollup (��������.������������_��������)
--
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('1')
group by cube (���������.ID)
--
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('1')
group by ���������.ID
union
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('2')
group by ���������.ID
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('1')
group by ���������.ID
union all
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('2')
group by ���������.ID
--4
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('1')
group by ���������.ID
INTERSECT
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('2')
group by ���������.ID
--5
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('1')
group by ���������.ID
EXCEPT
select ��������.������������_��������, avg(��������.�������_���������)[������� ������]
from �������� inner join ��������� on ��������.�������_��������� = ���������.����
inner join ������ on ���������.ID = ������.�����������_���������_��_����������_�������
where ���������.ID in ('2')
group by ���������.ID