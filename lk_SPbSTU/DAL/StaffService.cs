using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DAL
{
    public class StaffService
    {
        #region 获取单一员工的信息 +public MODEL.tb_Staff getStaffInfo(int accountID)
        /// <summary>
        /// 实现登录
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public MODEL.tb_Staff getStaffInfo(int accountID)
        {
            string sql = "EXEC usp_getStaffInfo @accountID";

            SqlParameter parameter = new SqlParameter("@accountID", accountID);

            MODEL.tb_Staff staff = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))  // SqlHelper.ExecuteReader(sql, parameter) 中合并 sql 语句中的各个参数
            {
                //声明实体对象
                if (reader.Read())  // 就算有数据，也就一行。所以没有必要循环！
                {
                    staff = new MODEL.tb_Staff();

                    staff.IDStaff = (int)reader["IDStaff"];
                    staff.NameStaff = reader["NameStaff"].ToString().Trim();
                    staff.StrGender = reader["Gender"].ToString().Trim();
                    staff.Birthday = Convert.ToDateTime(reader["Birthday"]);
                    staff.Phone = reader["Phone"].ToString().Trim();
                    staff.Email = reader["Email"].ToString().Trim();
                    staff.Hiredate = Convert.ToDateTime(reader["Hiredate"]);
                    staff.StrPost = reader["NamePost"].ToString().Trim();
                    staff.StrInstitute = reader["NameInstitute"].ToString().Trim();
                }
            }
            return staff;
        }
        #endregion
    }
}
