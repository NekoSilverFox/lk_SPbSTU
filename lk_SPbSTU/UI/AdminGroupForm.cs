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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gpAdd.Visible = false;
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

        }
    }
}
