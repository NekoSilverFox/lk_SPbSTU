using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_Student:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Student
	{
		public tb_Student()
		{ }
		#region Model
		private int _idstudent;
		private string _namestudent;
		private bool _gender;
		private DateTime? _birthday;
		private string _phone;
		private int _accountid;
		private string _email;
		private DateTime _enrolltime = Convert.ToDateTime(datenameyear, getdate + "-09-01");
		private int _groupid;
		/// <summary>
		///
		/// </summary>
		public int IDStudent
		{
			set { _idstudent = value; }
			get { return _idstudent; }
		}
		/// <summary>
		///
		/// </summary>
		public string NameStudent
		{
			set { _namestudent = value; }
			get { return _namestudent; }
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
		public DateTime EnrollTime
		{
			set { _enrolltime = value; }
			get { return _enrolltime; }
		}
		/// <summary>
		///
		/// </summary>
		public int GroupID
		{
			set { _groupid = value; }
			get { return _groupid; }
		}
		#endregion Model

	}
}
