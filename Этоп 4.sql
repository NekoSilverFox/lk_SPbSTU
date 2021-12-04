USE db_SPbSTU
-- ============================================================================================
--Добавление
--1.	Добавление информации о институте (Institute)
--2.	Добавление информации о направление (Profession)
--3.	Добавление информации о группе (Group)
--4.	Добавление информации о дисциплине (Discipline)
-- ============================================================================================

-- ============================================================================================
--Изменение
--1.	Изменение информации о институте (Institute)
UPDATE tb_Institute set Phone='9999998999' where ShortNameInst='ГИ'

--2.	Изменение информации о направление (Profession)
UPDATE tb_Profession set NameProfession='Лингвистика2' where CodeProfession='45.04.02'

--3.	Изменение информации о работнике (Staff)
UPDATE tb_Staff set NameStaff='Иван А. С.'  where NameStaff='Иван2'

--4.	Изменение информации о группе (Group)
UPDATE tb_Group SET NameGroup='3530904/90105' WHERE NameGroup='3530904/90005'

--5.	Изменение информации о дисциплине (Discipline)
UPDATE tb_Discipline SET PeriodDiscipline=88 WHERE NameDiscipline='История'

--6.	Изменение информации о учебном плане (StudyPlan)
UPDATE tb_StudyPlan SET StaffID=4 WHERE IDStudyPlan=3

--7.	Изменение информации о студенте (Student)
UPDATE tb_Student SET Phone='9555555555' WHERE NameStudent='Мэн Цзянин'



-- ============================================================================================

-- ============================================================================================
--Удаление
--1.	Удаление записи учебного плана из системы (StudyPlan)
DELETE tb_StudyPlan WHERE IDStudyPlan=41

--2.	Удаление записи студенты из системы (Student)
DELETE tb_Student WHERE IDStudent=(SELECT IDStudent FROM tb_Student WHERE NameStudent='Мэн Цзянин')

--3.	Удаление записи из зачетной книге (ExamRecord)
DELETE tb_ExamRecord WHERE IDExamRecord=44
-- ============================================================================================





-- ============================================================================================
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
-- ============================================================================================





-- ============================================================================================
--Сложные
-- ============================================================================================
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
--		Выход по наивысшей оценке
-- 如果同一个考试有多个考试，那么就把分数最高的那次给输出！
-- 【重点】如果要某一列的最高分，就用它【自交】来筛选！！！参考：codenong.com/7745609/
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


-- ============================================================================================
--Представления
-- ============================================================================================

--1.	Представление, показывающее групп и ей направлениях и институтах
IF EXISTS(select * from sysobjects where name='VW_ProfByInst')
	drop view VW_ProfByInst
GO
CREATE VIEW VW_ProfByInst
AS
	SELECT ShortNameInst, CodeProfession, NameProfession, NameGroup
		FROM tb_Profession
		INNER JOIN tb_Institute
			ON tb_Profession.InstituteID=tb_Institute.IDInstitute
		INNER JOIN tb_Group
			ON tb_Group.ProfessionID=tb_Profession.IDProfession
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
IF EXISTS(select * from sysobjects where name='VW_ExamWithInfo')
	drop view VW_ExamWithInfo
GO
GO
CREATE VIEW VW_ExamWithInfo
AS
	SELECT NameGroup, NameStudent, Semestr, NameDiscipline, Mark, NameStaff, ExamDate
	FROM tb_ExamRecord
	INNER JOIN tb_StudyPlan
		ON tb_StudyPlan.IDStudyPlan=tb_ExamRecord.StudyPlanID
	INNER JOIN tb_Discipline
		ON tb_Discipline.IDDiscipline=tb_StudyPlan.DisciplineID
	INNER JOIN tb_Staff
		ON tb_Staff.IDStaff=tb_StudyPlan.StaffID
	INNER JOIN tb_Group
		ON tb_Group.IDGroup=tb_StudyPlan.GroupID
	INNER JOIN tb_Student
		ON tb_Student.IDStudent=tb_ExamRecord.StudentID
	GROUP BY NameGroup, NameStudent, Semestr, NameDiscipline, Mark, NameStaff, ExamDate
