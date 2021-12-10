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
            this.txtPwd.Text = student.Passwd.ToString().Trim();
            this.txtName.Text = student.NameStudent;
            this.rdoMan.Checked = student.Gender;
            this.rdoWoman.Checked = !student.Gender;
            this.dtpBirthday.Value = student.Birthday;
            this.txtPhone.Text = student.Phone.Trim();
            this.txtEmail.Text = student.Email;
            this.txtInstitulate.Text = student.NameInstitute;
            this.txtProfessionCode.Text = student.CodeProfession;
            this.txtProfession.Text = student.NameProfession;
            this.txtGroupID.Text = student.GroupID.ToString();
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
            // 获取这个学生的账号ID用于显示
            int accountID = MODEL.tb_Account.accountIDNow;

            // 从 Student 表中获取他的具体信息
            BLL.StudentManger studentManger = new BLL.StudentManger();
            MODEL.tb_Student student = studentManger.getStudentInfo(accountID);

            // ----------------------------------------------------------------------------------------------------------
            student.Passwd = this.txtPwd.Text.ToString().Trim();
            student.Passwd = BLL.CommonHelper.GetMD5(student.Passwd);
            student.Gender = this.rdoMan.Checked ? true : false;
            student.Birthday = this.dtpBirthday.Value;
            student.Phone = this.txtPhone.Text.ToString().Trim();
            student.Email = this.txtEmail.Text.ToString().Trim();
            // ----------------------------------------------------------------------------------------------------------

            if (studentManger.UpdateStudent(student) != 0)
            {
                MessageBox.Show("Successfully change info");
            }
            else
            {
                MessageBox.Show("Failed to change info");
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
            if (string.IsNullOrEmpty(this.txtPwd.Text.Trim()))
            {
                MessageBox.Show("Password can not be empty");

                // 【重点】定位光标
                txtPwd.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtPhone.Text.Trim()) || Regex.IsMatch(txtPhone.Text.Trim(), @"\W"))
            {
                MessageBox.Show("Please enter a legal phone number");

                // 【重点】定位光标
                txtPhone.Focus();
                return false;
            }

            // 填了邮箱就判断邮箱格式是否正确
            if (!string.IsNullOrEmpty(this.txtEmail.Text.Trim()))
            {
                if (!Regex.IsMatch(txtEmail.Text.Trim(), @"\w+[@]\w+[.]\w+"))
                {
                    MessageBox.Show("Please enter a legal Email");
                    txtEmail.Focus();
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
