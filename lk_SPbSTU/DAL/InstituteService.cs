using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class InstituteService
    {

        #region 获取所有学院信息 + List<MODEL.tb_Institute> getAllInstituteList()
        /// <summary>
        /// 获取所有学院信息
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<MODEL.tb_Institute> getAllInstituteList()
        {
            string sql = "SELECT IDInstitute, NameInstitute, ShortNameInst, Email, Website, Phone, DetAddress FROM tb_Institute";
            DataTable dataTable = SqlHelper.ExectureTabel(sql);

            // 将表的每一行数据转换为对象然后添加到集合中。因为表的每一行，每一列是一个 Object ，如果后期在控件中修改的话要在对象中做
            List<MODEL.tb_Institute> instituteList = null;
            if (dataTable.Rows.Count > 0)
            {
                // 一定要实例化对象的数据！
                instituteList = new List<MODEL.tb_Institute>();

                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行就对应着一条数据
                    MODEL.tb_Institute tmpInstitute = new MODEL.tb_Institute();
                    InstituteRow2InstutiteObject(row, tmpInstitute);
                    // 将当前生成的对象添加到集合中
                    instituteList.Add(tmpInstitute);
                }
            }

            return instituteList;
        }
        #endregion


        #region 将 institute 数据行转换为 Institute 对象 + void InstituteRow2InstutiteObject(DataRow row, MODEL.tb_Institute institute)
        /// <summary>
        /// 将 classes 数据行转换为Classes 对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="institute"></param>
        void InstituteRow2InstutiteObject(DataRow row, MODEL.tb_Institute institute)
        {
            institute.IDInstitute = (int)row["IDInstitute"];
            institute.NameInstitute = row["NameInstitute"].ToString();
            institute.ShortNameInst = row["ShortNameInst"].ToString();
            institute.Email = row["Email"].ToString();
            institute.Website = row["Website"].ToString();
            institute.Phone = row["Phone"].ToString();
            institute.DetAddress = row["DetAddress"].ToString();
        }
        #endregion

    }
}
