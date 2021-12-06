using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProfessionManger
    {
        DAL.ProfessionServer professionServer = new DAL.ProfessionServer();


        #region 获取所有方向信息（原表）+List<MODEL.tb_Profession> getAllProfessionList()
        /// <summary>
        ///  获取所有方向信息（原表）
        /// </summary>
        /// <returns></returns>
        public List<MODEL.tb_Profession> GetAllProfessionList()
        {
            return professionServer.GetAllProfessionList();
        }
        #endregion
    }
}
