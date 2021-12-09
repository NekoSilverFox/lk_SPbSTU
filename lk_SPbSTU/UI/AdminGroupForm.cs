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
    public partial class AdminGroupForm : Form
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

        /// <summary>
        /// 全局的 professionManger 表业务层处理对象
        /// </summary>
        BLL.GroupManger groupManger = new BLL.GroupManger();

        public AdminGroupForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;

            // 绑定学院下拉列表数据
            this.cboInstitute.DisplayMember = "NameInstitute";      // 显示的值
            this.cboInstitute.ValueMember = "IDInstitute";              // 注意这里，绑定实际的值
            this.cboInstitute.DataSource = instituteManger.GetAllInstituteList();  // 绑定集合

            // 绑定方向下拉列表数据
            this.cboProfession.DisplayMember = "NameProfession";
            this.cboProfession.ValueMember = "IDProfession";              // 注意这里，绑定实际的值
            //this.cboProfession.DataSource = professionManger.GetAllProfessionList();  // 绑定集合
        }

        private void AdminGroupForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = groupManger.GetAllGroupList();
            this.cboInstitute.SelectedIndex = 0;
        }

        private void cboProfession_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        // 当下拉列表选项发生改变时，触发事件
        private void cboInstitute_SelectedIndexChanged(object sender, EventArgs e)
        {
            int instutiteID = (this.cboInstitute.SelectedItem as MODEL.tb_Institute).IDInstitute;

            // 【重点】先清空！！！
            //this.cboProfession.Items.Clear();

            List<MODEL.tb_Profession> professionsList = professionManger.GetAllProfessionList();
            List<MODEL.tb_Profession> showProfessionsList = new List<MODEL.tb_Profession>();
            foreach (MODEL.tb_Profession profession in professionsList)
            {
                if (profession.InstituteID == instutiteID)
                {
                    showProfessionsList.Add(profession);
                }
            }

            this.cboProfession.DataSource = showProfessionsList;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidataUser())
            {
                return;
            }

            MODEL.tb_Group newGroup = null;

            if (gpAdd.Text == "Добавление")
            {
                newGroup = new MODEL.tb_Group();
            }
            else
            {
                newGroup = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Group;
            }

            // ----------------------------------------------------------------------------------------------------------
            newGroup.NameGroup = this.txtNameGroup.Text.ToString().Trim();
            newGroup.ProfessionID = (this.cboProfession.SelectedItem as MODEL.tb_Profession).IDProfession;
            newGroup.Grade = Convert.ToInt32(this.txtGrade.Text.ToString().Trim());
            newGroup.Quantity = Convert.ToInt32(this.txtNumStu.Text.ToString().Trim());
            // ----------------------------------------------------------------------------------------------------------

            if (gpAdd.Text == "Добавление")
            {
                if (groupManger.InsertGroup(newGroup) == 1)
                {
                    MessageBox.Show("Successfully added new group");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = groupManger.GetAllGroupList();
                }
                else
                {
                    MessageBox.Show("Failed to add new group");
                }
            }
            else
            {
                if (groupManger.UpdateGroup(newGroup) == 1)
                {
                    MessageBox.Show("Successfully change group");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = groupManger.GetAllGroupList();
                }
                else
                {
                    MessageBox.Show("Failed to change group");
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
            if (string.IsNullOrEmpty(this.txtNameGroup.Text.Trim()))
            {
                MessageBox.Show("Please enter a legal group name");

                // 【重点】定位光标
                txtNameGroup.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtGrade.Text.Trim()) || Regex.IsMatch(txtGrade.Text.Trim(), @"\D"))
            {
                MessageBox.Show("Please enter a legal grade like `2019`");

                // 【重点】定位光标
                txtGrade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtNumStu.Text.Trim()) || Regex.IsMatch(txtNumStu.Text.Trim(), @"\D"))
            {
                MessageBox.Show("Please enter a legal number student");

                // 【重点】定位光标
                txtNumStu.Focus();
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
            MODEL.tb_Group group = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Group;

            // 将绑定项中的内容显示在修改窗口上
            this.txtNameGroup.Text = group.NameGroup;
            this.cboInstitute.SelectedValue = group.IDInstitute;
            this.cboProfession.SelectedValue = group.ProfessionID;
            this.txtGrade.Text = group.Grade.ToString();
            this.txtNumStu.Text = group.Quantity.ToString();
        }
    }
}
