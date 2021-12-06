using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class StudentExamRecordForm : Form
    {
        /// <summary>
        /// 全局的 ExamRecordsManger 表业务层处理对象
        /// </summary>
        BLL.ExamRecordManger examRecordManger = new BLL.ExamRecordManger();


        public StudentExamRecordForm()
        {
            InitializeComponent();
        }

        private void StudentExamRecordForm_Load(object sender, EventArgs e)
        {
            // this.dgvList.DataSource = examRecordManger.GetExamRecordsByStudentID()
        }
    }
}
