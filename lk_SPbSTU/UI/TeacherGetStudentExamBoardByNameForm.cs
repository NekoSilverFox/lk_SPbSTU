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
    public partial class TeacherGetStudentExamBoardByNameForm : Form
    {

        BLL.AccountManger accountManger = new BLL.AccountManger();
        BLL.ExamRecordManger examRecordManger = new BLL.ExamRecordManger();

        public TeacherGetStudentExamBoardByNameForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void btnFindByStudentName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtStudentName.Text.ToString().Trim()))
            {
                MessageBox.Show("Please enter a student name");
                return;
            }


            string studentName = this.txtStudentName.Text.ToString().Trim();
            MODEL.tb_Account accountStudent = accountManger.GetAccountByStudentName(studentName);

            // 从 Student 表中获取他的具体信息
            BLL.StudentManger studentManger = new BLL.StudentManger();
            MODEL.tb_Student student = studentManger.getStudentInfo(accountStudent.IDAccount);

            this.dgvList.DataSource = examRecordManger.GetExamRecordsByStudentID(student.IDStudent);
        }
    }
}
