USE db_SPbSTU


-- sp_helpdb �鿴���ݿ���Ϣ
EXECUTE sp_helpdb db_SPbSTU
GO


-- �������ݴ�С
ALTER DATABASE DB_SPBSTU
	MODIFY FILE (NAME='DB_SPBSTU_DATA', MAXSIZE=100MB)
GO

EXECUTE sp_helpdb DB_SPBSTU
GO




-- ����ָ�����ݿ��е������ļ�����־�ļ��Ĵ�С��
DBCC SHRINKDATABASE(db_SPbSTU)
GO


-- 

SELECT * FROM tb_Student
SELECT Class, COUNT(*) FROM tb_Student WHERE InstituteShortName='��������' GROUP BY Class ORDER BY Class
SELECT Class, COUNT(*) FROM tb_Student WHERE InstituteShortName='��������' GROUP BY Class HAVING COUNT(*)>=5 ORDER BY Class

INSERT INTO tb_Account VALUES('men.ts@edu.spbstu.ru', 'ASDEASF')
UPDATE dbo.tb_Account SET Passwd='NIOEMNO' WHERE Account='men.ts@edu.spbstu.ru'
SELECT * FROM tb_Account WHERE Account='men.ts@edu.spbstu.ru'

INSERT INTO tb_Student(StudentName, Gender, Birthday, Phone, Account, Email, 
						InstituteShortName, ProfessionCode, DegreeID, StudyTypeID, EnrollTime, Class, TrainStatusID)
	VALUES('����� ���٧�ߧڧ�', 1, '2000-3-1', '9046465602', 'men.ts@edu.spbstu.ru', 'weidufox@gmail.com',
			'��������', '09.03.04', '���ѧܧѧݧѧӧ��', '����ߧѧ�', '2019-9-1', '3530404/90102', '����ڧ���')

UPDATE tb_Student SET EnrollTime='2018-09-01' WHERE StudentName='����� ���٧�ߧڧ�'

SELECT InstituteShortName AS ���ߧ��ڧէ��, Class AS ��������, COUNT(*) AS ����ݧڧ�֧��ӧ৳���է֧ߧ���
		FROM tb_Student WHERE Gender=1
			GROUP BY instituteShortName, Class
				HAVING COUNT(*)>=5
					ORDER BY instituteShortName, Class


SELECT * FROM tb_Student WHERE StudentName LIKE '����� %'
DELETE FROM tb_Student WHERE StudentName LIKE '����� %'