GO

SELECT * FROM VW_ExamWithInfo



--4.	Представление, показывающее студентов, которые сдали все экзамены и оценка должна быть больше или равна 3 (而且分数要大于3分)
-- 先找到学生(通过的)考试的次数统计
SELECT tb_ExamRecord.StudentID, COUNT(tb_ExamRecord.StudentID) AS numPassExam
	FROM tb_ExamRecord
	INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
	(
		SELECT StudentID, StudyPlanID, MAX(Mark) AS BestMark
		FROM tb_ExamRecord
		GROUP BY  StudyPlanID, StudentID
	) ChooseBestMark
		ON ChooseBestMark.StudentID=tb_ExamRecord.StudentID
			AND ChooseBestMark.StudyPlanID=tb_ExamRecord.StudyPlanID
			AND ChooseBestMark.BestMark=tb_ExamRecord.Mark
	WHERE Mark>2	-- 分数大于2才算是通过考试
	GROUP BY tb_ExamRecord.StudentID
	
-- 先找到学生考试的次数统计，再找到他们的班级
SELECT tb_Student.GroupID, tb_ExamRecord.StudentID, COUNT(tb_ExamRecord.StudentID) AS numPassExam
	FROM tb_ExamRecord
	INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
	(
		SELECT StudentID, StudyPlanID, MAX(Mark) AS BestMark
		FROM tb_ExamRecord
		GROUP BY  StudyPlanID, StudentID
	) ChooseBestMark
		ON ChooseBestMark.StudentID=tb_ExamRecord.StudentID
			AND ChooseBestMark.StudyPlanID=tb_ExamRecord.StudyPlanID
			AND ChooseBestMark.BestMark=tb_ExamRecord.Mark
	INNER JOIN tb_Student
		ON tb_Student.IDStudent=tb_ExamRecord.StudentID
	WHERE Mark>2
	GROUP BY tb_Student.GroupID, tb_ExamRecord.StudentID

-- 找到这个班的学生应该考几次
		SELECT tb_StudyPlan.GroupID, COUNT(tb_StudyPlan.GroupID) AS numExam
		FROM tb_StudyPlan
		GROUP BY tb_StudyPlan.GroupID

-- 将他们连接并判断
SELECT *
	FROM 
	(
		SELECT tb_Student.GroupID, tb_ExamRecord.StudentID, COUNT(tb_ExamRecord.StudentID) AS numPassExam
		FROM tb_ExamRecord
		INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
		(
			SELECT StudentID, StudyPlanID, MAX(Mark) AS BestMark
			FROM tb_ExamRecord
			GROUP BY  StudyPlanID, StudentID
		) ChooseBestMark
			ON ChooseBestMark.StudentID=tb_ExamRecord.StudentID
				AND ChooseBestMark.StudyPlanID=tb_ExamRecord.StudyPlanID
				AND ChooseBestMark.BestMark=tb_ExamRecord.Mark
		INNER JOIN tb_Student
			ON tb_Student.IDStudent=tb_ExamRecord.StudentID
		WHERE Mark>2
		GROUP BY tb_Student.GroupID, tb_ExamRecord.StudentID
	) studentWithNumPassExam
	INNER JOIN 
	(
		SELECT tb_StudyPlan.GroupID, COUNT(tb_StudyPlan.GroupID) AS numExam
		FROM tb_StudyPlan
		GROUP BY tb_StudyPlan.GroupID
	) numExamEveryGroup
		ON numExamEveryGroup.GroupID=studentWithNumPassExam.GroupID
		AND numExamEveryGroup.numExam=studentWithNumPassExam.numPassExam

