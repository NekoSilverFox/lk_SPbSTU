using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AccountService
    {
        #region 实现获取用户名及密码，以用于判断用户是否存在 +MODEL.tb_Account Login(string login)
        /// <summary>
        /// 实现获取用户名及密码，以用于判断用户是否存在
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public MODEL.tb_Account Login(string login)
        {
            string sql = "SELECT IDAccount, Login, Passwd FROM tb_Account WHERE Login=@login";

            SqlParameter parameter = new SqlParameter("@login", login);

            MODEL.tb_Account tb_Account = null;

            // SqlHelper.ExecuteReader(sql, parameter) 中合并 sql 语句中的各个参数
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))
            {
                // 声明实体对象
                if (reader.Read())  // 就算有数据，也就一行。所以没有必要循环！
                {
                    tb_Account = new MODEL.tb_Account();

                    tb_Account.IDAccount = (int)reader["IDAccount"];
                    tb_Account.Login = reader["Login"].ToString();
                    tb_Account.Passwd = reader["Passwd"].ToString();
                }
            }
            return tb_Account;
        }
        #endregion
    }
}
