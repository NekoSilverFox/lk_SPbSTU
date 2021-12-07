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
    }
}
