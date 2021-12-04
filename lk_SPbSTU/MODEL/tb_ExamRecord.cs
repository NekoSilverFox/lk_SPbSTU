using System;
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
		#endregion Model

	}
}
