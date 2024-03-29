﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_StudyPlan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_StudyPlan
	{
		public tb_StudyPlan()
		{ }
		#region Model
		private int _idstudyplan;
		private int _groupid;
		private int _disciplineid;
		private int _semestr;
		private int _staffid;


		private string _emailTeacher;
		private string _eduEmailTeacher;
		private string _phoneTeacher;
		private string _nameDiscipline;
		private int _periodDiscipline;
		private string _nameStaff;

		private int _idgroup;
		private string _namegroup;

		/// <summary>
		///
		/// </summary>
		public int IDStudyPlan
		{
			set { _idstudyplan = value; }
			get { return _idstudyplan; }
		}
		/// <summary>
		///
		/// </summary>
		public int GroupID
		{
			set { _groupid = value; }
			get { return _groupid; }
		}
		/// <summary>
		///
		/// </summary>
		public int DisciplineID
		{
			set { _disciplineid = value; }
			get { return _disciplineid; }
		}
		/// <summary>
		///
		/// </summary>
		public int Semestr
		{
			set { _semestr = value; }
			get { return _semestr; }
		}
		/// <summary>
		///
		/// </summary>
		public int StaffID
		{
			set { _staffid = value; }
			get { return _staffid; }
		}

		public string NameDiscipline { get => _nameDiscipline; set => _nameDiscipline = value; }
		public int PeriodDiscipline { get => _periodDiscipline; set => _periodDiscipline = value; }
		public string NameStaff { get => _nameStaff; set => _nameStaff = value; }
		public string EmailTeacher { get => _emailTeacher; set => _emailTeacher = value; }
		public string EduEmailTeacher { get => _eduEmailTeacher; set => _eduEmailTeacher = value; }
		public string PhoneTeacher { get => _phoneTeacher; set => _phoneTeacher = value; }
		public int IDGroup { get => _idgroup; set => _idgroup = value; }
		public string NameGroup { get => _namegroup; set => _namegroup = value; }
		#endregion Model

	}
}
