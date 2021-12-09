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

        BLL.DisciplineManger disciplineManger = new BLL.DisciplineManger();

        BLL.StaffManger staffManger = new BLL.StaffManger();

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

            // 绑定学院下拉列表数据
            this.cboInstitute.DisplayMember = "NameInstitute";      // 显示的值
            this.cboInstitute.ValueMember = "IDInstitute";              // 注意这里，绑定实际的值
            this.cboInstitute.DataSource = instituteManger.GetAllInstituteList();  // 绑定集合

            // 绑定方向下拉列表数据
            this.cboProfession.DisplayMember = "NameProfession";
            this.cboProfession.ValueMember = "IDProfession";              // 注意这里，绑定实际的值
            //this.cboProfession.DataSource = professionManger.GetAllProfessionList();  // 绑定集合


            this.cboGroup.DisplayMember = "NameGroup";
            this.cboGroup.ValueMember = "IDGroup";

            this.cboDiscipline.DisplayMember = "NameDiscipline";
            this.cboDiscipline.ValueMember = "IDDiscipline";
            this.cboDiscipline.DataSource = disciplineManger.GetAllDisciplineList();

            this.cboStaff.DisplayMember = "NameStaff";
            this.cboStaff.ValueMember = "IDStaff";
            this.cboStaff.DataSource = staffManger.GetAllStaffList();
        }

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

        private void cboProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int professionID = (this.cboProfession.SelectedItem as MODEL.tb_Profession).IDProfession;

            // 【重点】先清空！！！
            //this.cboProfession.Items.Clear();

            List<MODEL.tb_Group> groupList = groupManger.GetAllGroupList();
            List<MODEL.tb_Group> showGroupList = new List<MODEL.tb_Group>();
            foreach (MODEL.tb_Group group in groupList)
            {
                if (group.IDProfession == professionID)
                {
                    showGroupList.Add(group);
                }
            }

            this.cboGroup.DataSource = showGroupList;
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