-- 【最终】输出这个学生和他的班级号
SELECT StudentID, numExamEveryGroup.GroupID
	FROM 
	(
		SELECT tb_Student.GroupID, tb_ExamRecord.StudentID, COUNT(tb_ExamRecord.StudentID) AS numPassExam
		FROM tb_ExamRecord
		INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
		(
			SELECT StudentID, StudyPlanID, MAX(Mark) AS BestMark
			FROM tb_ExamRecord
			GROUP BY  StudyPlanID, StudentID
		) ChooseBestMark
			ON ChooseBestMark.StudentID=tb_ExamRecord.StudentID
				AND ChooseBestMark.StudyPlanID=tb_ExamRecord.StudyPlanID
				AND ChooseBestMark.BestMark=tb_ExamRecord.Mark
		INNER JOIN tb_Student
			ON tb_Student.IDStudent=tb_ExamRecord.StudentID
		WHERE Mark>2
		GROUP BY tb_Student.GroupID, tb_ExamRecord.StudentID
	) studentWithNumPassExam
	INNER JOIN 
	(
		SELECT tb_StudyPlan.GroupID, COUNT(tb_StudyPlan.GroupID) AS numExam
		FROM tb_StudyPlan
		GROUP BY tb_StudyPlan.GroupID
	) numExamEveryGroup
		ON numExamEveryGroup.GroupID=studentWithNumPassExam.GroupID
		AND numExamEveryGroup.numExam=studentWithNumPassExam.numPassExam

-- 【最终】输出这个学生的详细信息
SELECT tb_Institute.ShortNameInst, tb_Profession.NameProfession, tb_Group.NameGroup, tb_Student.IDStudent, tb_Student.NameStudent
	FROM
	(
		SELECT StudentID, numExamEveryGroup.GroupID
		FROM 
		(
			SELECT tb_Student.GroupID, tb_ExamRecord.StudentID, COUNT(tb_ExamRecord.StudentID) AS numPassExam
			FROM tb_ExamRecord
			INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
			(
				SELECT StudentID, StudyPlanID, MAX(Mark) AS BestMark
				FROM tb_ExamRecord
				GROUP BY  StudyPlanID, StudentID
			) ChooseBestMark
				ON ChooseBestMark.StudentID=tb_ExamRecord.StudentID
					AND ChooseBestMark.StudyPlanID=tb_ExamRecord.StudyPlanID
					AND ChooseBestMark.BestMark=tb_ExamRecord.Mark
			INNER JOIN tb_Student
				ON tb_Student.IDStudent=tb_ExamRecord.StudentID
			WHERE Mark>2
			GROUP BY tb_Student.GroupID, tb_ExamRecord.StudentID
		) studentWithNumPassExam
		INNER JOIN 
		(
			SELECT tb_StudyPlan.GroupID, COUNT(tb_StudyPlan.GroupID) AS numExam
			FROM tb_StudyPlan
			GROUP BY tb_StudyPlan.GroupID
		) numExamEveryGroup
			ON numExamEveryGroup.GroupID=studentWithNumPassExam.GroupID
			AND numExamEveryGroup.numExam=studentWithNumPassExam.numPassExam
	) studentPassAllExam
	INNER JOIN tb_Student
		ON tb_Student.IDStudent=studentPassAllExam.StudentID
	INNER JOIN tb_Group
		ON tb_Group.IDGroup=tb_Student.GroupID
	INNER JOIN tb_Profession
		ON tb_Profession.IDProfession=tb_Group.ProfessionID
	INNER JOIN tb_Institute
		ON tb_Institute.IDInstitute=tb_Profession.InstituteID
	GROUP BY tb_Institute.ShortNameInst, tb_Profession.NameProfession, tb_Group.NameGroup, tb_Student.IDStudent, tb_Student.NameStudent

-- 封装成一个视图
IF EXISTS(select * from sysobjects where name='VW_studentPassAllExam')
	drop view VW_studentPassAllExam
