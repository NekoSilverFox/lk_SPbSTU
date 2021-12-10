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
    public partial class LKStaffInfoForm : Form
    {
        public LKStaffInfoForm()
        {
            InitializeComponent();
        }

        private void LKStaffInfoForm_Load(object sender, EventArgs e)
        {
            // 获取这个员工的账号用于显示
            BLL.AccountManger accountManger = new BLL.AccountManger();
            MODEL.tb_Account account = accountManger.Login(MODEL.tb_Account.accountLoginNow);

            // 从Staff表中获取他的具体信息
            BLL.StaffManger staffManger = new BLL.StaffManger();
            MODEL.tb_Staff staff = staffManger.getStaffInfo(account.IDAccount);

            this.txtAccountID.Text = account.IDAccount.ToString().Trim();
            this.txtLogin.Text = account.Login;
            this.txtPwd.Text = account.Passwd;

            this.txtID.Text = staff.IDStaff.ToString();
            this.txtName.Text = staff.NameStaff;

            this.rdoMan.Checked = staff.Gender;
            this.rdoWoman.Checked = !staff.Gender;

            this.dtpBirthday.Value = staff.Birthday;

            this.txtPhone.Text = staff.Phone.Trim();
            this.txtEmail.Text = staff.Email;
            this.txtHiredate.Text = Convert.ToDateTime(staff.Hiredate.ToString()).Year.ToString()
                + "-" + Convert.ToDateTime(staff.Hiredate.ToString()).Month.ToString()
                + "-" + Convert.ToDateTime(staff.Hiredate.ToString()).Day.ToString();
            this.txtPostID.Text = staff.PostID.ToString();
            this.txtPost.Text = staff.StrPost.Trim();
            this.txtInstituteID.Text = staff.InstituteID.ToString();
            this.txtInstitulate.Text = staff.StrInstitute.Trim();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidataUser())
            {
                return;
            }

            // 获取这个员工的账号用于显示
            BLL.AccountManger accountManger = new BLL.AccountManger();
            MODEL.tb_Account account = accountManger.Login(MODEL.tb_Account.accountLoginNow);

            // 从Staff表中获取他的具体信息
            BLL.StaffManger staffManger = new BLL.StaffManger();
            MODEL.tb_Staff staff = staffManger.getStaffInfo(account.IDAccount);


            // ----------------------------------------------------------------------------------------------------------
            staff.Passwd = this.txtPwd.Text.ToString().Trim();
            staff.Passwd = BLL.CommonHelper.GetMD5(staff.Passwd);
            staff.Gender = this.rdoMan.Checked ? true : false;
            staff.Birthday = this.dtpBirthday.Value;
            staff.Phone = this.txtPhone.Text.ToString().Trim();
            staff.Email = this.txtEmail.Text.ToString().Trim();
            // ----------------------------------------------------------------------------------------------------------

            if (staffManger.UpdateStaff(staff) != 0)
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
