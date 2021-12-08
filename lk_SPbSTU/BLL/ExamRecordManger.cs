using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamRecordManger
    {
        /// <summary>
        /// 创建一个全局的数据层访问对象，因为以后的很多操作都需要调用数据访问层中的方法
        /// </summary>
        DAL.ExamRecordService examRecordService = new DAL.ExamRecordService();


        #region 根据学生ID获取成绩册 +List<MODEL.tb_ExamRecord> GetExamRecordsByStudentID(int studentID)
        /// <summary>
        /// 根据学生ID获取成绩册
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public List<MODEL.tb_ExamRecord> GetExamRecordsByStudentID(int studentID)
        {
            return examRecordService.GetExamRecordsByStudentID(studentID);
        }
        #endregion

        #region 插入新ExamRecord +int InsertExamRecord(MODEL.tb_ExamRecord newExamRecord)
        /// <summary>
        /// 插入新科目
        /// </summary>
        /// <param name="newExamRecord"></param>
        /// <returns></returns>
        public int InsertExamRecord(MODEL.tb_ExamRecord newExamRecord)
        {
            return examRecordService.InsertExamRecord(newExamRecord);
        }
        #endregion
    }
}
