using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DisciplineManger
    {
        DAL.DisciplineService disciplineService = new DAL.DisciplineService();


        #region 获取所有科目信息 + List<MODEL.tb_Discipline> GetAllDisciplineList()
        /// <summary>
        /// 获取所有班级信息
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<MODEL.tb_Discipline> GetAllDisciplineList()
        {
            return disciplineService.GetAllDisciplineList();
        }
        #endregion
    }
}
