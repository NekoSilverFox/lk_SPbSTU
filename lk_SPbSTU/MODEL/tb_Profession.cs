using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_Profession:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Profession
	{
		public tb_Profession()
		{ }
		#region Model
		private int _idprofession;
		private int _instituteid;
		private string _codeprofession;
		private string _nameprofession;
		private decimal _tuitionfee = 20000M;
		/// <summary>
		///
		/// </summary>
		public int IDProfession
		{
			set { _idprofession = value; }
			get { return _idprofession; }
		}
		/// <summary>
		///
		/// </summary>
		public int InstituteID
		{
			set { _instituteid = value; }
			get { return _instituteid; }
		}
		/// <summary>
		///
		/// </summary>
		public string CodeProfession
		{
			set { _codeprofession = value; }
			get { return _codeprofession; }
		}
		/// <summary>
		///
		/// </summary>
		public string NameProfession
		{
			set { _nameprofession = value; }
			get { return _nameprofession; }
		}
		/// <summary>
		///
		/// </summary>
		public decimal TuitionFee
		{
			set { _tuitionfee = value; }
			get { return _tuitionfee; }
		}
		#endregion Model

	}
}
