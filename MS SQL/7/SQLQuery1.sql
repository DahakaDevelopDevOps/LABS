--select TEACHER[���], TEACHER_NAME [���], GENDER[���], PULPIT[�������]
--from TEACHER;
use UNIVER
go
create view [�������������]
as select TEACHER[���], TEACHER_NAME [���], GENDER[���], PULPIT[�������]
from TEACHER;
go
select * from [�������������]
go
--2
create view [���������� ������]
as select FACULTY_NAME[���������], COUNT(*)[���������� ������ ]
from PULPIT inner join FACULTY on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY_NAME
go
--3
create view [���������]
as select AUDITORIUM[���], AUDITORIUM_TYPE[������������ ���������]
from AUDITORIUM
where AUDITORIUM_TYPE like '��%'
go
insert [���������] 
--4
create view [����������_���������]
as select AUDITORIUM, AUDITORIUM_TYPE
from AUDITORIUM
where AUDITORIUM_TYPE like '��%' with check option;
go
--5
create view [����������]
as select top 10 SUBJECT.SUBJECT[���], SUBJECT.SUBJECT_NAME[������������ ���������� ], SUBJECT.PULPIT[��� �������]
from SUBJECT
order by SUBJECT_NAME
go
--6
alter view [����������_������] with schemabinding
as select FACULTY_NAME[���������], COUNT(*)[���������� ������ ]
from dbo.PULPIT inner join  dbo.FACULTY on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY_NAME;
go

--7
--7,1
USE S_MyBase;
GO
CREATE VIEW ������_�������
AS
SELECT * FROM ������ WHERE ��������� = 1;
--7,2
CREATE VIEW ��������_�������
AS
SELECT * FROM �������� WHERE �������_��������� <= 5;
--7,3
CREATE VIEW ����������_��������
AS
SELECT ���������.ID, ���������.�������, ���������.��������, ��������.������������_�������� AS ��������
FROM ��������� JOIN �������� ON ���������.�������� = ��������.�������_���������;
--7,4
CREATE VIEW ���������_������
AS
SELECT * FROM ��������� WHERE ����� IS NOT NULL;
go
--5
CREATE VIEW ������_�_�������������_������_500
AS
SELECT * FROM ������ WHERE �����������_���������_��_����������_������� > 500;
----6
alter view [���-�� ����������] with schemabinding
as select ���������.ID[�����������], count(*)[���-�� ����������]
from dbo.���������_������ inner join dbo.������_������� on ���������_������.���� = ������_�������.�����������_���������_��_����������_�������
group by ���������.ID;
go


