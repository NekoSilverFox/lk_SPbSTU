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

----------------------- 创建 Account 账号表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Account')
	DROP TABLE tb_Account
GO

CREATE TABLE tb_Account
(
	Account		char(64)		not null,
	Passwd		char(16)		not null
)


----------------------- 创建 Student 表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Student')
	DROP TABLE tb_Student
GO

CREATE TABLE tb_Student
(
	StudentID		int				IDENTITY(1935000, 1) not null,
	StudentName		nchar(64)		not null,
	Gender			bit				not null,
	Birthday		datetime		null,
	Phone			char(10)		not null,
	Account			char(64)		null,		-- edu email
	Email			char(64)		null,
	InstituteShortName	char(16)	null,		-- 院系 Учебное подразделение
	ProfessionCode	char(16)		null,		-- 方向 Направление подготовки
	Degree			nchar(64)		not null,	-- 学位 Уровень подготовки
	StudyType		nchar(64)		not null,	-- 培训方式 Форма обучения+
	EnrollTime		datetime		not null,	-- 入学年份 Год поступления
	Grade			smallint		not null,	-- 年级 Курс
	Semester		smallint		not null,	-- 学期 Семестр
	Class			char(16)		null,		-- 班级 Группа
	TrainStatus		nchar(32)		not null	-- 状态 Статус обучения
)


----------------------- 创建 Degree 学位表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Degree')
	DROP TABLE tb_Degree
GO

CREATE TABLE tb_Degree
(
	DegreeID		smallint		IDENTITY(1, 1) not null,
	DegreeType		nchar(64)		not null
)


----------------------- 创建 StudyType 培训方式表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_StudyType')
	DROP TABLE tb_StudyType
GO

CREATE TABLE tb_StudyType
(
	StudyTypeID		smallint		IDENTITY(1, 1) not null,
	StudyType		nchar(64)		not null
)

----------------------- 创建 Institute 院系表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Institute')
	DROP TABLE tb_Institute
GO

CREATE TABLE tb_Institute
(
	InstituteID		smallint		IDENTITY(1, 1) not null,
	InstituteName	nvarchar(256)	not null,
	ShortName		char(16)		null,
	Email			char(64)		null,
	Website			char(128)		null,
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
	ProfessionID	smallint		IDENTITY(1, 1) not null,
	ProfessionName	nvarchar(256)	not null,
	ProfessionCode	char(16)		not null,
	TuitionFee		money			not null
)


----------------------- 创建 Staff 员工表 -----------------------
USE db_SPbSTU
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='tb_Staff')
	DROP TABLE tb_Staff
GO

CREATE TABLE tb_Staff
(
	StaffID			int				IDENTITY(1, 1) not null,
	StaffName		nchar(64)		not null,
	Gender			bit				not null,
	Birthday		datetime		null,
	Phone			char(10)		not null,
	Account			char(64)		null,		-- edu email
	Email			char(64)		null,
	Hiredate		datetime		not null,	-- 入职时间 Год поступления
	Post			nvarchar(256)	null,		-- 职务
	Institute		nvarchar(256)	null,		-- 院系 Учебное подразделение
	Condition		nvarchar(64)	not null	-- 工作状态
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
	ConditionID		smallint		IDENTITY(1, 1) not null,
	ConditionType	nvarchar(64)	not null
)
