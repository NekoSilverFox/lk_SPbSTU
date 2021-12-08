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
    public partial class AdminStaffForm : Form
    {
        BLL.StaffManger staffManger = new BLL.StaffManger();

        public AdminStaffForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void AdminStaffForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = staffManger.GetAllStaffList();
        }

        private void tsmiAddInstitue_Click(object sender, EventArgs e)
        {
            gpAdd.Visible = true;
            gpAdd.Text = "Добавление";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 隐藏面板
            this.gpAdd.Visible = false;
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvList.SelectedRows.Count == 0)
            {
                return;
            }
            gpAdd.Visible = true;
            gpAdd.Text = "Изменение";

            // 获取绑定项
            //MODEL.Person person = this.dgvList.CurrentRow.DataBoundItem as MODEL.Person;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidataUser())
            {
                return;
            }

            MODEL.tb_Staff newStaff = null;

            if (gpAdd.Text == "Добавление")
            {
                newStaff = new MODEL.tb_Staff();
            }
            else
            {
                newStaff = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Staff;
            }

            // ----------------------------------------------------------------------------------------------------------
            newStaff.Login = this.txtLogin.Text.ToString().Trim();
            newStaff.Passwd = this.txtPwd.Text.ToString().Trim();
            newStaff.NameStaff = this.txtName.Text.ToString().Trim();
            newStaff.Birthday = this.dtpBirthday.Value;
            newStaff.Phone = this.txtPhone.Text.ToString().Trim();
            newStaff.Email = this.txtEmail.Text.ToString().Trim();
            newStaff.Hiredate = this.dtpHiredate.Value;
            newStaff.PostID = (this.cboPost.SelectedItem as MODEL.tb_Post).IDPost;
            newStaff.InstituteID = (this.cboInstutite.SelectedItem as MODEL.tb_Institute).IDInstitute;
            newStaff.Gender = this.rdoMam.Checked ? true : false;
            // ----------------------------------------------------------------------------------------------------------

            if (gpAdd.Text == "Добавление")
            {
                if (staffManger.UpdateStaff(newStaff) == 1)
                {
                    MessageBox.Show("Successfully added new staff");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = staffManger.GetAllStaffList();
                }
                else
                {
                    MessageBox.Show("Failed to add new staff");
                }
            }
            else
            {
                if (staffManger.UpdateStaff(newStaff) == 1)
                {
                    MessageBox.Show("Successfully change staff");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = staffManger.GetAllStaffList();
                }
                else
                {
                    MessageBox.Show("Failed to change staff");
                }
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
            if (string.IsNullOrEmpty(this.txtLogin.Text.Trim()))
            {
                MessageBox.Show("Please enter a legal login");

                // 【重点】定位光标
                txtLogin.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtPwd.Text.Trim()))
            {
                MessageBox.Show("Password can not be empty");

                // 【重点】定位光标
                txtPwd.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()) || Regex.IsMatch(txtName.Text.Trim(), @"\W"))
            {
                MessageBox.Show("Please enter a legal name");

                // 【重点】定位光标
                txtName.Focus();
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

            if (cboPost.SelectedItem == null ||
                cboInstutite.SelectedItem == null)
            {
                MessageBox.Show("Please choose all items");

                return false;
            }

            return true;
        }
        #endregion
    }
}
