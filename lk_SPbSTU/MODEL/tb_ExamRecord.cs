﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_ExamRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_ExamRecord
	{
		public tb_ExamRecord()
		{ }
		#region Model
		private int _idexamrecord;
		private int _studyplanid;
		private int _studentid;
		private int _mark;
		private DateTime _examdate = DateTime.Now;

		private int _idInstitute;
		private string _shortNameInst;
		private int _idProfession;
		private string _nameProfession;
		private int _idGroup;
		private string _nameGroup;
		private int _idDiscipline;
		private string _nameDiscipline;
		private string _nameStudent;

		private int _id;
		private int _semester;
		private string _namediscipline;

		public int Semester
		{
			set { _semester = value; }
			get { return _semester; }
		}

		public string NameDiscipline
		{
			set { _namediscipline = value; }
			get { return _namediscipline; }
		}

		/// <summary>
		///
		/// </summary>
		public int IDExamRecord
		{
			set { _idexamrecord = value; }
			get { return _idexamrecord; }
		}
		/// <summary>
		///
		/// </summary>
		public int StudyPlanID
		{
			set { _studyplanid = value; }
			get { return _studyplanid; }
		}
		/// <summary>
		///
		/// </summary>
		public int StudentID
		{
			set { _studentid = value; }
			get { return _studentid; }
		}
		/// <summary>
		///
		/// </summary>
		public int Mark
		{
			set { _mark = value; }
			get { return _mark; }
		}
		/// <summary>
		///
		/// </summary>
		public DateTime ExamDate
		{
			set { _examdate = value; }
			get { return _examdate; }
		}

		public int IdInstitute { get => _idInstitute; set => _idInstitute = value; }
		public string ShortNameInst { get => _shortNameInst; set => _shortNameInst = value; }
		public int IdProfession { get => _idProfession; set => _idProfession = value; }
		public string NameProfession { get => _nameProfession; set => _nameProfession = value; }
		public int IdGroup { get => _idGroup; set => _idGroup = value; }
		public string NameGroup { get => _nameGroup; set => _nameGroup = value; }
		public int IdDiscipline { get => _idDiscipline; set => _idDiscipline = value; }
		public string NameDiscipline1 { get => _nameDiscipline; set => _nameDiscipline = value; }
		public string NameStudent { get => _nameStudent; set => _nameStudent = value; }
		#endregion Model

	}
}
