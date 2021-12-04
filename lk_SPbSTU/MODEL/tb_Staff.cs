using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_Staff:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Staff
	{
		public tb_Staff()
		{ }
		#region Model
		private int _idstaff;
		private string _namestaff;
		private bool _gender;
		private DateTime? _birthday;
		private string _phone;
		private int _accountid;
		private string _email;
		private DateTime _hiredate = DateTime.Now;
		private int? _postid;
		private int _instituteid;
		/// <summary>
		///
		/// </summary>
		public int IDStaff
		{
			set { _idstaff = value; }
			get { return _idstaff; }
		}
		/// <summary>
		///
		/// </summary>
		public string NameStaff
		{
			set { _namestaff = value; }
			get { return _namestaff; }
		}
		/// <summary>
		///
		/// </summary>
		public bool Gender
		{
			set { _gender = value; }
			get { return _gender; }
		}
		/// <summary>
		///
		/// </summary>
		public DateTime? Birthday
		{
			set { _birthday = value; }
			get { return _birthday; }
		}
		/// <summary>
		///
		/// </summary>
		public string Phone
		{
			set { _phone = value; }
			get { return _phone; }
		}
		/// <summary>
		///
		/// </summary>
		public int AccountID
		{
			set { _accountid = value; }
			get { return _accountid; }
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
		public DateTime Hiredate
		{
			set { _hiredate = value; }
			get { return _hiredate; }
		}
		/// <summary>
		///
		/// </summary>
		public int? PostID
		{
			set { _postid = value; }
			get { return _postid; }
		}
		/// <summary>
		///
		/// </summary>
		public int InstituteID
		{
			set { _instituteid = value; }
			get { return _instituteid; }
		}
		#endregion Model

	}
}
