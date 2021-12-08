using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
	/// <summary>
	/// tb_Discipline:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Discipline
	{
		public tb_Discipline()
		{ }
		#region Model
		private int _iddiscipline;
		private string _namediscipline;
		private int _perioddiscipline = 100;
		private string _descriptiondiscipline;

		/// <summary>
		///
		/// </summary>
		public int IDDiscipline
		{
			set { _iddiscipline = value; }
			get { return _iddiscipline; }
		}
		/// <summary>
		///
		/// </summary>
		public string NameDiscipline
		{
			set { _namediscipline = value; }
			get { return _namediscipline; }
		}
		/// <summary>
		///
		/// </summary>
		public int PeriodDiscipline
		{
			set { _perioddiscipline = value; }
			get { return _perioddiscipline; }
		}
		/// <summary>
		///
		/// </summary>
		public string DescriptionDiscipline
		{
			set { _descriptiondiscipline = value; }
			get { return _descriptiondiscipline; }
		}
		#endregion Model

	}
}
