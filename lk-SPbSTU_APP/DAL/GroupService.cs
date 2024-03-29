﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class GroupService
    {
        #region 获取所有班级的列表 +List<MODEL.tb_Group> GetAllGroupList()
        /// <summary>
        /// 获取所有班级的列表
        /// </summary>
        /// <returns></returns>
        public List<MODEL.tb_Group> GetAllGroupList()
        {
            string sql = "SELECT IDGroup, NameGroup, Grade, Quantity, IDInstitute, NameInstitute, ShortNameInst, IDProfession, NameProfession, CodeProfession FROM tb_Group JOIN tb_Profession ON tb_Profession.IDProfession=tb_Group.ProfessionID JOIN tb_Institute ON tb_Institute.IDInstitute=tb_Profession.InstituteID";
            DataTable dataTable = SqlHelper.ExectureTabel(sql);

            // 将表的每一行数据转换为对象然后添加到集合中。因为表的每一行，每一列是一个 Object ，如果后期在控件中修改的话要在对象中做
            List<MODEL.tb_Group> groupList = null;
            if (dataTable.Rows.Count > 0)
            {
                // 一定要实例化对象的数据！
                groupList = new List<MODEL.tb_Group>();

                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行就对应着一条数据
                    MODEL.tb_Group tmpGroup = new MODEL.tb_Group();
                    GroupRow2GroupObject(row, tmpGroup);
                    // 将当前生成的对象添加到集合中
                    groupList.Add(tmpGroup);
                }
            }

            return groupList;

        }
        #endregion

        #region 将 Group 数据行转换为 Group 对象 +void GroupRow2GroupObject(DataRow row, MODEL.tb_Group group)
        /// <summary>
        /// 将 institute 数据行转换为 Institute 对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="group"></param>
        void GroupRow2GroupObject(DataRow row, MODEL.tb_Group group)
        {
            group.IDGroup = (int)row["IDGroup"];
            group.NameGroup = row["NameGroup"].ToString().Trim();
            group.Grade = (int)row["Grade"];
            group.Quantity = (int)row["Quantity"];
            group.IDInstitute = (int)row["IDInstitute"];
            group.NameInstitute = row["NameInstitute"].ToString().Trim();
            group.ShortNameInst = row["ShortNameInst"].ToString().Trim();
            group.IDProfession = (int)row["IDProfession"];
            group.NameProfession = row["NameProfession"].ToString().Trim();
            group.CodeProfession = row["CodeProfession"].ToString().Trim();
        }
        #endregion

        #region 插入新班级 +int InsertGroup(MODEL.tb_Group newGroup)
        /// <summary>
        /// 插入新方向
        /// </summary>
        /// <param name="newGroup"></param>
        /// <returns></returns>
        public int InsertGroup(MODEL.tb_Group newGroup)
        {
            string sql = "INSERT tb_Group VALUES(@NameGroup, @ProfessionID, @Grade, @Quantity)";

            SqlParameter[] ps =
            {
                new SqlParameter("@NameGroup", newGroup.NameGroup),
                new SqlParameter("@ProfessionID", newGroup.ProfessionID),
                new SqlParameter("@Grade", newGroup.Grade),
                new SqlParameter("@Quantity", newGroup.Quantity)
            };

            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion

        #region 修改班级信息+ int UpdateGroup(MODEL.tb_Group updateGroup)
        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="updateGroup"></param>
        public int UpdateGroup(MODEL.tb_Group updateGroup)
        {
            string sql = "UPDATE tb_Group SET NameGroup=@NameGroup, ProfessionID=@ProfessionID, Grade=@Grade, Quantity=@Quantity WHERE IDGroup=@IDGroup";

            SqlParameter[] ps =
            {
                new SqlParameter("@IDGroup", updateGroup.IDGroup),
                new SqlParameter("@NameGroup", updateGroup.NameGroup),
                new SqlParameter("@ProfessionID", updateGroup.ProfessionID),
                new SqlParameter("@Grade", updateGroup.Grade),
                new SqlParameter("@Quantity", updateGroup.Quantity)
            };

            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
        #endregion
    }
}
