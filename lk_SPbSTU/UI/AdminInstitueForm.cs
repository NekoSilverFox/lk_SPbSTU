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
    public partial class AdminInstitueForm : Form
    {
        /// <summary>
        /// 全局的 Institute 表业务层处理对象
        /// </summary>
        BLL.InstituteManger instituteManger = new BLL.InstituteManger();


        public AdminInstitueForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 窗体加载，显示 dgv 控件的显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminInstitueForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = instituteManger.GetAllInstituteList();
        }

        private void gpAdd_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidataUser())
            {
                return;
            }

            MODEL.tb_Institute newInstitute = new MODEL.tb_Institute();

            if (gpAdd.Text == "Добавление")
            {
                newInstitute = new MODEL.tb_Institute();
            }
            else
            {
                newInstitute = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Institute;
            }

            // ----------------------------------------------------------------------------------------------------------
            /*
             一般有 2 种方式取出下拉列表中存储的 ID号：
                1. 通过 SelectedValue，前提是你之前设置了 ValueMember 值
                2. 可以通过绑定项（SelectItem）
                    如果数据源是表，那么 SelectedItem 就是 DataRowView，
                    如果数据源是集合，那么 SelectedItem 就是对象
             */
            newInstitute.NameInstitute = this.txtNameInst.Text.Trim();
            newInstitute.ShortNameInst = this.txtShortNameInst.Text.Trim();
            newInstitute.Email = this.txtEmail.Text.Trim();
            newInstitute.Phone = this.txtPhone.Text.Trim();
            newInstitute.Website = this.txtWebsite.Text.Trim();
            newInstitute.DetAddress = this.txtAdress.Text.Trim();
            // ----------------------------------------------------------------------------------------------------------

            if (gpAdd.Text == "Добавление")
            {
                if (instituteManger.InsertInstitute(newInstitute) != 0)
                {
                    MessageBox.Show("Successfully added new institute");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = instituteManger.GetAllInstituteList();
                }
                else
                {
                    MessageBox.Show("Failed to add new institute");
                }
            }
            else
            {
                if (instituteManger.UpdateInstitute(newInstitute) != 0)
                {
                    MessageBox.Show("Successfully change institute");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = instituteManger.GetAllInstituteList();
                }
                else
                {
                    MessageBox.Show("Failed to change institute");
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
            if (string.IsNullOrEmpty(this.txtNameInst.Text.Trim()) || Regex.IsMatch(txtNameInst.Text.Trim(), @"\W"))
            {
                MessageBox.Show("Please enter a legal institute name string");

                // 【重点】定位光标
                txtNameInst.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtShortNameInst.Text.Trim()) || Regex.IsMatch(txtShortNameInst.Text.Trim(), @"\W"))
            {
                MessageBox.Show("Please enter a legal institute short name string");

                // 【重点】定位光标
                txtShortNameInst.Focus();
                return false;
            }

            // 填了邮箱就判断邮箱格式是否正确
            if (!string.IsNullOrEmpty(this.txtEmail.Text.Trim()))
            {
                if (!Regex.IsMatch(this.txtEmail.Text.Trim(), @"\w+[@]\w+[.]\w+"))
                {
                    MessageBox.Show("Please enter a legitimate email address");
                    txtEmail.Focus();
                    return false;
                }
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtPhone.Text.Trim()) || !Regex.IsMatch(txtPhone.Text.Trim(), @"\d"))
            {
                MessageBox.Show("Please enter a legitimate phone number");

                // 【重点】定位光标
                txtPhone.Focus();
                return false;
            }



            return true;
        }
        #endregion

        private void tsmiAddInstitue_Click(object sender, EventArgs e)
        {
            gpAdd.Visible = true;
            gpAdd.Text = "Добавление";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.gpAdd.Visible = false;
            txtNameInst.Text = txtShortNameInst.Text = txtPhone.Text = txtEmail.Text = txtWebsite.Text = txtAdress.Text = "";

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
            MODEL.tb_Institute institute = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Institute;

            // 将绑定项中的内容显示在修改窗口上
            txtNameInst.Text = institute.NameInstitute;
            txtShortNameInst.Text = institute.ShortNameInst;
            txtPhone.Text = institute.Phone;
            txtEmail.Text = institute.Email;
            txtWebsite.Text = institute.Website;
            txtAdress.Text = institute.DetAddress;
        }
    }
}
