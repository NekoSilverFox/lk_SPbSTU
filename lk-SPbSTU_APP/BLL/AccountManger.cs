﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // 改为 public
    public class AccountManger
    {
        /// <summary>
        /// 创建一个全局的数据层访问对象，因为以后的很多操作都需要调用数据访问层中的方法
        /// </summary>
        DAL.AccountService accountService = new DAL.AccountService();

        #region 实现获取用户用户名及密码 +MODEL.tb_Account Login(string login)
        /// <summary>
        /// 实现登录
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public MODEL.tb_Account Login(string login)
        {
            return accountService.Login(login);
        }
        #endregion



        #region 插入新账号 +int InsertAccount(MODEL.tb_Account newAccount)
        /// <summary>
        /// 插入新账号
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public int InsertAccount(MODEL.tb_Account newAccount)
        {
            //return accountService.InsertAccount(newAccount);
            return 0;

        }
        #endregion

        #region 修改账号信息+ int UpdateAccount(MODEL.tb_Account updateAccount)
        /// <summary>
        /// 修改账号信息
        /// </summary>
        /// <param name="updateAccount"></param>
        public int UpdateAccount(MODEL.tb_Account updateAccount)
        {
            //return accountService.UpdateAccount(updateAccount);
            return 0;

        }
        #endregion



        /// <summary>
        /// 根据学生ID获取他的实体类账号对象
        /// </summary>
        /// <param name="studentID"></param>
        public MODEL.tb_Account GetAccountByStudentID(int studentID)
        {
            return accountService.GetAccountByStudentID(studentID);
        }

        #region 根据员工ID获取他的实体类账号对象+MODEL.tb_Account GetAccountByStaffID(int staffID)
        /// <summary>
        /// 根据员工ID获取他的实体类账号对象
        /// </summary>
        /// <param name="staffID"></param>
        public MODEL.tb_Account GetAccountByStaffID(int staffID)
        {
            return accountService.GetAccountByStaffID(staffID);
        }
        #endregion


        /// <summary>
        /// 根据学生姓名获取他的实体类账号对象
        /// </summary>
        /// <param name="studentName"></param>
        public MODEL.tb_Account GetAccountByStudentName(string studentName)
        {
            return accountService.GetAccountByStudentName(studentName);
        }
    }
}
