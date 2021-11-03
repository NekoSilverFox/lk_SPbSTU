# **КУРСОВОЙ ПРОЕКТ** 

## Хранимые данные

| № 6  | Хранимые данные | Пользователи, которым разрешен доступ              | Ограничения по типу и значению                               |
| ---- | --------------- | -------------------------------------------------- | ------------------------------------------------------------ |
| 1    | tb_Account      | Администратор<br />*Преподаватель* <br />*Студент* | Преподаватель и студент могут изменять и просматривать **только** свои данные<br />IDAccount - IDENTITY(1, 1), PRIMARY KEY<br />Login - UNIQUE<br />Passwd - CHECK(LEN(Passwd) BETWEEN 6 AND 18) |
| 2    | tb_Institute    | Администратор<br />*Преподаватель* <br />*Студент* | Преподаватель и студент могут просматривать **только** свои данные<br />IDInstitute - IDENTITY(1, 1), PRIMARY KEY<br />NameInstitute - UNIQUE<br />ShortNameInst - UNIQUE<br />Phone - CHECK(Phone LIKE '`[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]`') |
| 3    | tb_Profession   | Администратор<br />*Студент*                       | Студент могут просматривать **только** свои данные<br />IDProfession - IDENTITY(1, 1), PRIMARY KEY<br />CodeProfession - UNIQUE<br />TuitionFee - DEFAULT(20000) |
| 4    | tb_Group        | Администратор<br />*Преподаватель* <br />*Студент* | Преподаватель и студент могут просматривать **только** свои данные<br />IDGroup - IDENTITY(1, 1), PRIMARY KEY<br />NameGroup - UNIQUE<br />Quantity - DEFAULT(40) |
| 5    | tb_Discipline   | Администратор<br />                                | IDDiscipline - IDENTITY(1, 1), PRIMARY KEY<br />NameDiscipline - UNIQUE<br />PeriodDiscipline - DEFAULT(100) |
| 6    | tb_StudyPlan    | Администратор<br />*Преподаватель* <br />*Студент* | Преподаватель и студент могут просматривать **только** свои данные<br />IDStudyPlan - IDENTITY(1, 1), PRIMARY KEY |
| 7    | tb_ExamRecord   | Администратор<br />*Преподаватель* <br />*Студент* | Преподаватель могут изменять и просматривать **только** студенты своих групп<br />Студент могут просматривать **только** свои данные<br />Mark - CHECK(Mark BETWEEN 2 AND 5)<br />ExamDate - DEFAULT(GETDATE()) |
| 8    | tb_Student      | Администратор<br />*Преподаватель* <br />*Студент* | Преподаватель могут просматривать **только** студенты своих групп<br />Студент могут просматривать **только** свои данные<br />IDStudent - IDENTITY(1935000, 1), PRIMARY KEY<br />Phone - CHECK(Phone LIKE '`[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]`'), UNIQUE<br />AccountID - UNIQUE<br />EnrollTime - DEFAULT(DATENAME(YYYY, GETDATE()) + '-09-01')<br />Grade, Semester - автоматический расчет |
| 9    | tb_Post         | Администратор<br />                                | IDPost - IDENTITY(1, 1), PRIMARY KEY<br />NamePost - UNIQUE<br />Salary - DEFAULT(40000) |
| 10   | tb_Staff        | Администратор<br />Преподаватель<br />Студент      | Преподаватель могут просматривать **только** свои данные<br />Студент могут просматривать **только** данные своих преподаватели <br />IDStaff- IDENTITY(1, 1), PRIMARY KEY<br />Phone - CHECK(Phone LIKE '`[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]`'), UNIQUE<br />AccountID - UNIQUE<br />Hiredate - DEFAULT(GETDATE()) |

## Описание связей таблиц

| Relationship                | Primary key                  | Foreign key                 |
| --------------------------- | ---------------------------- | --------------------------- |
| FK_ExamRecord_StudentID     | tb_Student.IDStudent         | tb_ExamRecord.StudentID     |
| FK_Profession_InstShortName | tb_Institute.ShortNameInst   | tb_Profession.InstShortName |
| FK_Groups_ProfessionCode    | tb_Profession.CodeProfession | tb_Group.ProfessionCode     |
| FK_Student_AccountID        | tb_Account.IDAccount         | tb_Student.AccountID        |
| FK_Student_GroupID          | tb_Group.IDGroup             | tb_Student.GroupID          |
| FK_Staff_AccountID          | tb_Account.IDAccount         | tb_Staff.AccountID          |
| FK_Staff_PostID             | tb_Post.IDPost               | tb_Staff.PostID             |
| FK_Staff_InstShortName      | tb_Institute.ShortNameInst   | tb_Staff.InstShortName      |
| FK_StudyPlan_GroupID        | tb_Group.IDGroup             | tb_StudyPlan.GroupID        |
| FK_StudyPlan_StaffID        | tb_Staff.IDStaff             | tb_StudyPlan.StaffID        |
| FK_StudyPlan_DisciplineCode | tb_Discipline.IDDiscipline   | tb_StudyPlan.DisciplineID   |
| FK_ExamRecord_StudyPlanID   | tb_StudyPlan.IDStudyPlan     | tb_ExamRecord.              |
| FK_ExamRecord_StudentID     | tb_Student.IDStudent         | tb_ExamRecord.              |

## Описание таблиц

1. tb_Account – хранит информацию о логинах и паролях пользователей системы.

   
