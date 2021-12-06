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
            examRecord.NameDiscipline = row["NameDiscipline"].ToString();
            examRecord.Mark = (int)row["Mark"];
            examRecord.ExamDate = Convert.ToDateTime(row["ExamDate"]);
        }
        #endregion
    }
}
