using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class ProfessionServer
    {

        #region 获取所有方向信息（原表）+List<MODEL.tb_Profession> getAllProfessionList()
        /// <summary>
        ///  获取所有方向信息（原表）
        /// </summary>
        /// <returns></returns>
        public List<MODEL.tb_Profession> GetAllProfessionList()
        {
            string sql = "SELECT IDProfession, InstituteID, CodeProfession, NameProfession, TuitionFee FROM tb_Profession";
            DataTable dataTable = SqlHelper.ExectureTabel(sql);

            // 将表的每一行数据转换为对象然后添加到集合中。因为表的每一行，每一列是一个 Object ，如果后期在控件中修改的话要在对象中做
            List<MODEL.tb_Profession> professionList = null;
            if (dataTable.Rows.Count > 0)
            {
                // 一定要实例化对象的数据！
                professionList = new List<MODEL.tb_Profession>();

                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行就对应着一条数据
                    MODEL.tb_Profession tmpProfession = new MODEL.tb_Profession();
                    ProfessionRow2ProfessionObject(row, tmpProfession);
                    // 将当前生成的对象添加到集合中
                    professionList.Add(tmpProfession);
                }
            }
            return professionList;
        }
        #endregion


        #region 将 方向 数据行转换为 方向 对象 + void ProfessionRow2ProfessionObject(DataRow row, MODEL.tb_Profession profession)
        /// <summary>
        /// 将 方向 数据行转换为 方向 对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="profession"></param>
        void ProfessionRow2ProfessionObject(DataRow row, MODEL.tb_Profession profession)
        {

            profession.IDProfession = (int)row["IDProfession"];
            profession.InstituteID = (int)row["InstituteID"];
            profession.CodeProfession = row["CodeProfession"].ToString().Trim();
            profession.NameProfession = row["NameProfession"].ToString().Trim();
            profession.TuitionFee = (decimal)row["TuitionFee"];
        }
        #endregion


        #region 插入新方向+int InsertProfession(MODEL.tb_Profession newProfession)
        /// <summary>
        /// 插入新方向
        /// </summary>
        /// <param name="newProfession"></param>
        /// <returns></returns>
        public int InsertProfession(MODEL.tb_Profession newProfession)
        {
            string sql = "INSERT tb_Profession VALUES(@InstituteID, @CodeProfession, @NameProfession, @TuitionFee)";

            SqlParameter[] ps =
{
                new SqlParameter("InstituteID", newProfession.InstituteID),
                new SqlParameter("CodeProfession", newProfession.CodeProfession),
                new SqlParameter("NameProfession", newProfession.NameProfession),
                new SqlParameter("TuitionFee", newProfession.TuitionFee)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion
    }
}
