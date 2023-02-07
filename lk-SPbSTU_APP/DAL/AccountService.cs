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
                    tb_Account.Login = reader["Login"].ToString().Trim();
                    tb_Account.Passwd = reader["Passwd"].ToString().Trim();
                }
            }
            return tb_Account;
        }
        #endregion


        /// <summary>
        /// 根据学生ID获取他的实体类账号对象
        /// </summary>
        /// <param name="studentID"></param>
        public MODEL.tb_Account GetAccountByStudentID(int studentID)
        {
            string sql = "SELECT IDAccount, Login, Passwd FROM tb_Account JOIN tb_Student ON tb_Student.AccountID=tb_Account.IDAccount WHERE IDStudent=@StudentID";
            SqlParameter parameter = new SqlParameter("@StudentID", studentID);

            MODEL.tb_Account account = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))  // SqlHelper.ExecuteReader(sql, parameter) 中合并 sql 语句中的各个参数
            {
                //声明实体对象
                if (reader.Read())  // 就算有数据，也就一行。所以没有必要循环！
                {
                    account = new MODEL.tb_Account();

                    account.IDAccount = (int)reader["IDAccount"];
                    account.Login = reader["Login"].ToString().Trim();
                    account.Passwd = reader["Passwd"].ToString().Trim();
                }
            }
            return account;
        }


        #region 根据员工ID获取他的实体类账号对象+MODEL.tb_Account GetAccountByStaffID(int studentID)
        /// <summary>
        /// 根据员工ID获取他的实体类账号对象
        /// </summary>
        /// <param name="studentID"></param>
        public MODEL.tb_Account GetAccountByStaffID(int staffID)
        {
            string sql = "SELECT IDAccount, Login, Passwd FROM tb_Account JOIN tb_Staff ON tb_Staff.AccountID=tb_Account.IDAccount WHERE IDStaff=@StaffID";
            SqlParameter parameter = new SqlParameter("@StaffID", staffID);

            MODEL.tb_Account account = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))  // SqlHelper.ExecuteReader(sql, parameter) 中合并 sql 语句中的各个参数
            {
                //声明实体对象
                if (reader.Read())  // 就算有数据，也就一行。所以没有必要循环！
                {
                    account = new MODEL.tb_Account();

                    account.IDAccount = (int)reader["IDAccount"];
                    account.Login = reader["Login"].ToString().Trim();
                    account.Passwd = reader["Passwd"].ToString().Trim();
                }
            }
            return account;
        }
        #endregion

        /// <summary>
        /// 根据学生姓名获取他的实体类账号对象
        /// </summary>
        /// <param name="studentName"></param>
        public MODEL.tb_Account GetAccountByStudentName(string studentName)
        {
            string sql = "SELECT IDAccount, Login, Passwd FROM tb_Account JOIN tb_Student ON tb_Student.AccountID=tb_Account.IDAccount WHERE NameStudent=@StudentName";
            SqlParameter parameter = new SqlParameter("@StudentName", studentName);

            MODEL.tb_Account account = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))  // SqlHelper.ExecuteReader(sql, parameter) 中合并 sql 语句中的各个参数
            {
                //声明实体对象
                if (reader.Read())  // 就算有数据，也就一行。所以没有必要循环！
                {
                    account = new MODEL.tb_Account();

                    account.IDAccount = (int)reader["IDAccount"];
                    account.Login = reader["Login"].ToString().Trim();
                    account.Passwd = reader["Passwd"].ToString().Trim();
                }
            }
            return account;
        }
    }
}
