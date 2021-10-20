--
USE db_SPbSTU
ALTER TABLE tb_Account
	ADD CONSTRAINT UQ_Account_Account UNIQUE(Account),
		CONSTRAINT CK_Account_Password CHECK(LEN(Passwd)>=6)
--
USE db_SPbSTU
ALTER TABLE tb_Degree
	ADD CONSTRAINT PK_Degree_DegreeID PRIMARY KEY(DegreeID),
		CONSTRAINT UQ_Degree_DegreeType UNIQUE(DegreeType)
--
USE db_SPbSTU
ALTER TABLE tb_StudyType
	ADD CONSTRAINT PK_StudyType_StudyTypeID PRIMARY KEY(StudyTypeID),
		CONSTRAINT UQ_StudyType_StudyType UNIQUE(StudyType)
--
USE db_SPbSTU
ALTER TABLE tb_Institute
	ADD CONSTRAINT PK_Institute_InstituteID PRIMARY KEY(InstituteID),
		CONSTRAINT UQ_Institute_InstituteName UNIQUE(InstituteName),
		CONSTRAINT UQ_Institute_ShortName UNIQUE(ShortName)
		CONSTRAINT CK_Institute_Phone CHECK(Phone LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
--
USE db_SPbSTU
ALTER TABLE tb_Profession
	ADD CONSTRAINT PK_Profession_ProfessionID PRIMARY KEY(ProfessionID),
		CONSTRAINT KF_Profession_InstituteShortName FOREIGN KEY(InstituteShortName) REFERENCES tb_Institute(ShortName),
		CONSTRAINT UQ_Profession_ProfessionName UNIQUE(ProfessionName),
		CONSTRAINT UQ_Profession_ProfessionCode UNIQUE(ProfessionCode),
		CONSTRAINT DF_Profession_TuitionFee DEFAULT(20000) FOR TuitionFee
--
USE db_SPbSTU
ALTER TABLE tb_TrainStatus
	ADD CONSTRAINT PK_TrainStatus_TrainStatusID PRIMARY KEY(TrainStatusID),
		CONSTRAINT UQ_TrainStatus_TrainStatusType UNIQUE(TrainStatusType)
--

USE db_SPbSTU 
ALTER TABLE tb_Student
	ADD CONSTRAINT PK_Student_StudentID PRIMARY KEY(StudentID),
		CONSTRAINT CK_Institute_Phone CHECK(Phone LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
		CONSTRAINT FK_Student_Account FOREIGN KEY(Account) REFERENCES tb_Account(Account),
		CONSTRAINT UQ_Student_Account UNIQUE(Account),
		CONSTRAINT FK_Student_InstituteShortName FOREIGN KEY(InstituteShortName) REFERENCES tb_Institute(ShortName),
		CONSTRAINT FK_Student_ProfessionCode FOREIGN KEY(ProfessionCode) REFERENCES tb_Profession(ProfessionCode),
		CONSTRAINT FK_Student_DegreeID FOREIGN KEY(DegreeID) REFERENCES tb_Degree(DegreeID),
		CONSTRAINT FK_Student_StudyTypeID FOREIGN KEY(StudyTypeID) REFERENCES tb_StudyType(StudyTypeID),
		CONSTRAINT DF_Student_EnrollTime DEFAULT(DATENAME(YYYY, GETDATE()) + '-09-01') FOR EnrollTime,
		CONSTRAINT FK_Student_TrainStatusID FOREIGN KEY(TrainStatusID) REFERENCES tb_TrainStatus(TrainStatusID)
--
USE db_SPbSTU
ALTER TABLE tb_Post
	ADD CONSTRAINT PK_Post_PostID PRIMARY KEY(PostID),
		CONSTRAINT UQ_Post_PostName UNIQUE(PostName),
		CONSTRAINT DF_Post_Salary DEFAULT(40000) FOR Salary
--
USE db_SPbSTU
ALTER TABLE tb_Condition
	ADD CONSTRAINT PK_Condition_ConditionID PRIMARY KEY(ConditionID),
		CONSTRAINT UQ_Condition_ConditionType UNIQUE(ConditionType)
--
USE db_SPbSTU
ALTER TABLE tb_Staff
	ADD CONSTRAINT PK_Staff_StaffID PRIMARY KEY(StaffID),
		CONSTRAINT CK_Institute_Phone CHECK(Phone LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
		CONSTRAINT FK_Staff_Account FOREIGN KEY(Account) REFERENCES tb_Account(Account),
		CONSTRAINT DF_Staff_Hiredate DEFAULT(GETDATE()) FOR Hiredate,
		CONSTRAINT FK_Staff_Post FOREIGN KEY(Post) REFERENCES tb_Post(PostName),
		CONSTRAINT FK_Staff_InstituteShortName FOREIGN KEY(InstituteShortName) REFERENCES tb_Institute(ShortName),
		CONSTRAINT FK_Staff_Condition FOREIGN KEY(Condition) REFERENCES tb_Condition(ConditionType)
