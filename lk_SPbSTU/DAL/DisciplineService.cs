using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DisciplineService
    {

        #region 获取所有科目信息 + List<MODEL.tb_Discipline> GetAllDisciplineList()
        /// <summary>
        /// 获取所有班级信息
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<MODEL.tb_Discipline> GetAllDisciplineList()
        {
            string sql = "SELECT IDDiscipline, NameDiscipline, PeriodDiscipline, DescriptionDiscipline FROM tb_Discipline";
            DataTable dataTable = SqlHelper.ExectureTabel(sql);

            // 将表的每一行数据转换为对象然后添加到集合中。因为表的每一行，每一列是一个 Object ，如果后期在控件中修改的话要在对象中做
            List<MODEL.tb_Discipline> disciplineList = null;
            if (dataTable.Rows.Count > 0)
            {
                // 一定要实例化对象的数据！
                disciplineList = new List<MODEL.tb_Discipline>();

                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行就对应着一条数据
                    MODEL.tb_Discipline tmpDiscipline = new MODEL.tb_Discipline();
                    DisciplineRow2Object(row, tmpDiscipline);
                    // 将当前生成的对象添加到集合中
                    disciplineList.Add(tmpDiscipline);
                }
            }

            return disciplineList;
        }
        #endregion

        #region 将 Discipline 数据行转换为 Discipline 对象 +void DisciplineRow2Object(DataRow row, MODEL.tb_Discipline discipline)
        /// <summary>
        /// 将 Discipline 数据行转换为 Discipline 对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="discipline"></param>
        public void DisciplineRow2Object(DataRow row, MODEL.tb_Discipline discipline)
        {
            discipline.IDDiscipline = (int)row["IDDiscipline"];
            discipline.NameDiscipline = row["NameDiscipline"].ToString().Trim();
            discipline.PeriodDiscipline = (int)row["PeriodDiscipline"];
            discipline.DescriptionDiscipline = row["DescriptionDiscipline"].ToString().Trim();
        }
        #endregion


        #region 插入新科目 +int InsertDiscipline(MODEL.tb_Discipline newDiscipline)
        /// <summary>
        /// 插入新科目
        /// </summary>
        /// <param name="newDiscipline"></param>
        /// <returns></returns>
        public int InsertDiscipline(MODEL.tb_Discipline newDiscipline)
        {
            string sql = "INSERT tb_Discipline VALUES(@NameDiscipline, @PeriodDiscipline, @DescriptionDiscipline)";

            SqlParameter[] ps =
            {
                new SqlParameter("@NameDiscipline", newDiscipline.NameDiscipline),
                new SqlParameter("@PeriodDiscipline", newDiscipline.PeriodDiscipline),
                new SqlParameter("@DescriptionDiscipline", newDiscipline.DescriptionDiscipline)
            };

            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion


    }

}
