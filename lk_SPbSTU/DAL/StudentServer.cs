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
                    student.AccountID = (int)reader["AccountID"];
                    student.Login = reader["Login"].ToString();
                    student.Passwd = reader["Passwd"].ToString();
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


        #region 根据班级ID获取所有学生 + List<MODEL.tb_Student> GetStudentListByGroupID(int idGroup)
        /// <summary>
        /// 根据班级ID获取所有学生
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<MODEL.tb_Student> GetStudentListByGroupID(int idGroup)
        {
            string sql = "SELECT IDStudent, NameStudent, Birthday, Phone, AccountID, Login, Passwd, Email, EnrollTime, GroupID, NameGroup, Grade FROM tb_Student JOIN tb_Account ON tb_Student.AccountID=tb_Account.IDAccount JOIN tb_Group ON tb_Student.GroupID=tb_Group.IDGroup WHERE IDGroup=@IDGroup";
            SqlParameter ps = new SqlParameter("@IDGroup", idGroup);
            DataTable dataTable = SqlHelper.ExectureTabel(sql, ps);

            // 将表的每一行数据转换为对象然后添加到集合中。因为表的每一行，每一列是一个 Object ，如果后期在控件中修改的话要在对象中做
            List<MODEL.tb_Student> studentList = null;
            if (dataTable.Rows.Count > 0)
            {
                // 一定要实例化对象的数据！
                studentList = new List<MODEL.tb_Student>();

                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行就对应着一条数据
                    MODEL.tb_Student tmpStudent = new MODEL.tb_Student();
                    StudentRow2Object(row, tmpStudent);
                    // 将当前生成的对象添加到集合中
                    studentList.Add(tmpStudent);
                }
            }

            return studentList;
        }
        #endregion


        #region 将 student 数据行转换为 student 对象 + void StudentRow2Object(DataRow row, MODEL.tb_Student student)
        /// <summary>
        /// 将 institute 数据行转换为 Institute 对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="student"></param>
        void StudentRow2Object(DataRow row, MODEL.tb_Student student)
        {
            student.IDStudent = (int)row["IDStudent"];
            student.NameStudent = row["NameStudent"].ToString().Trim();
            student.Birthday = Convert.ToDateTime(row["Birthday"]);
            student.Phone = row["Phone"].ToString().Trim();
            student.AccountID = (int)row["AccountID"];
            student.Login = row["Login"].ToString().Trim();
            student.Passwd = row["Passwd"].ToString().Trim();
            student.Email = row["Email"].ToString().Trim();
            student.EnrollTime = Convert.ToDateTime(row["EnrollTime"]);
            student.GroupID = (int)row["GroupID"];
            student.Namegroup = row["Namegroup"].ToString().Trim();
            student.Grade = (int)row["Grade"];
        }
        #endregion

        #region 插入新学生 +int InsertStudent(MODEL.tb_Student newStudent)
        /// <summary>
        /// 插入新学生
        /// </summary>
        /// <param name="newStudent "></param>
        /// <returns></returns>
        public int InsertStudent(MODEL.tb_Student newStudent)
        {
            string sql = "EXEC usp_addStudentByGroupID @Login=@ValLogin, @Passwd=@ValPasswd, @NameStudent=@ValNameStudent, @Gender=@ValGender, @Birthday=@ValBirthday, @Phone=@ValPhone, @Email=@ValEmail, @EnrollTime=@ValEnrollTime, @GroupID=@ValGroupID";

            SqlParameter[] ps =
            {
                new SqlParameter("@ValLogin", newStudent.Login),
                new SqlParameter("@ValPasswd", newStudent.Passwd),
                new SqlParameter("@ValNameStudent", newStudent.NameStudent),
                new SqlParameter("@ValGender", newStudent.Gender),
                new SqlParameter("@ValBirthday", newStudent.Birthday),
                new SqlParameter("@ValPhone", newStudent.Phone),
                new SqlParameter("@ValEmail", newStudent.Email),
                new SqlParameter("@ValEnrollTime", newStudent.EnrollTime),
                new SqlParameter("@ValGroupID", newStudent.GroupID)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion

        #region 修改账号信息+ int UpdateStudent(MODEL.tb_Student updateStudent)
        /// <summary>
        /// 修改账号信息
        /// </summary>
        /// <param name="updateStudent"></param>
        public int UpdateStudent(MODEL.tb_Student updateStudent)
        {
            string sql = "EXEC usp_updateStudentAndAccount @Login=@ValLogin, @Passwd=@ValPasswd, @IDStudent=@ValIDStudent, @NameStudent=@ValNameStudent, @Gender=@ValGender, @Birthday=@ValBirthday, @Phone=@ValPhone, @AccountID=@ValAccountID, @Email=@ValEmail, @EnrollTime=@ValEnrollTime, @GroupID=@ValGroupID";

            SqlParameter[] ps =
            {
                new SqlParameter("@ValLogin", updateStudent.Login),
                new SqlParameter("@ValPasswd", updateStudent.Passwd),
                new SqlParameter("@ValIDStudent", updateStudent.IDStudent),
                new SqlParameter("@ValNameStudent", updateStudent.NameStudent),
                new SqlParameter("@ValGender", updateStudent.Gender),
                new SqlParameter("@ValBirthday", updateStudent.Birthday),
                new SqlParameter("@ValPhone", updateStudent.Phone),
                new SqlParameter("@ValAccountID", updateStudent.AccountID),
                new SqlParameter("@ValEmail", updateStudent.Email),
                new SqlParameter("@ValEnrollTime", updateStudent.EnrollTime),
                new SqlParameter("@ValGroupID", updateStudent.GroupID)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion

    }
}
