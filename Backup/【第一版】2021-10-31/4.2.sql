USE db_SPbSTU


-- sp_helpdb 查看数据库信息
EXECUTE sp_helpdb db_SPbSTU
GO


-- 更改数据大小
ALTER DATABASE DB_SPBSTU
	MODIFY FILE (NAME='DB_SPBSTU_DATA', MAXSIZE=100MB)
GO

EXECUTE sp_helpdb DB_SPBSTU
GO




-- 收缩指定数据库中的数据文件和日志文件的大小。
DBCC SHRINKDATABASE(db_SPbSTU)
GO


-- 

SELECT * FROM tb_Student
SELECT Class, COUNT(*) FROM tb_Student WHERE InstituteShortName='ИКНТ' GROUP BY Class ORDER BY Class
SELECT Class, COUNT(*) FROM tb_Student WHERE InstituteShortName='ИКНТ' GROUP BY Class HAVING COUNT(*)>=5 ORDER BY Class

INSERT INTO tb_Account VALUES('men.ts@edu.spbstu.ru', 'ASDEASF')
UPDATE dbo.tb_Account SET Passwd='NIOEMNO' WHERE Account='men.ts@edu.spbstu.ru'
SELECT * FROM tb_Account WHERE Account='men.ts@edu.spbstu.ru'

INSERT INTO tb_Student(StudentName, Gender, Birthday, Phone, Account, Email, 
						InstituteShortName, ProfessionCode, DegreeID, StudyTypeID, EnrollTime, Class, TrainStatusID)
	VALUES('Мэн Цзянин', 1, '2000-3-1', '9046465602', 'men.ts@edu.spbstu.ru', 'weidufox@gmail.com',
			'ИКНТ', '09.03.04', 'Бакалавра', 'Очная', '2019-9-1', '3530404/90102', 'Учится')

UPDATE tb_Student SET EnrollTime='2018-09-01' WHERE StudentName='Мэн Цзянин'

SELECT InstituteShortName AS Инстидут, Class AS Группа, COUNT(*) AS КоличествоСтудентов
		FROM tb_Student WHERE Gender=1
			GROUP BY instituteShortName, Class
				HAVING COUNT(*)>=5
					ORDER BY instituteShortName, Class


SELECT * FROM tb_Student WHERE StudentName LIKE 'Мэн %'
DELETE FROM tb_Student WHERE StudentName LIKE 'Мэн %'

