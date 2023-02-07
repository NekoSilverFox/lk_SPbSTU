using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class InstituteService
    {

        #region 获取所有学院信息 + List<MODEL.tb_Institute> getAllInstituteList()
        /// <summary>
        /// 获取所有学院信息
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<MODEL.tb_Institute> GetAllInstituteList()
        {
            string sql = "SELECT IDInstitute, NameInstitute, ShortNameInst, Email, Website, Phone, DetAddress FROM tb_Institute";
            DataTable dataTable = SqlHelper.ExectureTabel(sql);

            // 将表的每一行数据转换为对象然后添加到集合中。因为表的每一行，每一列是一个 Object ，如果后期在控件中修改的话要在对象中做
            List<MODEL.tb_Institute> instituteList = null;
            if (dataTable.Rows.Count > 0)
            {
                // 一定要实例化对象的数据！
                instituteList = new List<MODEL.tb_Institute>();

                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行就对应着一条数据
                    MODEL.tb_Institute tmpInstitute = new MODEL.tb_Institute();
                    InstituteRow2InstutiteObject(row, tmpInstitute);
                    // 将当前生成的对象添加到集合中
                    instituteList.Add(tmpInstitute);
                }
            }

            return instituteList;
        }
        #endregion


        #region 将 institute 数据行转换为 Institute 对象 + void InstituteRow2InstutiteObject(DataRow row, MODEL.tb_Institute institute)
        /// <summary>
        /// 将 institute 数据行转换为 Institute 对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="institute"></param>
        void InstituteRow2InstutiteObject(DataRow row, MODEL.tb_Institute institute)
        {
            institute.IDInstitute = (int)row["IDInstitute"];
            institute.NameInstitute = row["NameInstitute"].ToString().Trim();
            institute.ShortNameInst = row["ShortNameInst"].ToString().Trim();
            institute.Email = row["Email"].ToString().Trim();
            institute.Website = row["Website"].ToString().Trim();
            institute.Phone = row["Phone"].ToString().Trim();
            institute.DetAddress = row["DetAddress"].ToString().Trim();
        }
        #endregion


        #region 添加新的学院到tb_institute表中 +int InsertInstitute(MODEL.tb_Institute newInstitute)
        /// <summary>
        /// 添加新的学院到tb_institute表中
        /// </summary>
        /// <param name="newInstitute"></param>
        /// <returns></returns>
        public int InsertInstitute(MODEL.tb_Institute newInstitute)
        {
            string sql = "INSERT tb_Institute VALUES(@NameInstitute, @ShortNameInst, @Email, @Website, @DetAddress, @Phone)";

            SqlParameter[] ps =
            {
                new SqlParameter("@NameInstitute", newInstitute.NameInstitute),
                new SqlParameter("@ShortNameInst", newInstitute.ShortNameInst),
                new SqlParameter("@Email", string.IsNullOrEmpty(newInstitute.Email) ? DBNull.Value : (object)newInstitute.Email),
                new SqlParameter("@Website", string.IsNullOrEmpty(newInstitute.Website) ? DBNull.Value : (object)newInstitute.Website),
                new SqlParameter("@DetAddress", string.IsNullOrEmpty(newInstitute.DetAddress) ? DBNull.Value : (object)newInstitute.DetAddress),
                new SqlParameter("@Phone", newInstitute.Phone)
            };

            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion

        #region 修改学院信息+ int UpdateInstitute(MODEL.tb_Institute updateInstitute)
        /// <summary>
        /// 修改学院信息
        /// </summary>
        /// <param name="updateInstitute"></param>
        public int UpdateInstitute(MODEL.tb_Institute updateInstitute)
        {
            string sql = "UPDATE tb_Institute SET NameInstitute=@NameInstitute, ShortNameInst=@ShortNameInst, Email=@Email, Website=@Website, DetAddress=@DetAddress, Phone=@Phone WHERE IDInstitute=@ID";

            SqlParameter[] ps =
            {
                new SqlParameter("@ID", updateInstitute.IDInstitute),
                new SqlParameter("@NameInstitute", updateInstitute.NameInstitute),
                new SqlParameter("@ShortNameInst", updateInstitute.ShortNameInst),
                new SqlParameter("@Email", string.IsNullOrEmpty(updateInstitute.Email) ? DBNull.Value : (object)updateInstitute.Email),
                new SqlParameter("@Website", string.IsNullOrEmpty(updateInstitute.Website) ? DBNull.Value : (object)updateInstitute.Website),
                new SqlParameter("@DetAddress", string.IsNullOrEmpty(updateInstitute.DetAddress) ? DBNull.Value : (object)updateInstitute.DetAddress),
                new SqlParameter("@Phone", updateInstitute.Phone)
            };

            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion

    }
}
