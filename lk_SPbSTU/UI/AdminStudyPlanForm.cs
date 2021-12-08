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
    public partial class AdminStudyPlanForm : Form
    {
        BLL.StudyPlanManger studyPlanManger = new BLL.StudyPlanManger();

        public AdminStudyPlanForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void AdminStudyPlanForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = studyPlanManger.GetAllStudyPlanList();
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

            MODEL.tb_StudyPlan newStudyPlan = null;

            if (gpAdd.Text == "Добавление")
            {
                newStudyPlan = new MODEL.tb_StudyPlan();
            }
            else
            {
                newStudyPlan = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_StudyPlan;
            }


            // ----------------------------------------------------------------------------------------------------------
            newStudyPlan.GroupID = (this.cboGroup.SelectedItem as MODEL.tb_Group).IDGroup;
            newStudyPlan.DisciplineID = (this.cboDiscipline.SelectedItem as MODEL.tb_Discipline).IDDiscipline;
            newStudyPlan.Semestr = this.cboSemester.SelectedIndex + 1;
            newStudyPlan.StaffID = (this.cboStaff.SelectedItem as MODEL.tb_Staff).IDStaff;
            // ----------------------------------------------------------------------------------------------------------


            if (gpAdd.Text == "Добавление")
            {
                if (studyPlanManger.InsertStudyPlan(newStudyPlan) == 1)
                {
                    MessageBox.Show("Successfully added new Study Plan");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = studyPlanManger.GetAllStudyPlanList();
                }
                else
                {
                    MessageBox.Show("Failed to add new group");
                }
            }
            else
            {
                if (studyPlanManger.UpdateStudyPlan(newStudyPlan) == 1)
                {
                    MessageBox.Show("Successfully change Study Plan");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = studyPlanManger.GetAllStudyPlanList();
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
            if (cboInstitute.SelectedItem == null ||
                cboProfession.SelectedItem == null ||
                cboGroup.SelectedItem == null ||
                cboDiscipline.SelectedItem == null ||
                cboSemester.SelectedItem == null ||
                cboStaff.SelectedItem == null )
            {
                MessageBox.Show("Please choose all items");

                return false;
            }


            return true;
        }
        #endregion

    }

}
