using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserTypeManger
    {
        /// <summary>
        /// 创建一个全局的数据层访问对象，因为以后的很多操作都需要调用数据访问层中的方法
        /// </summary>
        DAL.UserTypeService userTypeService = new DAL.UserTypeService();

        public MODEL.UserType GetUserType(int accountid)
        {
            return userTypeService.GetUserType(accountid);
        }
    }
}
