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
	AccountID	int				IDENTITY(1, 1) not null,
	Account		varchar(64)		not null,
	Passwd		varchar(16)		not null
)


----------------------- 创建 Degree 学位表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Degree')
	DROP TABLE tb_Degree
GO

CREATE TABLE tb_Degree
(
	DegreeID		int				IDENTITY(1, 1) not null,
	DegreeType		nvarchar(64)	not null
)


----------------------- 创建 StudyType 培训方式表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_StudyType')
	DROP TABLE tb_StudyType
GO

CREATE TABLE tb_StudyType
(
	StudyTypeID		int				IDENTITY(1, 1) not null,
	StudyType		nvarchar(64)	not null
)

----------------------- 创建 Institute 院系表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Institute')
	DROP TABLE tb_Institute
GO

CREATE TABLE tb_Institute
(
	InstituteID		int				IDENTITY(10, 1) not null,
	InstituteName	nvarchar(256)	not null,
	ShortName		nvarchar(16)	not null,
	Email			varchar(64)		null,
	Website			varchar(512)	null,
	DetAddress		nvarchar(512)	null,
	Phone			char(10)		not null
)


----------------------- 创建 Profession 方向表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Profession')
	DROP TABLE tb_Profession
GO

CREATE TABLE tb_Profession
(
	ProfessionID	int				IDENTITY(1, 1) not null,
	InstituteShortName nvarchar(16)	not null,
	ProfessionCode	varchar(16)		not null,
	ProfessionName	nvarchar(256)	not null,
	TuitionFee		money			not null
)


----------------------- 创建 TrainStatus 学生培训状态表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_TrainStatus')
	DROP TABLE tb_TrainStatus
GO

CREATE TABLE tb_TrainStatus
(
	TrainStatusID		int				IDENTITY(1, 1) not null,
	TrainStatusType		nvarchar(64)	not null
)


----------------------- 创建 Group 表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Groups')
	DROP TABLE tb_Groups
GO

CREATE TABLE tb_Groups
(
	GroupId				int				IDENTITY(1, 1) not null,
	GroupName			varchar(16)		not null,		-- 班级 Группа
	ProfessionCode		varchar(16)		not null,		-- 方向 Направление подготовки
	Quantity			int				null
)

----------------------- 创建 Student 表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Student')
	DROP TABLE tb_Student
GO

CREATE TABLE tb_Student
(
	StudentID		int				IDENTITY(1935000, 1) not null,
	StudentName		nvarchar(64)	not null,
	Gender			bit				not null,
	Birthday		datetime		null,
	Phone			char(10)		not null,
	Account			varchar(64)		null,		-- edu email
	Email			varchar(64)		null,
	InstituteShortName	nvarchar(16)	null,	-- 院系 Учебное подразделение
	ProfessionCode	varchar(16)		null,		-- 方向 Направление подготовки
	DegreeID		int				not null,	-- 学位 Уровень подготовки
	StudyTypeID		int				not null,	-- 培训方式 Форма обучения
	EnrollTime		datetime		not null,	-- 入学年份/时间 Год поступления
	Grade			as CEILING(DATEDIFF(MM, EnrollTime, GETDATE())/12+1),	-- 年级 Курс
	Semester		as CEILING(DATEDIFF(MM, EnrollTime, GETDATE())/6+1),	-- 学期 Семестр
	GroupName		varchar(16)		null,		-- 班级 Группа
	TrainStatusID	int		not null	-- 状态 Статус обучения
)


----------------------- 创建 Post 部门表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Post')
	DROP TABLE tb_Post
GO

CREATE TABLE tb_Post
(
	PostID		int				IDENTITY(1, 1) not null,
	PostName	nvarchar(256)	not null,
	Salary		money			not null
)


----------------------- 创建 Condition 工作状态表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Condition')
	DROP TABLE tb_Condition
GO

CREATE TABLE tb_Condition
(
	ConditionID		int		IDENTITY(1, 1) not null,
	ConditionType	nvarchar(64)	not null
)



----------------------- 创建 Staff 员工表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Staff')
	DROP TABLE tb_Staff
GO

CREATE TABLE tb_Staff
(
	StaffID			int				IDENTITY(1, 1) not null,
	StaffName		nvarchar(64)	not null,
	Gender			bit				not null,
	Birthday		datetime		null,
	Phone			char(10)		not null,
	Account			varchar(64)		null,		-- edu email
	Email			varchar(64)		null,
	Hiredate		datetime		not null,	-- 入职时间 Время введения в должность 
	Post			nvarchar(256)	null,		-- 职务
	InstituteShortName nvarchar(16)	null,		-- 院系 Учебное подразделение
	Condition		nvarchar(64)	not null	-- 工作状态
)

