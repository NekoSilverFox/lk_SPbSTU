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
	public partial class tb_Post
	{
		public tb_Post()
		{ }
		#region Model
		private int _idpost;
		private string _namepost;
		/// <summary>
		///
		/// </summary>
		public int IDPost
		{
			set { _idpost = value; }
			get { return _idpost; }
		}
		/// <summary>
		///
		/// </summary>
		public string NamePost
		{
			set { _namepost = value; }
			get { return _namepost; }
		}
		#endregion Model

	}
}
