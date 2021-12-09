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

        #region 通过 accountID 获取指定学生的培训计划 +List<MODEL.tb_StudyPlan> GetStudentStudyPlanByAccountID(int accountID)
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

        #region 获取所有的培训计划 + List<MODEL.tb_StudyPlan> GetAllStudyPlanList()
        /// <summary>
        /// 获取所有的培训计划
        /// </summary>
        public List<MODEL.tb_StudyPlan> GetAllStudyPlanList()
        {
            return studyPlanServer.GetAllStudyPlanList();
        }
        #endregion

        #region 插入新培训计划 +int InsertStudyPlan(MODEL.tb_StudyPlan newStudyPlan)
        /// <summary>
        /// 插入新培训计划
        /// </summary>
        /// <param name="newStudent "></param>
        /// <returns></returns>
        public int InsertStudyPlan(MODEL.tb_StudyPlan newStudyPlan)
        {
            return studyPlanServer.InsertStudyPlan(newStudyPlan);
        }
        #endregion

        #region 修改培训计划信息+ int UpdateStudyPlan(MODEL.tb_StudyPlan updateStudyPlan)
        /// <summary>
        /// 修改培训计划信息
        /// </summary>
        /// <param name="updateStudyPlan"></param>
        public int UpdateStudyPlan(MODEL.tb_StudyPlan updateStudyPlan)
        {
            //return studyPlanServer.UpdateStudyPlan(updateStudyPlan);
            return 0;

        }
        #endregion
    }
}
