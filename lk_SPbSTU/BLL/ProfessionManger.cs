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

        #region 插入新方向+int InsertProfession(MODEL.tb_Profession newProfession)
        /// <summary>
        /// 插入新方向
        /// </summary>
        /// <param name="newProfession"></param>
        /// <returns></returns>
        public int InsertProfession(MODEL.tb_Profession newProfession)
        {
            return professionServer.InsertProfession(newProfession);
        }
        #endregion

        #region 修改方向信息+ int UpdateProfession(MODEL.tb_Profession updateProfession)
        /// <summary>
        /// 修改方向信息
        /// </summary>
        /// <param name="updateProfession"></param>
        public int UpdateProfession(MODEL.tb_Profession updateProfession)
        {
            //return professionServer.UpdateProfession(updateProfession);
            return 0;

        }
        #endregion
    }
}
