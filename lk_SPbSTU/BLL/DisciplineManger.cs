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


        #region 插入新科目 +int InsertDiscipline(MODEL.tb_Discipline newDiscipline)
        /// <summary>
        /// 插入新科目
        /// </summary>
        /// <param name="newDiscipline"></param>
        /// <returns></returns>
        public int InsertDiscipline(MODEL.tb_Discipline newDiscipline)
        {
            return disciplineService.InsertDiscipline(newDiscipline);
        }
        #endregion

        #region 修改科目信息+ int UpdateDiscipline(MODEL.tb_Discipline updateDiscipline)
        /// <summary>
        /// 修改科目信息
        /// </summary>
        /// <param name="updateDiscipline"></param>
        public int UpdateDiscipline(MODEL.tb_Discipline updateDiscipline)
        {
            return disciplineService.UpdateDiscipline(updateDiscipline);
        }
        #endregion
    }
}
