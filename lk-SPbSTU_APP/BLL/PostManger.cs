using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PostManger
    {
        /// <summary>
        /// 创建一个全局的数据层访问对象，因为以后的很多操作都需要调用数据访问层中的方法
        /// </summary>
        DAL.PostService postService = new DAL.PostService();

        #region 获取所有的 Post 列表 +List<MODEL.tb_Post> GetAllPostList()
        /// <summary>
        /// 获取所有的 Post 列表
        /// </summary>
        /// <returns></returns>
        public List<MODEL.tb_Post> GetAllPostList()
        {
            return postService.GetAllPostList();
        }
        #endregion
    }
}
