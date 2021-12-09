using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StaffManger
    {
        /// <summary>
        /// 创建一个全局的数据层访问对象，因为以后的很多操作都需要调用数据访问层中的方法
        /// </summary>
        DAL.StaffService staffService = new DAL.StaffService();

        #region 获取单一员工的信息 +public MODEL.tb_Staff getStaffInfo(int accountID)
        /// <summary>
        /// 实现登录
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public MODEL.tb_Staff getStaffInfo(int accountID)
        {
            return staffService.getStaffInfo(accountID);
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
            return staffService.GetAllStaffList();
        }
        #endregion

        #region 插入新员工 +int InsertStaff(MODEL.tb_Staff newStaff)
        /// <summary>
        /// 插入新员工
        /// </summary>
        /// <param name="newStaff"></param>
        /// <returns></returns>
        public int InsertStaff(MODEL.tb_Staff newStaff)
        {
            return staffService.InsertStaff(newStaff);
        }
        #endregion

        #region 修改员工信息+ int UpdateStaff(MODEL.tb_Staff updateStaff)
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="updateStaff"></param>
        public int UpdateStaff(MODEL.tb_Staff updateStaff)
        {
           return staffService.UpdateStaff(updateStaff);
        }
        #endregion
    }
}
