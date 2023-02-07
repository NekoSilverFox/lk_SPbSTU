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



		private int _idinstitute;
		public int IDInstitute
		{
			set { _idinstitute = value; }
			get { return _idinstitute; }
		}

		private string _nameinstitute;
		public string NameInstitute
		{
			set { _nameinstitute = value; }
			get { return _nameinstitute; }
		}
		/// <summary>
		///
		/// </summary>
		private string _shortnameinst;

		public string ShortNameInst
		{
			set { _shortnameinst = value; }
			get { return _shortnameinst; }
		}

		private int _idprofession;
		public int IDProfession
		{
			set { _idprofession = value; }
			get { return _idprofession; }
		}

		private string _nameprofession;
		public string NameProfession
		{
			set { _nameprofession = value; }
			get { return _nameprofession; }
		}

		private string _codeprofession;
		public string CodeProfession
		{
			set { _codeprofession = value; }
			get { return _codeprofession; }
		}

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
