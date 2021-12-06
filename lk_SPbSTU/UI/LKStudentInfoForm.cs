using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 正则表达式
using System.Text.RegularExpressions;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidataUser())
            {
                return;
            }
        }

        #region 用户信息输入检测+bool ValidataUser()
        /// <summary>
        /// 用户信息输入检测
        /// </summary>
        /// <returns></returns>
        bool ValidataUser()
        {
            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtGender.Text.Trim()))
            {
                MessageBox.Show("Gender can not be empty");

                // 【重点】定位光标
                this.txtGender.Focus();
                return false;
            }

            if (this.txtGender.Text.Trim() != "Man" && this.txtGender.Text.Trim() != "Male")
            {
                MessageBox.Show("Gender should be `Man` or `Male`");

                // 【重点】定位光标
                this.txtGender.Focus();
                return false;
            }

            if (!Regex.IsMatch(this.txtBirthday.Text.Trim(), @"\d{4}-\d{1,2}-\d{1,2}"))
            {
                MessageBox.Show("Birthday should be `YYYY-MM-dd`");

                // 【重点】定位光标
                this.txtBirthday.Focus();
                return false;
            }

            if (!Regex.IsMatch(this.txtPhone.Text.Trim(), @"\d{5,10}"))
            {
                MessageBox.Show("Incorrect phone number");

                // 【重点】定位光标
                this.txtPhone.Focus();
                return false;
            }

            // 填了邮箱就判断邮箱格式是否正确
            if (!string.IsNullOrEmpty(this.txtEmail.Text.Trim()))
            {
                if (!Regex.IsMatch(txtEmail.Text.Trim(), @"\w+[@]\w+[.]\w+"))
                {
                    MessageBox.Show("Incorrect email");
                    txtEmail.Focus();
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}
