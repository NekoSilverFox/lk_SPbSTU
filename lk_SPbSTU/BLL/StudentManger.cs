using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentManger
    {
        /// <summary>
        /// 创建一个全局的数据层访问对象，因为以后的很多操作都需要调用数据访问层中的方法
        /// </summary>
        DAL.StudentServer studentServer = new DAL.StudentServer();

        #region 获取单一员工的信息 + MODEL.tb_Student getStudentInfo(int accountID)
        /// <summary>
        /// 实现登录
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public MODEL.tb_Student getStudentInfo(int accountID)
        {
            return studentServer.getStudentInfo(accountID);
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
            return studentServer.GetStudentListByGroupID(idGroup);
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
            return studentServer.InsertStudent(newStudent);
        }
        #endregion

        #region 修改账号信息+ int UpdateStudent(MODEL.tb_Student updateStudent)
        /// <summary>
        /// 修改账号信息
        /// </summary>
        /// <param name="updateStudent"></param>
        public int UpdateStudent(MODEL.tb_Student updateStudent)
        {
            // return studentServer.UpdateStudent(updateStudent);
            return 0;

        }
        #endregion
    }
}
