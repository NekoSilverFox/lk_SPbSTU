using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentServer
    {
        #region 获取单一学生的信息 + MODEL.tb_Student getStudentInfo(int accountID)
        /// <summary>
        /// 实现登录
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public MODEL.tb_Student getStudentInfo(int accountID)
        {
            string sql = "EXEC usp_getStudentInfo @accountID";
            SqlParameter parameter = new SqlParameter("@accountID", accountID);

            MODEL.tb_Student student = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))  // SqlHelper.ExecuteReader(sql, parameter) 中合并 sql 语句中的各个参数
            {
                //声明实体对象
                if (reader.Read())  // 就算有数据，也就一行。所以没有必要循环！
                {
                    student = new MODEL.tb_Student();

                    student.IDStudent = (int)reader["IDStudent"];
                    student.Login = reader["Login"].ToString();
                    student.NameStudent = reader["NameStudent"].ToString();
                    student.Gender = (bool)reader["Gender"];
                    student.Birthday = Convert.ToDateTime(reader["Birthday"]);
                    student.Phone = reader["Phone"].ToString();
                    student.Email = reader["Email"].ToString();
                    student.Namegroup = reader["Namegroup"].ToString();
                    student.Grade = (int)reader["Grade"];
                    student.EnrollTime = Convert.ToDateTime(reader["EnrollTime"]);
                    student.NameInstitute = reader["NameInstitute"].ToString();
                    student.CodeProfession     = reader["CodeProfession"].ToString();
                    student.NameProfession = reader["NameProfession"].ToString();
                }
            }
            return student;
        }
        #endregion

    }
}
