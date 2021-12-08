using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        #region 获取所有员工信息 + List<MODEL.tb_Staff> GetAllStaffList()
        /// <summary>
        /// 获取所有班级信息
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<MODEL.tb_Staff> GetAllStaffList()
        {
            string sql = "EXEC usp_getAllStaff";
            DataTable dataTable = SqlHelper.ExectureTabel(sql);

            // 将表的每一行数据转换为对象然后添加到集合中。因为表的每一行，每一列是一个 Object ，如果后期在控件中修改的话要在对象中做
            List<MODEL.tb_Staff> staffList = null;
            if (dataTable.Rows.Count > 0)
            {
                // 一定要实例化对象的数据！
                staffList = new List<MODEL.tb_Staff>();

                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行就对应着一条数据
                    MODEL.tb_Staff tmpStaff = new MODEL.tb_Staff();
                    StaffRow2Object(row, tmpStaff);
                    // 将当前生成的对象添加到集合中
                    staffList.Add(tmpStaff);
                }
            }

            return staffList;
        }
        #endregion

        #region 将 staff 数据行转换为 staff 对象 +void StaffRow2Object(DataRow row, MODEL.tb_Staff staff)
        /// <summary>
        /// 将 institute 数据行转换为 Institute 对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="staff"></param>
        void StaffRow2Object(DataRow row, MODEL.tb_Staff staff)
        {
            staff.IDStaff = (int)row["IDStaff"];
            staff.NameStaff = row["NameStaff"].ToString().Trim();
            staff.Gender = (bool)row["Gender"];
            staff.Birthday = Convert.ToDateTime(row["Birthday"]);
            staff.Phone = row["Phone"].ToString().Trim();
            staff.AccountID = (int)row["AccountID"];
            staff.PostID = (int)row["PostID"];
            staff.InstituteID = (int)row["InstituteID"];

            staff.Login = row["Login"].ToString().Trim();
            staff.Email = row["Email"].ToString().Trim();
            staff.Hiredate = Convert.ToDateTime(row["Hiredate"]);
            staff.NamePost = row["NamePost"].ToString().Trim();
            staff.NameInstitute = row["NameInstitute"].ToString().Trim();
            staff.ShortNameInst = row["ShortNameInst"].ToString().Trim();
        }
        #endregion
    }
}
