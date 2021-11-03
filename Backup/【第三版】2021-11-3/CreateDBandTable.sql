USE master

----------------------- 创建数据库 -----------------------
IF EXISTS(SELECT * FROM sysdatabases WHERE NAME='db_SPbSTU')
	DROP DATABASE db_SPbSTU
GO

EXECUTE sp_configure 'show advanced options', 1
	Reconfigure
execute sp_configure 'xp_cmdshell',1
	Reconfigure
execute xp_cmdshell 'mkdir D:\SQLServer\DataBase\SPbSTU' 
GO

CREATE DATABASE db_SPbSTU
ON PRIMARY
(
	NAME='db_SPbSTU_data',
	FILENAME='D:\SQLServer\DataBase\SPbSTU\db_SPbSTU_data.mdf',
	SIZE=8MB,
	FILEGROWTH=1MB,
	MAXSIZE=1024MB
)
LOG ON
(
	NAME='db_SPbSTU_log',
	FILENAME='D:\SQLServer\DataBase\SPbSTU\db_SPbSTU_log.log',
	SIZE=1MB,
	FILEGROWTH=1%,
	MAXSIZE=1024MB
)
GO

EXECUTE sp_helpdb DB_SPBSTU
GO



----------------------- 创建 Account 账号表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Account')
	DROP TABLE tb_Account
GO

CREATE TABLE tb_Account
(
	IDAccount	int				IDENTITY(1, 1) not null,
	[Login]		varchar(64)		not null,			-- Логин 
	Passwd		varchar(16)		not null			-- пароль
)


----------------------- 创建 Institute Учебное подразделение 院系表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Institute')
	DROP TABLE tb_Institute
GO

CREATE TABLE tb_Institute
(
	IDInstitute		int				IDENTITY(1, 1) not null,
	NameInstitute	nvarchar(256)	not null,
	ShortNameInst	nvarchar(16)	not null,
	Email			varchar(64)		null,
	Website			varchar(512)	null,
	DetAddress		nvarchar(512)	null,
	Phone			char(10)		not null
)



----------------------- 创建 Profession Направление подготовки 方向表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Profession')
	DROP TABLE tb_Profession
GO

CREATE TABLE tb_Profession
(
	IDProfession		int				IDENTITY(1, 1) not null,
	InstShortName		nvarchar(16)	not null,
	CodeProfession		varchar(16)		not null,
	NameProfession		nvarchar(256)	not null,
	TuitionFee			money			not null
)



----------------------- 创建 Group 表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Group')
	DROP TABLE tb_Group
GO

CREATE TABLE tb_Group
(
	IDGroup				int				IDENTITY(1, 1) not null,
	NameGroup			varchar(16)		not null,		-- 班级 Группа
	ProfessionCode		varchar(16)		not null,		-- 方向 Направление подготовки
	Quantity			int				null
)



----------------------- 创建 Discipline 科目表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Discipline')
	DROP TABLE tb_Discipline
GO

CREATE TABLE tb_Discipline
(
	IDDiscipline		int				IDENTITY(1, 1) not null,
	NameDiscipline		nvarchar(256)	not null,
	PeriodDiscipline	int				not null		-- 课时
)



----------------------- 创建 StudyPlan 学习计划表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_StudyPlan')
	DROP TABLE tb_StudyPlan
GO

CREATE TABLE tb_StudyPlan
(
	IDStudyPlan			int				IDENTITY(1, 1) not null,
	GroupID				int				not null,
	DisciplineID		int				not null,
	Semestr				int				not null,
	StaffID				int				not null
)



----------------------- 创建 ExamRecord 表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_ExamRecord')
	DROP TABLE tb_ExamRecord
GO

CREATE TABLE tb_ExamRecord
(
	IDExamRecord		int				IDENTITY(1, 1) not null,
	StudyPlanID			int				not null,
	StudentID			int				not null,
	Mark				int				not null,
	ExamDate			datetime		not null
)


----------------------- 创建 Student 表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Student')
	DROP TABLE tb_Student
GO

CREATE TABLE tb_Student
(
	IDStudent			int				IDENTITY(1935000, 1) not null,
	NameStudent			nvarchar(64)	not null,
	Gender				bit				not null,
	Birthday			datetime		null,
	Phone				char(10)		not null,
	AccountID			int				not null,		-- edu email
	Email				varchar(64)		null,
	EnrollTime			datetime		not null,	-- 入学年份/时间 Год поступления
	Grade				as CEILING(DATEDIFF(MM, EnrollTime, GETDATE())/12+1),	-- 年级 Курс
	Semester			as CEILING(DATEDIFF(MM, EnrollTime, GETDATE())/6+1),	-- 学期 Семестр
	GroupID				int				not null,		-- 班级 Группа
)



----------------------- 创建 Post 部门表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Post')
	DROP TABLE tb_Post
GO

CREATE TABLE tb_Post
(
	IDPost		int				IDENTITY(1, 1) not null,
	NamePost	nvarchar(256)	not null,
	Salary		money			not null
)



----------------------- 创建 Staff 员工表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Staff')
	DROP TABLE tb_Staff
GO

CREATE TABLE tb_Staff
(
	IDStaff			int				IDENTITY(1, 1) not null,
	NameStaff		nvarchar(64)	not null,
	Gender			bit				not null,
	Birthday		datetime		null,
	Phone			char(10)		not null,
	AccountID		int				not null,		-- edu email
	Email			varchar(64)		null,
	Hiredate		datetime		not null,	-- 入职时间 Время введения в должность 
	PostID			int				null,		-- 职务
	InstShortName	nvarchar(16)	null,		-- 院系 Учебное подразделение
)

