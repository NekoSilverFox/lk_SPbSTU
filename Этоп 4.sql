USE db_SPbSTU

--Добавление
--1.	Добавление информации о институте (Institute)
--2.	Добавление информации о направление (Profession)
--3.	Добавление информации о группе (Group)
--4.	Добавление информации о дисциплине (Discipline)
--Изменение
--1.	Изменение информации о институте (Institute)
--2.	Изменение информации о направление (Profession)
--3.	Изменение информации о работнике (Staff)
--4.	Изменение информации о группе (Group)
--5.	Изменение информации о дисциплине (Discipline)
--6.	Изменение информации о учебном плане (StudyPlan)
--7.	Изменение информации о студенте (Student)

--Удаление
--1.	Удаление записи учебного плана из системы (StudyPlan)
--2.	Удаление записи студенты из системы (Student)
--3.	Удаление записи из зачетной книге (ExamRecord)



--Вывод
--1.	Вывод информации обо всех институтах (Institute)
SELECT * FROM tb_Institute
GO

--2.	Вывод информации обо всех направлениях (Discipline)
SELECT IDProfession, ShortNameInst, NameProfession, CodeProfession, TuitionFee
	FROM tb_Profession
	JOIN tb_Institute ON tb_Institute.IDInstitute=tb_Profession.InstituteID
	GROUP BY tb_Institute.ShortNameInst, IDProfession, NameProfession, CodeProfession, TuitionFee
GO

--3.	Вывод информации обо всех работниках (Staff)
SELECT * FROM tb_Staff
GO

--4.	Вывод информации обо всех студентах (Student)
SELECT * FROM tb_Student
GO

--5.	Вывод информации о указанном студенте по ID или ФИО студента
DECLARE @idStu INT=0
DECLARE @nameStu NCHAR(50)='Мэн Цзянин'
SELECT * FROM tb_Student WHERE NameStudent=@nameStu OR IDStudent=@idStu
GO

--6.	Вывод информации о указанном работнике по ID или ФИО работника
DECLARE @idStaff INT=0
DECLARE @nameStaff NCHAR(50)='Кротиков Сергей Ильич'
SELECT * FROM tb_Staff WHERE NameStaff=@nameStaff OR IDStaff=@idStaff
GO




--Сложные
--1.	Просмотр информаций о указанном преподаватели по указанном ID преподаватели (Staff, Account, Institute, Post)
DECLARE @idStaff INT=5
SELECT IDStaff, NameStaff, Gender, Birthday, tb_Staff.Phone, tb_Account.[Login], tb_Staff.Email, Hiredate, tb_Post.NamePost, tb_Institute.NameInstitute
	FROM tb_Staff
	INNER JOIN tb_Account
		ON tb_Account.IDAccount=tb_Staff.AccountID
	INNER JOIN tb_Post
		ON tb_Post.IDPost=tb_Staff.PostID
	INNER JOIN tb_Institute
		ON tb_Institute.IDInstitute=tb_Staff.InstituteID
	WHERE IDStaff=@idStaff
GO

--2.	Вывод групп и студентов, которых обучает указанный преподаватель по ID преподаватели (Staff, StudyPlan, Group, Student)
DECLARE @idStaff INT=11
SELECT IDStudyPlan, NameDiscipline, NameGroup, NameStudent, Semestr
	FROM tb_StudyPlan
	INNER JOIN tb_Discipline
		ON tb_Discipline.IDDiscipline=tb_StudyPlan.DisciplineID
	INNER JOIN tb_Group
		ON tb_Group.IDGroup=tb_StudyPlan.GroupID
	INNER JOIN tb_Student
		ON tb_Student.GroupID=tb_Group.IDGroup
	WHERE tb_StudyPlan.StaffID=@idStaff
	GROUP BY NameGroup, IDStudyPlan, NameDiscipline, Semestr, NameStudent
GO

--3.	Просмотр информаций о указанном студенте по указанном ID студента (Student, Group, Profession, Institute, Account)
DECLARE @idStu INT=(SELECT IDStudent FROM tb_Student WHERE NameStudent='Мэн Цзянин')
SELECT ShortNameInst, NameProfession, NameGroup, Grade, IDStudent, NameStudent, Gender, Birthday, tb_Student.Phone, [Login], tb_Student.Email
	FROM tb_Student
		INNER JOIN tb_Account
			ON tb_Account.IDAccount=tb_Student.AccountID
		INNER JOIN tb_Group
			ON tb_Group.IDGroup=tb_Student.GroupID
		INNER JOIN tb_Profession
			ON tb_Profession.IDProfession=tb_Group.ProfessionID
		INNER JOIN tb_Institute
			ON tb_Institute.IDInstitute=tb_Profession.InstituteID
	WHERE IDStudent=@idStu
GO

--4.	Вывод учебного плана студента по указанном ID студента (Student, Group, StudyPlan, Discipline, Staff)
DECLARE @idStu INT=(SELECT IDStudent FROM tb_Student WHERE NameStudent='Мэн Цзянин')
SELECT IDStudyPlan, NameDiscipline, Semestr AS 'Семестра', PeriodDiscipline AS 'Все. ч', NameStaff AS 'Преподаватель'
	FROM tb_StudyPlan
	INNER JOIN tb_Student
		ON tb_Student.GroupID=tb_StudyPlan.GroupID
	INNER JOIN tb_Group
		ON tb_Group.IDGroup=tb_StudyPlan.GroupID
	INNER JOIN tb_Discipline
		ON tb_Discipline.IDDiscipline=tb_StudyPlan.DisciplineID
	INNER JOIN tb_Staff
		ON tb_Staff.IDStaff=tb_StudyPlan.StaffID
	WHERE IDStudent=@idStu
	ORDER BY Semestr
