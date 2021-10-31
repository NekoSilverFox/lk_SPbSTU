USE db_SPbSTU


SELECT * FROM tb_Student
SELECT Class, COUNT(*) FROM tb_Student WHERE InstituteShortName='§ª§¬§¯§´' GROUP BY Class ORDER BY Class
SELECT Class, COUNT(*) FROM tb_Student WHERE InstituteShortName='§ª§¬§¯§´' GROUP BY Class HAVING COUNT(*)>=5 ORDER BY Class

INSERT INTO tb_Account VALUES('men.ts@edu.spbstu.ru', 'ASDEASF')

INSERT INTO tb_Student(StudentName, Gender, Birthday, Phone, Account, Email, 
						InstituteShortName, ProfessionCode, Degree, StudyType, EnrollTime, Class, TrainStatus)
	VALUES('§®§ï§ß §¸§Ù§ñ§ß§Ú§ß', 1, '2000-3-1', '9046465602', 'men.ts@edu.spbstu.ru', 'weidufox@gmail.com',
			'§ª§¬§¯§´', '09.03.04', '§¢§Ñ§Ü§Ñ§Ý§Ñ§Ó§â§Ñ', '§°§é§ß§Ñ§ñ', '2019-9-1', '3530404/90102', '§µ§é§Ú§ä§ã§ñ')

UPDATE tb_Student SET EnrollTime='2018-09-01' WHERE StudentName='§®§ï§ß §¸§Ù§ñ§ß§Ú§ß'

SELECT InstituteShortName AS §ª§ß§ã§ä§Ú§Õ§å§ä, Class AS §¤§â§å§á§á§Ñ, COUNT(*) AS §¬§à§Ý§Ú§é§Ö§ã§ä§Ó§à§³§ä§å§Õ§Ö§ß§ä§à§Ó
		FROM tb_Student WHERE Gender=1
			GROUP BY instituteShortName, Class
				HAVING COUNT(*)>=5
					ORDER BY instituteShortName, Class


SELECT * FROM tb_Student WHERE StudentName LIKE '§®§ï§ß %'
DELETE FROM tb_Student WHERE StudentName LIKE '§®§ï§ß %'