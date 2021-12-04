using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_Group:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Group
	{
		public tb_Group()
		{ }
		#region Model
		private int _idgroup;
		private string _namegroup;
		private int _professionid;
		private int _grade = DateTime.Now.Year;
		private int? _quantity = 40;
		/// <summary>
		///
		/// </summary>
		public int IDGroup
		{
			set { _idgroup = value; }
			get { return _idgroup; }
		}
		/// <summary>
		///
		/// </summary>
		public string NameGroup
		{
			set { _namegroup = value; }
			get { return _namegroup; }
		}
		/// <summary>
		///
		/// </summary>
		public int ProfessionID
		{
			set { _professionid = value; }
			get { return _professionid; }
		}
		/// <summary>
		///
		/// </summary>
		public int Grade
		{
			set { _grade = value; }
			get { return _grade; }
		}
		/// <summary>
		///
		/// </summary>
		public int? Quantity
		{
			set { _quantity = value; }
			get { return _quantity; }
		}
		#endregion Model

	}
}
