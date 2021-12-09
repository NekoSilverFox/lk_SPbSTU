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
        /// <summary>
        /// 全局的 Institute 表业务层处理对象
        /// 用于加载下拉列表中的内容！！！
        /// </summary>
        BLL.InstituteManger instituteManger = new BLL.InstituteManger();

        BLL.PostManger postManger = new BLL.PostManger();

        BLL.StaffManger staffManger = new BLL.StaffManger();

        public AdminStaffForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void AdminStaffForm_Load(object sender, EventArgs e)
        {


            // 绑定学院下拉列表数据
            this.cboInstitute.DisplayMember = "ShortNameInst";      // 显示的值
            this.cboInstitute.ValueMember = "IDInstitute";              // 注意这里，绑定实际的值
            this.cboInstitute.DataSource = instituteManger.GetAllInstituteList();  // 绑定集合

            this.cboPost.DisplayMember = "NamePost";      // 显示的值
            this.cboPost.ValueMember = "IDPost";              // 注意这里，绑定实际的值
            this.cboPost.DataSource = postManger.GetAllPostList();  // 绑定集合

            // 绑定学院下拉列表数据
            this.cboAddInstitute.DisplayMember = "ShortNameInst";      // 显示的值
            this.cboAddInstitute.ValueMember = "IDInstitute";              // 注意这里，绑定实际的值
            this.cboAddInstitute.DataSource = instituteManger.GetAllInstituteList();  // 绑定集合

            this.cboAddPost.DisplayMember = "NamePost";      // 显示的值
            this.cboAddPost.ValueMember = "IDPost";              // 注意这里，绑定实际的值
            this.cboAddPost.DataSource = postManger.GetAllPostList();  // 绑定集合
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
            this.txtLogin.Text = this.txtPwd.Text = this.txtName.Text = this.txtPhone.Text = this.txtEmail.Text = "";
            this.cboAddInstitute.SelectedIndex = this.cboAddPost.SelectedIndex = 0;
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
            MODEL.tb_Staff staff = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Staff;

            // 将绑定项中的内容显示在修改窗口上
            this.txtLogin.Text = staff.Login;
            this.txtPwd.Text = staff.Passwd;
            this.txtName.Text = staff.NameStaff;

            rdoMam.Checked = staff.Gender;
            rdoWoman.Checked = !staff.Gender;

            this.dtpBirthday.Value = staff.Birthday;

            this.txtPhone.Text = staff.Phone.ToString();
            this.txtEmail.Text = staff.Email;

            this.dtpHiredate.Value = staff.Hiredate;

            this.cboAddPost.SelectedValue = this.cboPost.SelectedValue;
            this.cboAddInstitute.SelectedValue = this.cboInstitute.SelectedValue;
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
            newStaff.PostID = (this.cboAddPost.SelectedItem as MODEL.tb_Post).IDPost;
            newStaff.InstituteID = (this.cboAddInstitute.SelectedItem as MODEL.tb_Institute).IDInstitute;
            newStaff.Gender = this.rdoMam.Checked ? true : false;
            // ----------------------------------------------------------------------------------------------------------

            if (gpAdd.Text == "Добавление")
            {
                if (staffManger.InsertStaff(newStaff) != 1)
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
                if (staffManger.UpdateStaff(newStaff) != 1)
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
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
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

            if (cboAddPost.SelectedItem == null ||
                cboAddInstitute.SelectedItem == null)
            {
                MessageBox.Show("Please choose all items");

                return false;
            }

            return true;
        }
        #endregion

        private void btnShowAllStaff_Click(object sender, EventArgs e)
        {
            this.dgvList.DataSource = staffManger.GetAllStaffList();
        }

        private void btnSeachByInst_Click(object sender, EventArgs e)
        {
            if (cboInstitute.SelectedItem == null)
            {
                MessageBox.Show("Please chose a institute");
            }

            int idInst = (cboInstitute.SelectedItem as MODEL.tb_Institute).IDInstitute;

            List<MODEL.tb_Staff> allStaffList =  staffManger.GetAllStaffList();

            List<MODEL.tb_Staff> staffListByInst = new List<MODEL.tb_Staff>();
            foreach (MODEL.tb_Staff staff in allStaffList)
            {
                if (staff.InstituteID == idInst)
                {
                    staffListByInst.Add(staff);
                }
            }

            this.dgvList.DataSource = staffListByInst;
        }

        private void btnSeachByPost_Click(object sender, EventArgs e)
        {
            if (cboPost.SelectedItem == null)
            {
                MessageBox.Show("Please chose a post");
            }

            int idPost = (cboPost.SelectedItem as MODEL.tb_Post).IDPost;

            List<MODEL.tb_Staff> allStaffList = staffManger.GetAllStaffList();

            List<MODEL.tb_Staff> staffListByPost = new List<MODEL.tb_Staff>();
            foreach (MODEL.tb_Staff staff in allStaffList)
            {
                if (staff.PostID == idPost)
                {
                    staffListByPost.Add(staff);
                }
            }

            this.dgvList.DataSource = staffListByPost;
        }
    }
}