GO
CREATE VIEW VW_studentPassAllExam
AS
	SELECT tb_Institute.ShortNameInst, tb_Profession.NameProfession, tb_Group.NameGroup, tb_Student.IDStudent, tb_Student.NameStudent
		FROM
		(
			SELECT StudentID, numExamEveryGroup.GroupID
			FROM 
			(
				SELECT tb_Student.GroupID, tb_ExamRecord.StudentID, COUNT(tb_ExamRecord.StudentID) AS numPassExam
				FROM tb_ExamRecord
				INNER JOIN	-- 【重点】如果要某一列的最高分，就用它自交来筛选！！！
				(
					SELECT StudentID, StudyPlanID, MAX(Mark) AS BestMark
					FROM tb_ExamRecord
					GROUP BY  StudyPlanID, StudentID
				) ChooseBestMark
					ON ChooseBestMark.StudentID=tb_ExamRecord.StudentID
						AND ChooseBestMark.StudyPlanID=tb_ExamRecord.StudyPlanID
						AND ChooseBestMark.BestMark=tb_ExamRecord.Mark
				INNER JOIN tb_Student
					ON tb_Student.IDStudent=tb_ExamRecord.StudentID
				WHERE Mark>2
				GROUP BY tb_Student.GroupID, tb_ExamRecord.StudentID
			) studentWithNumPassExam
			INNER JOIN 
			(
				SELECT tb_StudyPlan.GroupID, COUNT(tb_StudyPlan.GroupID) AS numExam
				FROM tb_StudyPlan
				GROUP BY tb_StudyPlan.GroupID
			) numExamEveryGroup
				ON numExamEveryGroup.GroupID=studentWithNumPassExam.GroupID
				AND numExamEveryGroup.numExam=studentWithNumPassExam.numPassExam
		) studentPassAllExam
		INNER JOIN tb_Student
			ON tb_Student.IDStudent=studentPassAllExam.StudentID
		INNER JOIN tb_Group
			ON tb_Group.IDGroup=tb_Student.GroupID
		INNER JOIN tb_Profession
			ON tb_Profession.IDProfession=tb_Group.ProfessionID
		INNER JOIN tb_Institute
			ON tb_Institute.IDInstitute=tb_Profession.InstituteID
		GROUP BY tb_Institute.ShortNameInst, tb_Profession.NameProfession, tb_Group.NameGroup, tb_Student.IDStudent, tb_Student.NameStudent
GO

SELECT * FROM VW_studentPassAllExam



--5.	Представление, показывающее групп, в которых нет свободных мест
IF EXISTS(select * from sysobjects where name='VW_GroupHavePlace')
	drop view VW_GroupHavePlace
GO
CREATE VIEW VW_GroupHavePlace
AS
	SELECT IDGroup, NameGroup, Grade, numStudentHave, Quantity
	FROM tb_Group
	INNER JOIN
	(
		SELECT GroupID, COUNT(GroupID) as numStudentHave
		FROM tb_Student
		GROUP BY GroupID
	) groupWithNumStudentNow
		ON groupWithNumStudentNow.GroupID=tb_Group.IDGroup
	WHERE groupWithNumStudentNow.numStudentHave<tb_Group.Quantity
GO

SELECT * FROM VW_GroupHavePlace



-- ============================================================================================
--Хранимые процедуры
-- ============================================================================================
-- 确定用户类型
IF exists(select * from sysobjects where name='usp_AccountType')
	drop proc usp_AccountType
GO
CREATE PROC usp_AccountType
	@AccountID			int
AS
	SELECT 
		CASE PostID
			WHEN 1 THEN 'Admin'
			WHEN 2 THEN 'Teacher'
			ELSE 'Student'
		END AS 'UserType'
	FROM tb_Account
		FULL JOIN tb_Staff
			ON tb_Staff.AccountID=tb_Account.IDAccount
		FULL JOIN tb_Student
			ON tb_Student.AccountID=tb_Account.IDAccount
	WHERE tb_Account.IDAccount=@AccountID
GO	

