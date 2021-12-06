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
    public partial class LKStudentInfoForm : Form
    {
        public LKStudentInfoForm()
        {
            InitializeComponent();
        }

        private void LKStudentInfoForm_Load(object sender, EventArgs e)
        {
            // 获取这个学生的账号ID用于显示
            int accountID = MODEL.tb_Account.accountIDNow;

            // 从 Student 表中获取他的具体信息
            BLL.StudentManger studentManger = new BLL.StudentManger();
            MODEL.tb_Student student = studentManger.getStudentInfo(accountID);

            this.txtID.Text = student.IDStudent.ToString();
            this.txtLogin.Text = student.Login;
            this.txtName.Text = student.NameStudent;
            this.txtGender.Text = student.StrGender;
            this.txtBirthday.Text = Convert.ToDateTime(student.Birthday.ToString()).Year.ToString()
                + "-" + Convert.ToDateTime(student.Birthday.ToString()).Month.ToString()
                + "-" + Convert.ToDateTime(student.Birthday.ToString()).Day.ToString();
            this.txtPhone.Text = student.Phone.Trim();
            this.txtEmail.Text = student.Email;
            this.txtInstitulate.Text = student.NameInstitute;
            this.txtProfessionCode.Text = student.CodeProfession;
            this.txtProfession.Text = student.NameProfession;
            this.txtGroup.Text = student.Namegroup;
            this.txtGrade.Text = student.Grade.ToString();
            this.txtEnrollTime.Text = Convert.ToDateTime(student.EnrollTime.ToString()).Year.ToString()
                + "-" + Convert.ToDateTime(student.EnrollTime.ToString()).Month.ToString()
                + "-" + Convert.ToDateTime(student.EnrollTime.ToString()).Day.ToString();
        }
    }
}
