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


        #region 根据老师的ID获取他所有学生的成绩册 +List<MODEL.tb_ExamRecord> GetExamRecordsByStaffID(int staffID)
        /// <summary>
        /// 根据老师的ID获取他所有学生的成绩册
        /// </summary>
        /// <param name="staffID"></param>
        /// <returns></returns>
        public List<MODEL.tb_ExamRecord> GetExamRecordsByStaffID(int staffID)
        {
            return examRecordService.GetExamRecordsByStaffID(staffID);
        }
        #endregion


        #region 插入新成绩记录 +int InsertExamRecord(MODEL.tb_ExamRecord newExamRecord)
        /// <summary>
        /// 插入新成绩记录
        /// </summary>
        /// <param name="newExamRecord "></param>
        /// <returns></returns>
        public int InsertExamRecord(MODEL.tb_ExamRecord newExamRecord)
        {
            return examRecordService.InsertExamRecord(newExamRecord);
        }
        #endregion

        #region 修改成绩记录 +int UpdateExamRecord(MODEL.tb_ExamRecord updateExamRecord)
        /// <summary>
        /// 修改成绩记录
        /// </summary>
        /// <param name="updateExamRecord"></param>
        public int UpdateExamRecord(MODEL.tb_ExamRecord updateExamRecord)
        {
            return examRecordService.UpdateExamRecord(updateExamRecord);
        }
        #endregion

        #region 删除成绩记录 +int DeleteExamRecord(int id)
        /// <summary>
        /// 删除成绩记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteExamRecord(int id)
        {
            return examRecordService.DeleteExamRecord(id);
        }
        #endregion

    }
}