EXEC usp_AccountType 7435
EXEC usp_AccountType 7420




--1.	Добавление информации о новом работнике, его логине и пароле (Staff, Account)
IF exists(select * from sysobjects where name='usp_addStaff')
	drop proc usp_addStaff
GO
CREATE PROC usp_addStaff
	@Login			varchar(64)		,
	@Passwd			varchar(16)		,
	@NameStaff		nvarchar(64)	,
	@Gender			bit=1			,
	@Birthday		date=NULL		,
	@Phone			char(15)		,
	@Email			varchar(64)=NULL,
	@Hiredate		date			,	
	@PostName		nvarchar(256)	,		
	@ShortNameInst	nvarchar(16)
AS
BEGIN TRANSACTION
	DECLARE @errorNum INT=0;

	INSERT tb_Account([Login], Passwd) VALUES(@Login, @Passwd)
	SET @errorNum+=@@ERROR

	DECLARE @AccountID INT=(SELECT IDAccount FROM tb_Account WHERE [Login]=@Login)
	DECLARE @PostID INT=(SELECT IDPost FROM tb_Post WHERE NamePost=@PostName)
	DECLARE @InstID INT=(SELECT IDInstitute FROM tb_Institute WHERE ShortNameInst=@ShortNameInst)

	INSERT tb_Staff(NameStaff, Gender, Birthday, Phone, AccountID, Email, Hiredate, PostID, InstituteID)
		VALUES(@NameStaff, @Gender, @Birthday, @Phone, @AccountID, @Email, @Hiredate, @PostID, @InstID)
	SET @errorNum+=@@ERROR

	IF (@errorNum<>0)
		ROLLBACK TRANSACTION
	ELSE 
		COMMIT TRANSACTION
GO

EXEC usp_addStaff
	@Login='iwann.bnn2@edu.spbstu.ru', @Passwd='asg4wafa', 
	@NameStaff='Иван2', @Birthday='1991-05-04',
	@Phone='9456123565', @Hiredate='2018-04-02',
	@PostName='Преподаватель', @ShortNameInst='ИКНТ'

EXEC usp_addStaff
	@Login='admin@edu.spbstu.ru', @Passwd='adminadmin', 
	@NameStaff='admin', @Birthday='1990-01-01',
	@Phone='9999999999', @Hiredate='2017-01-01',
	@PostName='Администратор', @ShortNameInst='ИКНТ'

--2.	Добавление информации о новом студенте, его логине и пароле (Student, Account)
IF exists(select * from sysobjects where name='usp_addStudent')
	drop proc usp_addStudent
GO
CREATE PROC usp_addStudent
	@Login			varchar(64)		,
	@Passwd			varchar(16)		,
	@NameStudent	nvarchar(64)	,
	@Gender			bit=1			,
	@Birthday		date=NULL		,
	@Phone			char(15)		,
	@Email			varchar(64)=NULL,
	@EnrollTime		date			,	
	@NameGroup		varchar(16)
AS
BEGIN TRANSACTION
	DECLARE @errorNum INT=0;

	INSERT tb_Account([Login], Passwd) VALUES(@Login, @Passwd)
	SET @errorNum+=@@ERROR

	DECLARE @AccountID INT=(SELECT IDAccount FROM tb_Account WHERE [Login]=@Login)
	DECLARE @GroupID INT=(SELECT IDGroup FROM tb_Group WHERE NameGroup=@NameGroup)

	INSERT tb_Student(NameStudent, Gender, Birthday, Phone, AccountID, Email, EnrollTime, GroupID)
		VALUES(@NameStudent, @Gender, @Birthday, @Phone, @AccountID, @Email, @EnrollTime, @GroupID)
	SET @errorNum+=@@ERROR

	IF (@errorNum<>0)
		ROLLBACK TRANSACTION
	ELSE 
		COMMIT TRANSACTION
GO


