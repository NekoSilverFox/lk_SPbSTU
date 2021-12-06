using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudyPlanManger
    {
        /// <summary>
        /// 创建一个全局的数据层访问对象，因为以后的很多操作都需要调用数据访问层中的方法
        /// </summary>
        DAL.StudyPlanServer studyPlanServer = new DAL.StudyPlanServer();

        #region
        /// <summary>
        /// 通过 accountID 获取指定学生的培训计划
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public List<MODEL.tb_StudyPlan> GetStudentStudyPlanByAccountID(int accountID)
        {
            return studyPlanServer.GetStudentStudyPlanByAccountID(accountID);
        }
        #endregion
    }
}
