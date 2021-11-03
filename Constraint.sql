--
USE db_SPbSTU
ALTER TABLE tb_Account
	ADD CONSTRAINT PK_Account_IDAccount PRIMARY KEY(IDAccount),
		CONSTRAINT UQ_Account_Login UNIQUE([Login]),
		CONSTRAINT CK_Account_Passwd CHECK(LEN(Passwd) BETWEEN 6 AND 18)

		
--
USE db_SPbSTU
ALTER TABLE tb_Institute
	ADD CONSTRAINT PK_Institute_IDInstitute PRIMARY KEY(IDInstitute),
		CONSTRAINT UQ_Institute_NameInstitute UNIQUE(NameInstitute),
		CONSTRAINT UQ_Institute_ShortNameInst UNIQUE(ShortNameInst)

--
USE db_SPbSTU
ALTER TABLE tb_Profession
	ADD CONSTRAINT PK_Profession_IDProfession PRIMARY KEY(IDProfession),
		CONSTRAINT FK_Profession_InstituteID FOREIGN KEY(InstituteID) REFERENCES tb_Institute(IDInstitute),
		CONSTRAINT UQ_Profession_CodeProfession UNIQUE(CodeProfession),
		CONSTRAINT DF_Profession_TuitionFee DEFAULT(20000) FOR TuitionFee


--
USE db_SPbSTU
ALTER TABLE tb_Group
	ADD CONSTRAINT PK_Groups_IDGroup PRIMARY KEY(IDGroup),
		CONSTRAINT UQ_Groups_NameGroup UNIQUE(NameGroup),
		CONSTRAINT FK_Groups_ProfessionCode FOREIGN KEY(ProfessionCode) REFERENCES tb_Profession(CodeProfession),
		CONSTRAINT DF_Groups_Grade DEFAULT(DATENAME(YYYY, GETDATE())) FOR Grade,
		CONSTRAINT DF_Groups_Quantity DEFAULT(40) FOR Quantity


--
USE db_SPbSTU
ALTER TABLE tb_Discipline
	ADD CONSTRAINT PK_Discipline_IDDiscipline PRIMARY KEY(IDDiscipline),
		CONSTRAINT UQ_Discipline_NameDiscipline UNIQUE(NameDiscipline),
		CONSTRAINT DF_Discipline_PeriodDiscipline DEFAULT(100) FOR PeriodDiscipline


--
USE db_SPbSTU 
ALTER TABLE tb_Student
	ADD CONSTRAINT PK_Student_IDStudent PRIMARY KEY(IDStudent),
		CONSTRAINT UQ_Student_Phone UNIQUE(Phone),
		CONSTRAINT FK_Student_AccountID FOREIGN KEY(AccountID) REFERENCES tb_Account(IDAccount),
		CONSTRAINT UQ_Student_AccountID UNIQUE(AccountID),
		CONSTRAINT DF_Student_EnrollTime DEFAULT(DATENAME(YYYY, GETDATE()) + '-09-01') FOR EnrollTime,
		CONSTRAINT FK_Student_GroupID FOREIGN KEY(GroupID) REFERENCES tb_Group(IDGroup)


--
USE db_SPbSTU
ALTER TABLE tb_Post
	ADD CONSTRAINT PK_Post_IDPost PRIMARY KEY(IDPost),
		CONSTRAINT UQ_Post_NamePost UNIQUE(NamePost)


--
USE db_SPbSTU
ALTER TABLE tb_Staff
	ADD CONSTRAINT PK_Staff_IDStaff PRIMARY KEY(IDStaff),
		CONSTRAINT UQ_Staff_Phone UNIQUE(Phone),
		CONSTRAINT FK_Staff_AccountID FOREIGN KEY(AccountID) REFERENCES tb_Account(IDAccount),
		CONSTRAINT UQ_Staff_AccountID UNIQUE(AccountID),
		CONSTRAINT DF_Staff_Hiredate DEFAULT(GETDATE()) FOR Hiredate,
		CONSTRAINT FK_Staff_PostID FOREIGN KEY(PostID) REFERENCES tb_Post(IDPost),
		CONSTRAINT FK_Staff_InstituteID FOREIGN KEY(InstituteID) REFERENCES tb_Institute(IDInstitute)


--
USE db_SPbSTU
ALTER TABLE tb_StudyPlan
	ADD CONSTRAINT PK_StudyPlan_IDStudyPlan PRIMARY KEY(IDStudyPlan),
		CONSTRAINT FK_StudyPlan_GroupID FOREIGN KEY(GroupID) REFERENCES tb_Group(IDGroup),
		CONSTRAINT FK_StudyPlan_DisciplineCode FOREIGN KEY(DisciplineID) REFERENCES tb_Discipline(IDDiscipline),
		CONSTRAINT FK_StudyPlan_StaffID FOREIGN KEY(StaffID) REFERENCES tb_Staff(IDStaff)


--
USE db_SPbSTU
ALTER TABLE tb_ExamRecord
	ADD CONSTRAINT PK_ExamRecord_IDExamRecord PRIMARY KEY(IDExamRecord),
		CONSTRAINT FK_ExamRecord_StudyPlanID FOREIGN KEY(StudyPlanID) REFERENCES tb_StudyPlan(IDStudyPlan),
		CONSTRAINT FK_ExamRecord_StudentID FOREIGN KEY(StudentID) REFERENCES tb_Student(IDStudent),
		CONSTRAINT CK_ExamRecord_Mark CHECK(Mark BETWEEN 2 AND 5),
		CONSTRAINT DF_ExamRecord_ExamDate DEFAULT(GETDATE()) FOR ExamDate