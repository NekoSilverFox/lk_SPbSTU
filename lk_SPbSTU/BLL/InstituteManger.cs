using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InstituteManger
    {
        DAL.InstituteService instituteService = new DAL.InstituteService();


        #region 获取所有学院信息 + public List<MODEL.tb_Institute> getAllInstituteList()
        /// <summary>
        /// 获取所有班级信息
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<MODEL.tb_Institute> getAllInstituteList()
        {
            return instituteService.getAllInstituteList();
        }
        #endregion
    }
}
