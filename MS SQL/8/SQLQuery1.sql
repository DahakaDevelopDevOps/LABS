	--select TEACHER[���], TEACHER_NAME [���], GENDER[���], PULPIT[�������]
--from TEACHER;
create view [�������������]
as select TEACHER[���], TEACHER_NAME [���], GENDER[���], PULPIT[�������]
from TEACHER;
go
--2
create view [���������� ������]
as select FACULTY_NAME[���������], COUNT(*)[���������� ������ ]
from PULPIT inner join FACULTY on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY_NAME
--3
create view [���������]
as select AUDITORIUM[���], AUDITORIUM_TYPE[������������ ���������]
from AUDITORIUM
where AUDITORIUM_TYPE like '��%'
--4
create view [����������_���������]
as select AUDITORIUM, AUDITORIUM_TYPE
from AUDITORIUM
where AUDITORIUM_TYPE like '��%' with check option;
--5
create view [����������]
as select top 10 SUBJECT.SUBJECT[���], SUBJECT.SUBJECT_NAME[������������ ���������� ], SUBJECT.PULPIT[��� �������]
from SUBJECT
order by SUBJECT_NAME
--6
alter view [����������_������] with schemabinding
as select FACULTY_NAME[���������], COUNT(*)[���������� ������ ]
from dbo.PULPIT inner join  dbo.FACULTY on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY_NAME;
--7
--7,1
use S_MyBase
create view [��������]
as select ���������.ID [���] , ���������.������� [�������], ���������.�������[������] 
from ���������;
--7,2
create view [���-�� ����������]
as select ���������.ID[�������������], count(*)[���-�� �����������]
from ��������� inner join �������� on ���������.���� = ��������.�������_���������
group by ���������.ID;
--7,3
create view [���������_��_������_2_����]
as select ���������.������� [���������], ���������.���� [����]
from ���������
where ���������.���� = 2
--7,4
create view [���������_��_������_2_����_�_��������]
as select ���������.������� [���������], ���������.���� [����]
from ���������
where ���������.���� = 2 with check option
--5
create view [����� ������� ���������]
as select top 5 ���������.ID [���],���������.������� [�����]
from ���������
order by ���������.ID desc;
----6
create view [���-�� ����������] with schemabinding
as select ���������.ID[�������������], count(*)[���-�� �����������]
from ��������� inner join �������� on ���������.���� = ��������.�������_���������
group by ���������.ID;