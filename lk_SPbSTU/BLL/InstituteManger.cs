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
        public List<MODEL.tb_Institute> GetAllInstituteList()
        {
            return instituteService.GetAllInstituteList();
        }
        #endregion

        #region 添加新的学院到tb_institute表中 +int InsertInstitute(MODEL.tb_Institute newInstitute)
        /// <summary>
        /// 添加新的学院到tb_institute表中
        /// </summary>
        /// <param name="newInstitute"></param>
        /// <returns></returns>
        public int InsertInstitute(MODEL.tb_Institute newInstitute)
        {
            return instituteService.InsertInstitute(newInstitute);
        }
        #endregion

    }
}
