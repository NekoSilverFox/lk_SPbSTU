﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_Account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Account
	{
		public tb_Account()
		{ }
		#region Model
		private int _idaccount;
		private string _login;
		private string _passwd;
		/// <summary>
		///
		/// </summary>
		public int IDAccount
		{
			set { _idaccount = value; }
			get { return _idaccount; }
		}
		/// <summary>
		///
		/// </summary>
		public string Login
		{
			set { _login = value; }
			get { return _login; }
		}
		/// <summary>
		///
		/// </summary>
		public string Passwd
		{
			set { _passwd = value; }
			get { return _passwd; }
		}
		#endregion Model

	}
}
