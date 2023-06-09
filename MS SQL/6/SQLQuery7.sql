USE S_MyBase
SELECT ������.����������_������� AS AMOUNT_OF_DETAILS,
       COUNT(*) AS TOTAL_AUDITORIUMS,
       MIN(������.����������_�������) AS MIN_CAPACITY,
       MAX(������.����������_�������) AS MAX_CAPACITY,
       AVG(������.����������_�������) AS AVG_CAPACITY,
       SUM(������.����������_�������) AS TOTAL_CAPACITY
FROM ������
INNER JOIN �������� at ON ������.��������� = ������.���������
GROUP BY ������.����������_�������;
----------------------------------------------------------------------------
SELECT GRADES.���������, COUNT(*) AS �������_�����
FROM (
  SELECT CASE 
           WHEN ���������.���� >= 3 THEN '9-10'
           WHEN ���������.���� >= 2 THEN '7-8'
           WHEN ���������.���� >= 1 THEN '5-6'
           ELSE '0-4'
         END AS ���������,
         ���������.����
  FROM ���������
  WHERE ���������.���� BETWEEN 1 AND 3
) AS GRADES
GROUP BY GRADES.���������
ORDER BY GRADES.��������� DESC;
------------------------------------------------------------------------------
SELECT ���������.ID, ������.���������, ��������.�������_���������, 
    ROUND(AVG(CAST(������.��������� AS FLOAT)), 2) AS AVG_GRADE
FROM ���������
INNER JOIN �������� ON ���������.ID = ��������.������������_��������
INNER JOIN ������ ON ������.��������� = ��������.�������_���������
GROUP BY ���������.ID, ������.���������, ��������.�������_���������
ORDER BY AVG_GRADE DESC;

------------------------------------------------------------------------------
SELECT 
  ���������.ID, 
  ���������.����, 
  ���������.��������, 
  ������.���������, 
  ROUND(AVG(CAST(������.��������� AS FLOAT)), 2) AS AVERAGE_GRADE
FROM 
  ���������
  JOIN �������� ON ���������.ID = ��������.�������_��������� 
  JOIN ������ ON ���������.���� = ������.���������  
WHERE 
  ���������.���� IN (1, 2)
GROUP BY 
  ���������.ID, 
  ���������.����, 
  ������.���������, 
  ���������.�������� 
ORDER BY 
  AVERAGE_GRADE DESC;
  -------------------------------------------------------------------------------------
SELECT ���������.ID AS SPECIALTY, ���������.�������� AS DISCIPLINE, ROUND(AVG(���������.����), 2) AS AVG_GRADE
FROM ���������
INNER JOIN ������ ON ���������.ID = ������.���������
INNER JOIN �������� ON ���������.ID = ��������.�������_���������
WHERE ���������.ID = 1
GROUP BY ���������.ID, ��������.�������_���������, ���������.��������;
---------------------------------------------------------------------------------
SELECT ���������.����, COUNT(*) AS 'Workers with experience between 2 and 3 years'
FROM ���������
WHERE ���������.���� IN (2, 3)
GROUP BY ���������.����
HAVING COUNT(*) > 0
ORDER BY COUNT(*) DESC;
