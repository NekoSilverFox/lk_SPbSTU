using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudyPlanServer
    {
        #region
        /// <summary>
        /// 通过 accountID 获取指定学生的培训计划
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public List<MODEL.tb_StudyPlan> GetStudentStudyPlanByAccountID(int accountID)
        {
            string sql = "EXEC usp_getStudentStudyPlan @accountID";
            SqlParameter parameter = new SqlParameter("@accountID", accountID);

            DataTable dataTable = SqlHelper.ExectureTabel(sql, parameter);
            List<MODEL.tb_StudyPlan> studentStudyPlansList = null;

            // 判断有没有行
            if (dataTable.Rows.Count > 0)
            {
                studentStudyPlansList = new List<MODEL.tb_StudyPlan>();

                // 遍历表，将表的每一行转换为对应的实体对象
                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行数据对应一个 Person 对象
                    MODEL.tb_StudyPlan tmpStudentStudyPlan = new MODEL.tb_StudyPlan();

                    // 调用方法，将当前的数据行转换为 Person 对象
                    StudentStudyPlanRow2StudentStudyPlanObject(row, tmpStudentStudyPlan);

                    // 将对象添加到集合当中
                    studentStudyPlansList.Add(tmpStudentStudyPlan);
                }
            }
            return studentStudyPlansList;
        }
        #endregion


        #region 将特定学员的学习计划表的数据行转为实体对象 + void StudentStudyPlanRow2StudentStudyPlanObject(DataRow row, MODEL.tb_StudyPlan studentStudyPlan)
        /// <summary>
        /// 将特定学员的学习计划表的数据行转为实体对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name=" studentStudyPlan"></param>
        void StudentStudyPlanRow2StudentStudyPlanObject(DataRow row, MODEL.tb_StudyPlan studentStudyPlan)
        {
            studentStudyPlan.IDStudyPlan = (int)row["IDStudyPlan"];
            studentStudyPlan.Semestr = (int)row["Semestr"];
            studentStudyPlan.NameDiscipline = row["NameDiscipline"].ToString().Trim();
            studentStudyPlan.PeriodDiscipline = (int)row["PeriodDiscipline"];
            studentStudyPlan.NameStaff = row["NameStaff"].ToString().Trim();
            studentStudyPlan.EmailTeacher = row["EmailTeacher"].ToString().Trim();
            studentStudyPlan.EduEmailTeacher = row["EduEmailTeacher"].ToString().Trim();
            studentStudyPlan.PhoneTeacher = row["PhoneTeacher"].ToString().Trim();
        }
        #endregion
    }
}
