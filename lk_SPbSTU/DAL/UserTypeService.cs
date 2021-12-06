using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserTypeService
    {

        #region 获取用户类型的字符串 +MODEL.UserType GetUserType(int accountid)
        /// <summary>
        /// 获取用户类型的字符串
        /// </summary>
        /// <param name="accountid"></param>
        /// <returns></returns>
        public MODEL.UserType GetUserType(int accountid)
        {
            string sql = "EXEC usp_AccountType @accountid";

            SqlParameter parameter = new SqlParameter("@accountid", accountid);

            MODEL.UserType userType = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))
            {
                if (reader.Read())
                {
                    userType = new MODEL.UserType();
                    userType.AccountUserType = reader["UserType"].ToString().Trim();
                }
            }

            return userType;
        }
        #endregion
    }
}
