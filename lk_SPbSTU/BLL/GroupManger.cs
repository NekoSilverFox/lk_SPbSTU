using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GroupManger
    {
        DAL.GroupService groupService = new DAL.GroupService();

        #region 获取所有班级的列表 +List<MODEL.tb_Group> GetAllGroupList()
        /// <summary>
        /// 获取所有班级的列表
        /// </summary>
        /// <returns></returns>
        public List<MODEL.tb_Group> GetAllGroupList()
        {
            return groupService.GetAllGroupList();
        }
        #endregion


        #region 插入新班级 +int InsertGroup(MODEL.tb_Group newGroup)
        /// <summary>
        /// 插入新方向
        /// </summary>
        /// <param name="newGroup"></param>
        /// <returns></returns>
        public int InsertGroup(MODEL.tb_Group newGroup)
        {
            // return groupServer.InsertGroup(newGroup);
            return 0;

        }
        #endregion

        #region 修改班级信息+ int UpdateGroup(MODEL.tb_Group updateGroup)
        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="updateGroup"></param>
        public int UpdateGroup(MODEL.tb_Group updateGroup)
        {
            // return groupServer.UpdateGroup(updateGroup);
            return 0;

        }
        #endregion
    }
}