EXEC usp_addStudent
	@Login='jerry@@edu.spbstu.ru', @Passwd='asg4wafa', 
	@NameStudent='jerry', @Birthday='1999-05-04',
	@Phone='9456694025', @EnrollTime='2019-09-02',
	@NameGroup='3530904/90004'


--3.	Добавление информации о новом учебном плане по названию группы и названию дисциплины (StudyPlan, Group, Discipline)
IF exists(select * from sysobjects where name='usp_addStudyPlan')
	drop proc usp_addStudyPlan
GO
CREATE PROC usp_addStudyPlan
	@NameDiscipline	nvarchar(256),
	@NameGroup		varchar(16),
	@Semestr		int,
	@NameTeacher	nvarchar(64)
AS
BEGIN TRANSACTION
	DECLARE @errorNum INT=0;
	DECLARE @DisciplineID INT=(SELECT IDDiscipline FROM tb_Discipline WHERE NameDiscipline=@NameDiscipline)
	DECLARE @GroupID INT=(SELECT IDGroup FROM tb_Group WHERE NameGroup=@NameGroup)
	DECLARE @StaffID INT=(SELECT IDStaff FROM tb_Staff WHERE NameStaff=@NameTeacher)
	
	-- 先判断之前有没有相同的，避免插入重复值
	DECLARE @isHave INT=(SELECT TOP 1 IDStudyPlan FROM tb_StudyPlan WHERE GroupID=@GroupID AND DisciplineID=@DisciplineID AND Semestr=@Semestr)
	IF (@isHave IS NOT NULL)
		ROLLBACK TRANSACTION

	INSERT tb_StudyPlan(GroupID, DisciplineID, Semestr, StaffID)
		VALUES(@GroupID, @DisciplineID, @Semestr, @StaffID)
	SET @errorNum+=@@ERROR

	IF (@errorNum<>0)
		ROLLBACK TRANSACTION
	ELSE 
		COMMIT TRANSACTION
GO

EXEC usp_addStudyPlan @NameDiscipline='Физика', @NameGroup='3530904/90004', @Semestr=6, @NameTeacher='Соловьева Екатерина Витальевна'


-- 4.	Добавление нового записи в зачетном книге по ФИО студенту,
--		названию группы и названию дисциплины (ExamRecord, Student, Group, Discipline, StudyPlan)
IF exists(select * from sysobjects where name='usp_addExamRecord')
	drop proc usp_addExamRecord
GO
CREATE PROC usp_addExamRecord
	@NameDiscipline	nvarchar(256),
	@NameGroup		varchar(16),
	@Semestr		int,
	@NameStudent	nvarchar(64),
	@Mark			int,
	@ExamDate		date
AS
BEGIN TRANSACTION
	DECLARE @errorNum INT=0;
	DECLARE @DisciplineID INT=(SELECT IDDiscipline FROM tb_Discipline WHERE NameDiscipline=@NameDiscipline)
	DECLARE @GroupID INT=(SELECT IDGroup FROM tb_Group WHERE NameGroup=@NameGroup)
	DECLARE @StudentID INT=(SELECT IDStudent FROM tb_Student WHERE NameStudent=@NameStudent)
	DECLARE @StudyPlanID INT=(SELECT TOP 1 IDStudyPlan FROM tb_StudyPlan WHERE GroupID=@GroupID AND DisciplineID=@DisciplineID AND Semestr=@Semestr)
	SET @errorNum+=@@ERROR

	INSERT tb_ExamRecord(StudyPlanID, StudentID, Mark, ExamDate)
		VALUES(@StudyPlanID, @StudentID, @Mark, @ExamDate)
	SET @errorNum+=@@ERROR

	IF (@errorNum<>0)
		ROLLBACK TRANSACTION
	ELSE 
		COMMIT TRANSACTION
GO

--SELECT * FROM tb_Student WHERE GroupID=(SELECT IDGroup FROM tb_Group WHERE NameGroup='3530904/90001')
EXEC usp_addExamRecord @NameDiscipline='Физика', @NameGroup='3530904/90001', @Semestr=2, @NameStudent='Викторов Дмитрий Дмитриевич', @Mark=5, @ExamDate='2021-10-05'

