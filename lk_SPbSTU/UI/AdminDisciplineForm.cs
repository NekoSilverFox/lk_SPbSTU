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
    public partial class AdminDisciplineForm : Form
    {
        /// <summary>
        /// 全局的 DisciplineManger 表业务层处理对象
        /// </summary>
        BLL.DisciplineManger disciplineManger = new BLL.DisciplineManger();

        public AdminDisciplineForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void AdminDisciplineForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = disciplineManger.GetAllDisciplineList();
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

            MODEL.tb_Discipline newDiscipline = null;

            if (gpAdd.Text == "Добавление")
            {
                newDiscipline = new MODEL.tb_Discipline();
            }
            else
            {
                newDiscipline = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Discipline;
            }

            // ----------------------------------------------------------------------------------------------------------
            newDiscipline.NameDiscipline = this.txtNameDiscipline.Text.ToString().Trim();
            newDiscipline.PeriodDiscipline = Convert.ToInt32(this.txtPeriodDiscipline.Text.ToString().Trim());
            newDiscipline.DescriptionDiscipline = this.txtDescriptionDiscipline.Text.ToString().Trim();
            // ----------------------------------------------------------------------------------------------------------

            if (gpAdd.Text == "Добавление")
            {
                if (disciplineManger.InsertDiscipline(newDiscipline) == 1)
                {
                    MessageBox.Show("Successfully added new Discipline");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = disciplineManger.GetAllDisciplineList();
                }
                else
                {
                    MessageBox.Show("Failed to add new Discipline");
                }
            }
            else
            {
                if (disciplineManger.UpdateDiscipline(newDiscipline) == 1)
                {
                    MessageBox.Show("Successfully change Discipline");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = disciplineManger.GetAllDisciplineList();
                }
                else
                {
                    MessageBox.Show("Failed to change Discipline");
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
            if (string.IsNullOrEmpty(this.txtNameDiscipline.Text.Trim()))
            {
                MessageBox.Show("Please enter a legal name discipline");

                // 【重点】定位光标
                txtNameDiscipline.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtDescriptionDiscipline.Text.Trim()))
            {
                MessageBox.Show("Please enter a legal description discipline");

                // 【重点】定位光标
                txtDescriptionDiscipline.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtPeriodDiscipline.Text.Trim()) || Regex.IsMatch(txtPeriodDiscipline.Text.Trim(), @"\D"))
            {
                MessageBox.Show("Please enter a legal period discipline");

                // 【重点】定位光标
                txtPeriodDiscipline.Focus();
                return false;
            }

            return true;
        }
        #endregion
    }
}
