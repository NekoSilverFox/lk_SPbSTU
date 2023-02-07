using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PostService
    {

        #region 获取所有的 Post 列表 +List<MODEL.tb_Post> GetAllPostList()
        /// <summary>
        /// 获取所有的 Post 列表
        /// </summary>
        /// <returns></returns>
        public List<MODEL.tb_Post> GetAllPostList()
        {
            string sql = "SELECT IDPost, NamePost FROM tb_Post";
            DataTable dataTable = SqlHelper.ExectureTabel(sql);

            // 将表的每一行数据转换为对象然后添加到集合中。因为表的每一行，每一列是一个 Object ，如果后期在控件中修改的话要在对象中做
            List<MODEL.tb_Post> postList = null;
            if (dataTable.Rows.Count > 0)
            {
                // 一定要实例化对象的数据！
                postList = new List<MODEL.tb_Post>();

                foreach (DataRow row in dataTable.Rows)
                {
                    // 每一行就对应着一条数据
                    MODEL.tb_Post tmpPost = new MODEL.tb_Post();
                    PostRow2Object(row, tmpPost);
                    // 将当前生成的对象添加到集合中
                    postList.Add(tmpPost);
                }
            }

            return postList;
        }
        #endregion

        #region 将 Post 数据行转换为 Post 对象 + void PostRow2Object(DataRow row, MODEL.tb_Post post)
        /// <summary>
        /// 将 institute 数据行转换为 Institute 对象
        /// </summary>
        /// <param name="row"></param>
        /// <param name="post"></param>
        void PostRow2Object(DataRow row, MODEL.tb_Post post)
        {
            post.IDPost = (int)row["IDPost"];
            post.NamePost = row["NamePost"].ToString().Trim();
        }
        #endregion
    }
}
