using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ExamRecordService
    {

        #region 根据学生ID获取成绩册 +List<MODEL.tb_ExamRecord> GetExamRecordsByStudentID(int studentID)
        /// <summary>
        /// 根据学生ID获取成绩册
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public List<MODEL.tb_ExamRecord> GetExamRecordsByStudentID(int studentID)
        {
            string sql = "SELECT Semestr, NameDiscipline, Mark, ExamDate FROM tb_ExamRecord INNER JOIN ( SELECT StudyPlanID, MAX(Mark) AS TmpBestMark FROM tb_ExamRecord WHERE StudentID=@idStu GROUP BY StudyPlanID ) ChooseBestMark ON tb_ExamRecord.StudyPlanID=ChooseBestMark.StudyPlanID AND tb_ExamRecord.Mark=ChooseBestMark.TmpBestMark INNER JOIN tb_StudyPlan ON tb_StudyPlan.IDStudyPlan=tb_ExamRecord.StudyPlanID INNER JOIN tb_Discipline ON tb_StudyPlan.DisciplineID=tb_Discipline.IDDiscipline WHERE StudentID=@idStu ORDER BY Semestr";
            SqlParameter parameter = new SqlParameter("idStu", studentID);

            DataTable dataTable = SqlHelper.ExectureTabel(sql, parameter);
            List<MODEL.tb_ExamRecord> examRecordsList = null;

            // 判断有没有行
            if (dataTable.Rows.Count > 0)
            {
                examRecordsList = new List<MODEL.tb_ExamRecord>();

                // 遍历表，将表的每一行转换为对应的实体对象
                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行数据对应一个 Person 对象
                    MODEL.tb_ExamRecord tmpExamRecord = new MODEL.tb_ExamRecord();

                    // 调用方法，将当前的数据行转换为 Person 对象
                    ExamRecordStudentShowRow2ExamRecord(row, tmpExamRecord);

                    // 将对象添加到集合当中
                    examRecordsList.Add(tmpExamRecord);
                }
            }
            return examRecordsList;
        }
        #endregion


        #region 将特定学员的成绩表的数据行转为实体对象 + void ExamRecordStudentShowRow2ExamRecord(DataRow row, MODEL.tb_ExamRecord examRecord)
        /// <summary>
        /// 将特定学员的成绩表的数据行转为实体对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="examRecord"></param>
        void ExamRecordStudentShowRow2ExamRecord(DataRow row, MODEL.tb_ExamRecord examRecord)
        {
            examRecord.Semester = (int)row["Semestr"];
            examRecord.NameDiscipline = row["NameDiscipline"].ToString().Trim();
            examRecord.Mark = (int)row["Mark"];
            examRecord.ExamDate = Convert.ToDateTime(row["ExamDate"]);
        }
        #endregion


        #region 根据老师的ID获取他所有学生的成绩册 +List<MODEL.tb_ExamRecord> GetExamRecordsByStaffID(int staffID)
        /// <summary>
        /// 根据老师的ID获取他所有学生的成绩册
        /// </summary>
        /// <param name="staffID"></param>
        /// <returns></returns>
        public List<MODEL.tb_ExamRecord> GetExamRecordsByStaffID(int staffID)
        {
            string sql = "SELECT DISTINCT IDStudyPlan, IDInstitute, ShortNameInst, IDProfession, NameProfession, IDGroup, NameGroup, IDDiscipline, NameDiscipline, IDExamRecord, IDStudent, NameStudent, Semestr, Mark FROM tb_ExamRecord  JOIN tb_Student ON tb_Student.IDStudent=tb_ExamRecord.StudentID JOIN tb_Group ON tb_Group.IDGroup=tb_Student.GroupID JOIN tb_StudyPlan ON tb_StudyPlan.GroupID=tb_Group.IDGroup JOIN tb_Discipline ON tb_Discipline.IDDiscipline=tb_StudyPlan.DisciplineID JOIN tb_Profession ON tb_Profession.IDProfession=tb_Group.ProfessionID JOIN tb_Institute ON tb_Institute.IDInstitute=tb_Profession.InstituteID WHERE tb_StudyPlan.StaffID=@ValstaffID ORDER BY Semestr, IDGroup, NameStudent";
            SqlParameter parameter = new SqlParameter("@ValstaffID", staffID);

            DataTable dataTable = SqlHelper.ExectureTabel(sql, parameter);
            List<MODEL.tb_ExamRecord> examRecordsList = null;

            // 判断有没有行
            if (dataTable.Rows.Count > 0)
            {
                examRecordsList = new List<MODEL.tb_ExamRecord>();

                // 遍历表，将表的每一行转换为对应的实体对象
                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行数据对应一个 Person 对象
                    MODEL.tb_ExamRecord tmpExamRecord = new MODEL.tb_ExamRecord();

                    // 调用方法，将当前的数据行转换为 Person 对象
                    ExamRecordRow2ObjByStaffID(row, tmpExamRecord);

                    // 将对象添加到集合当中
                    examRecordsList.Add(tmpExamRecord);
                }
            }
            return examRecordsList;
        }
        #endregion


        #region 将特定学员的成绩表的数据行转为实体对象（根据老师的ID）+ void ExamRecordRow2ObjByStaffID(DataRow row, MODEL.tb_ExamRecord examRecord)
        /// <summary>
        /// 将特定学员的成绩表的数据行转为实体对象（根据老师的ID）
        /// </summary>
        /// <param name="row"></param>
        /// <param name="examRecord"></param>
        void ExamRecordRow2ObjByStaffID(DataRow row, MODEL.tb_ExamRecord examRecord)
        {
            examRecord.StudyPlanID = (int)row["IDStudyPlan"];
            examRecord.IDExamRecord = (int)row["IDExamRecord"];
            examRecord.IdInstitute = (int)row["IDInstitute"];
            examRecord.ShortNameInst = row["ShortNameInst"].ToString().Trim();
            examRecord.IdProfession = (int)row["IDProfession"];
            examRecord.NameProfession = row["NameProfession"].ToString().Trim();
            examRecord.IdGroup = (int)row["IDGroup"];
            examRecord.NameGroup = row["NameGroup"].ToString().Trim();
            examRecord.IdDiscipline = (int)row["IDDiscipline"];
            examRecord.NameDiscipline = row["NameDiscipline"].ToString().Trim();
            examRecord.StudentID = (int)row["IDStudent"];
            examRecord.NameStudent = row["NameStudent"].ToString().Trim();
            examRecord.Semester = (int)row["Semestr"];
            examRecord.Mark = (int)row["Mark"];
        }
        #endregion



        #region 插入新成绩记录 +int InsertExamRecord(MODEL.tb_ExamRecord newExamRecord)
        /// <summary>
        /// 插入新成绩记录
        /// </summary>
        /// <param name="newExamRecord "></param>
        /// <returns></returns>
        public int InsertExamRecord(MODEL.tb_ExamRecord newExamRecord)
        {
            string sql = "INSERT tb_ExamRecord VALUES(@StudyPlanID, @StudentID, @Mark, default)";

            SqlParameter[] ps =
            {
                new SqlParameter("StudyPlanID", newExamRecord.StudyPlanID),
                new SqlParameter("StudentID", newExamRecord.StudentID),
                new SqlParameter("Mark", newExamRecord.Mark)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion

        #region 修改成绩记录 +int UpdateExamRecord(MODEL.tb_ExamRecord updateExamRecord)
        /// <summary>
        /// 修改成绩记录
        /// </summary>
        /// <param name="updateExamRecord"></param>
        public int UpdateExamRecord(MODEL.tb_ExamRecord updateExamRecord)
        {
            string sql = "UPDATE tb_ExamRecord SET StudyPlanID=@StudyPlanID, StudentID=@StudentID, Mark=@Mark WHERE IDExamRecord=@IDExamRecord";

            SqlParameter[] ps =
            {
                new SqlParameter("StudyPlanID", updateExamRecord.StudyPlanID),
                new SqlParameter("StudentID", updateExamRecord.StudentID),
                new SqlParameter("Mark", updateExamRecord.Mark),
                new SqlParameter("IDExamRecord", updateExamRecord.IDExamRecord)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion

        #region 删除成绩记录 +int DeleteExamRecord(int id)
        /// <summary>
        /// 删除成绩记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteExamRecord(int id)
        {
            string sql = "DELETE FROM tb_ExamRecord WHERE IDExamRecord=@id";
            SqlParameter p = new SqlParameter("@id", id);
            return SqlHelper.ExecuteNonQuery(sql, p);
        }
        #endregion

    }
}
