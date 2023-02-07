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
    public partial class AdminProfessionForm : Form
    {
        /// <summary>
        /// 全局的 Institute 表业务层处理对象
        /// 用于加载下拉列表中的内容！！！
        /// </summary>
        BLL.InstituteManger instituteManger = new BLL.InstituteManger();

        /// <summary>
        /// 全局的 professionManger 表业务层处理对象
        /// </summary>
        BLL.ProfessionManger professionManger = new BLL.ProfessionManger();

        public AdminProfessionForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;

            // 绑定学院下拉列表数据
            this.cboInstitute.DisplayMember = "NameInstitute";      // 显示的值
            this.cboInstitute.ValueMember = "IDInstitute";              // 注意这里，绑定实际的值
            this.cboInstitute.DataSource = instituteManger.GetAllInstituteList();  // 绑定集合
        }

        private void AdminProfessionForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = professionManger.GetAllProfessionList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidataUser())
            {
                return;
            }

            MODEL.tb_Profession newProfession = new MODEL.tb_Profession();

            if (gpAdd.Text == "Добавление")
            {
                newProfession = new MODEL.tb_Profession();
            }
            else
            {
                newProfession = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Profession;
            }

            // ----------------------------------------------------------------------------------------------------------
            newProfession.InstituteID = (this.cboInstitute.SelectedItem as MODEL.tb_Institute).IDInstitute;
            newProfession.CodeProfession = this.txtCodeProfession.Text.ToString().Trim();
            newProfession.NameProfession = this.txtNameProfession.Text.ToString().Trim();
            newProfession.TuitionFee = Convert.ToDecimal(this.txtTuitionFee.Text.ToString().Trim());
            // ----------------------------------------------------------------------------------------------------------

            if (gpAdd.Text == "Добавление")
            {
                if (professionManger.InsertProfession(newProfession) != 0)
                {
                    MessageBox.Show("Successfully added new Profession");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = professionManger.GetAllProfessionList();
                }
                else
                {
                    MessageBox.Show("Failed to add new Profession");
                }
            }
            else
            {
                if (professionManger.UpdateProfession(newProfession) != 0)
                {
                    MessageBox.Show("Successfully change Profession");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = professionManger.GetAllProfessionList();
                }
                else
                {
                    MessageBox.Show("Failed to change Profession");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gpAdd.Visible = false;
            this.txtNameProfession.Text = this.txtCodeProfession.Text = this.txtTuitionFee.Text = "";
            this.cboInstitute.SelectedIndex = 0;
        }

        private void tsmiAddInstitue_Click(object sender, EventArgs e)
        {
            gpAdd.Visible = true;
            gpAdd.Text = "Добавление";
        }

        #region 用户信息输入检测+bool ValidataUser()
        /// <summary>
        /// 用户信息输入检测
        /// </summary>
        /// <returns></returns>
        bool ValidataUser()
        {
            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtNameProfession.Text.Trim()))
            {
                MessageBox.Show("Please enter a legal name profession");

                // 【重点】定位光标
                txtNameProfession.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtCodeProfession.Text.Trim()))
            {
                MessageBox.Show("Code profession can not be empty");

                // 【重点】定位光标
                txtCodeProfession.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtTuitionFee.Text.Trim()) || Regex.IsMatch(txtTuitionFee.Text.Trim(), @"\D"))
            {
                MessageBox.Show("Please enter a legal tuition fee");

                // 【重点】定位光标
                txtTuitionFee.Focus();
                return false;
            }

            return true;
        }
        #endregion

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvList.SelectedRows.Count == 0)
            {
                return;
            }
            gpAdd.Visible = true;
            gpAdd.Text = "Изменение";

            // 获取绑定项
            MODEL.tb_Profession profession  = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Profession;

            // 将绑定项中的内容显示在修改窗口上
            this.txtNameProfession.Text = profession.NameProfession;
            this.cboInstitute.SelectedValue = profession.InstituteID;
            this.txtCodeProfession.Text = profession.CodeProfession;
            this.txtTuitionFee.Text = profession.TuitionFee.ToString();
        }
    }
}
