using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_Post:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserType
	{
		public UserType()
		{ }

		#region Model
		private string _accountusertype;
		/// <summary>
		///
		/// </summary>
		public string AccountUserType
		{
			set { _accountusertype = value; }
			get { return _accountusertype; }
		}
	}
    #endregion
}