select * from tb_ExamRecord where studentid=(select IDStudent from tb_Student where NameStudent='Викторов Дмитрий Дмитриевич')




-- ============================================================================================
--Триггеры
-- ============================================================================================
--1.	Триггер, запрещающий добавлять новый студент в группе, если группа переполнена
USE db_SPbSTU
IF EXISTS(SELECT * FROM SYSOBJECTS WHERE name='tr_addStudentInGroup')
	DROP TRIGGER tr_addStudentInGroup
GO
CREATE TRIGGER tr_addStudentInGroup
	ON tb_Student
	AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @GroupID INT=(SELECT GroupID FROM inserted)
	DECLARE @quantityGroup INT=(SELECT Quantity FROM tb_Group WHERE IDGroup=@GroupID)
	DECLARE @numStuInGroup INT=(SELECT COUNT(*) FROM tb_Student WHERE GroupID=@GroupID)

	IF (@quantityGroup<=@numStuInGroup)
	BEGIN
		PRINT '[ERROR] This Group already has full, can not insert to this group!'
		ROLLBACK TRANSACTION
	END
END

--
GO
DISABLE TRIGGER tr_addStudentInGroup ON TB_STUDENT
GO
ENABLE TRIGGER tr_addStudentInGroup ON TB_STUDENT
GO

-- 314 这个班级满人了
SELECT * 
	FROM tb_Group,
	(SELECT GroupID, COUNT(*) AS numStuNow FROM tb_Student GROUP BY GroupID) setectGroup
	WHERE Quantity=setectGroup.numStuNow
	AND IDGroup=setectGroup.GroupID

-- 测试数据（Insert）：
INSERT tb_Account VALUES('testlogin', 'testpwd')
INSERT tb_Student(NameStudent, Gender, Phone, AccountID, EnrollTime, GroupID)
	VALUES('test', 1, '111111111', (select IDAccount from tb_Account where [Login]='testlogin'), '2018-8-9', 314)

-- 测试数据（Update）：
UPDATE tb_Student SET GroupID=314 WHERE IDStudent=1935000





--2.	Триггер, запрещающий добавлять новый учебный план, если он раньше, чем курс группы
-- Пример: Если студент (грппа) сейчас учится в 5-ом семестре, то для него нельзя добавлять новый учебный план 1-ого семестра.
USE db_SPbSTU
IF EXISTS(SELECT * FROM SYSOBJECTS WHERE name='tr_addStudyPlan')
	DROP TRIGGER tr_addStudyPlan
GO
CREATE TRIGGER tr_addStudyPlan
	ON tb_StudyPlan
	AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @GroupID INT=(SELECT GroupID FROM inserted)
	DECLARE @Grade INT=(SELECT Grade FROM tb_Group WHERE IDGroup=@GroupID)
	DECLARE @EnrollTime CHAR(10)=(CONVERT(CHAR(4), @Grade) + '-09-01')
	DECLARE @semestrGroupNow INT=(CEILING(DATEDIFF(MM, @EnrollTime, GETDATE())/6+1))
	DECLARE @semestrStydyPlan INT=(SELECT Semestr FROM inserted)

	IF (@semestrStydyPlan < @semestrGroupNow)
	BEGIN
		PRINT '[ERROR] Can not insert to this semestr, semestr can not be less than the current semestr of the group!'
		ROLLBACK TRANSACTION
	END
END
GO
DISABLE TRIGGER tr_addStudyPlan ON tb_StudyPlan
GO
ENABLE TRIGGER tr_addStudyPlan ON tb_StudyPlan
GO

SELECT * FROM tb_Group WHERE IDGroup=314
INSERT tb_StudyPlan VALUES(314, 1, 3, 1)	-- ERROR
INSERT tb_StudyPlan VALUES(314, 1, 8, 1)	-- OK