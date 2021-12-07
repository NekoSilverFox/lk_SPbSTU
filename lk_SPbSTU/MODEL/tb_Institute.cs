using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_Institute:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Institute
	{
		public tb_Institute()
		{ }
		#region Model
		private string _email;
		private string _website;
		private string _detaddress;
		private string _phone;
		/// <summary>
		///
		/// </summary>
		private int _idinstitute;
		public int IDInstitute
		{
			set { _idinstitute = value; }
			get { return _idinstitute; }
		}

		/// <summary>
		///
		/// </summary>
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

		/// <summary>
		///
		/// </summary>
		public string Email
		{
			set { _email = value; }
			get { return _email; }
		}
		/// <summary>
		///
		/// </summary>
		public string Website
		{
			set { _website = value; }
			get { return _website; }
		}
		/// <summary>
		///
		/// </summary>
		public string DetAddress
		{
			set { _detaddress = value; }
			get { return _detaddress; }
		}
		/// <summary>
		///
		/// </summary>
		public string Phone
		{
			set { _phone = value; }
			get { return _phone; }
		}
		#endregion Model

	}
}