GO

--5.	Вывод зачетной книжки студента по указанном ID студента (Student, Group, StudyPlan, ExamRecord, Discipline, Staff)
-- 如果同一个考试有多个考试，那么就把分数最高的那次给输出！
-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！https://www.codenong.com/7745609/
DECLARE @idStu INT=(SELECT IDStudent FROM tb_Student WHERE NameStudent='Мэн Цзянин')
SELECT *
	FROM tb_ExamRecord
	INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
	(
		SELECT StudyPlanID, MAX(Mark) AS TmpBestMark
		FROM tb_ExamRecord
		WHERE StudentID=@idStu
		GROUP BY StudyPlanID
	) ChooseBestMark
		ON tb_ExamRecord.StudyPlanID=ChooseBestMark.StudyPlanID AND tb_ExamRecord.Mark=ChooseBestMark.TmpBestMark
	WHERE StudentID=@idStu
GO


DECLARE @idStu INT=(SELECT IDStudent FROM tb_Student WHERE NameStudent='Мэн Цзянин')
SELECT tb_ExamRecord.StudyPlanID, Mark AS BestMark, IDExamRecord, StudentID
	FROM tb_ExamRecord
	INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
	(
		SELECT StudyPlanID, MAX(Mark) AS TmpBestMark
		FROM tb_ExamRecord
		WHERE StudentID=@idStu
		GROUP BY StudyPlanID
	) ChooseBestMark
		ON tb_ExamRecord.StudyPlanID=ChooseBestMark.StudyPlanID AND tb_ExamRecord.Mark=ChooseBestMark.TmpBestMark
	WHERE StudentID=@idStu
	GROUP BY tb_ExamRecord.StudyPlanID, Mark, IDExamRecord, StudentID
	ORDER BY tb_ExamRecord.StudyPlanID, Mark DESC
GO


DECLARE @idStu INT=(SELECT IDStudent FROM tb_Student WHERE NameStudent='Мэн Цзянин')
SELECT Semestr, NameDiscipline, Mark, ExamDate
	FROM tb_ExamRecord
	INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
	(
		SELECT StudyPlanID, MAX(Mark) AS TmpBestMark
		FROM tb_ExamRecord
		WHERE StudentID=@idStu
		GROUP BY StudyPlanID
	) ChooseBestMark
		ON tb_ExamRecord.StudyPlanID=ChooseBestMark.StudyPlanID AND tb_ExamRecord.Mark=ChooseBestMark.TmpBestMark
	INNER JOIN tb_StudyPlan
		ON tb_StudyPlan.IDStudyPlan=tb_ExamRecord.StudyPlanID
	INNER JOIN tb_Discipline
		ON tb_StudyPlan.DisciplineID=tb_Discipline.IDDiscipline
	WHERE StudentID=@idStu
	ORDER BY Semestr
GO



--Представления
--1.	Представление, показывающее групп и ей направлениях и институтах
IF EXISTS(select * from sysobjects where name='VW_ProfByInst')
	drop view VW_ProfByInst
GO
CREATE VIEW VW_ProfByInst
AS
	SELECT ShortNameInst, CodeProfession, NameProfession, TuitionFee
		FROM tb_Profession
		INNER JOIN tb_Institute
			ON tb_Profession.InstituteID=tb_Institute.IDInstitute
GO

SELECT * FROM VW_ProfByInst


--2.	Представление, показывающее предлагаемых дисциплиной и их преподаватели
IF EXISTS(select * from sysobjects where name='VW_StudyPlanAndTeacher')
	drop view VW_StudyPlanAndTeacher
GO
CREATE VIEW VW_StudyPlanAndTeacher
AS
	SELECT IDStudyPlan, NameDiscipline, NameGroup, Semestr, PeriodDiscipline, NameStaff
	FROM tb_StudyPlan
	INNER JOIN tb_Staff
		ON tb_Staff.IDStaff=tb_StudyPlan.StaffID
	INNER JOIN tb_Group
		ON tb_Group.IDGroup=tb_StudyPlan.GroupID
	INNER JOIN tb_Discipline
		ON tb_Discipline.IDDiscipline=tb_StudyPlan.DisciplineID
GO

SELECT * FROM VW_StudyPlanAndTeacher

--3.	Представление, показывающее подробной информации о результатах экзаменов (с информацией о студенте, группе и преподавателе)
--4.	Представление, показывающее студентов, которые сдали все экзамены
--5.	Представление, показывающее групп, в которых нет свободных мест

--Хранимые процедуры
--1.	Добавление информации о новом работнике, его логине и пароле (Staff, Account)
--2.	Добавление информации о новом студенте, его логине и пароле (Student, Account)
--3.	Добавление информации о новом учебном плане по названию группы и названию дисциплины (StudyPlan, Group, Discipline)
--4.	Добавление нового записи в зачетном книге по ФИО студенту, названию группы и названию дисциплины (ExamRecord, Student, Group, Discipline, StudyPlan)

--Триггеры
--1.	Триггер, запрещающий добавлять новый студент в группе, если группа переполнена
--2.	Триггер, запрещающий добавлять новый учебный план, если он раньше, чем курс группы
 
