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
    public partial class TeacherMarkForStudentForm : Form
    {
        BLL.StaffManger staffManger = new BLL.StaffManger();
        BLL.ExamRecordManger examRecordManger = new BLL.ExamRecordManger();
        BLL.StudyPlanManger studyPlanManger = new BLL.StudyPlanManger();
        BLL.StudentManger studentManger = new BLL.StudentManger();

        List<MODEL.tb_StudyPlan> allStudyPlan = new List<MODEL.tb_StudyPlan>();
        List<MODEL.tb_StudyPlan> studyPlanByStaffID = new List<MODEL.tb_StudyPlan>();


        public TeacherMarkForStudentForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void TeacherMarkForStudentForm_Load(object sender, EventArgs e)
        {
            // 获取这个员工的账号ID用于显示
            int accountID = MODEL.tb_Account.accountIDNow;
            MODEL.tb_Staff staff = new MODEL.tb_Staff();
            staff = staffManger.getStaffInfo(accountID);

            this.dgvList.DataSource = examRecordManger.GetExamRecordsByStaffID(staff.IDStaff);

            allStudyPlan = studyPlanManger.GetAllStudyPlanList();

            foreach (MODEL.tb_StudyPlan studyPlan in allStudyPlan)
            {
                if (studyPlan.StaffID == staff.IDStaff)
                {
                    studyPlanByStaffID.Add(studyPlan);
                }
            }
            this.cboStudyPlanID.DisplayMember = "IDStudyPlan";
            this.cboStudyPlanID.ValueMember = "IDStudyPlan";
            this.cboStudyPlanID.DataSource = studyPlanByStaffID;

            this.cboGroup.DisplayMember = "NameGroup";
            this.cboGroup.ValueMember = "IDGroup";
            this.cboGroup.DataSource = studyPlanByStaffID;

            this.cboDiscipline.DisplayMember = "NameDiscipline";
            this.cboDiscipline.ValueMember = "IDDiscipline";
            this.cboDiscipline.DataSource = studyPlanByStaffID;

            this.cboSemester.DisplayMember = "Semestr";
            this.cboSemester.ValueMember = "Semestr";
            this.cboSemester.DataSource = studyPlanByStaffID;
        }

        private void tsmiAddInstitue_Click(object sender, EventArgs e)
        {
            gpAdd.Visible = true;
            gpAdd.Text = "Добавление";
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroup.SelectedItem == null)
            {
                return;
            }

            List<MODEL.tb_Student> studentList = new List<MODEL.tb_Student>();

            int groupID = (this.cboGroup.SelectedItem as MODEL.tb_StudyPlan).IDGroup;

            this.cboStudent.DisplayMember = "NameStudent";
            this.cboStudent.ValueMember = "IDStudent";
            this.cboStudent.DataSource = studentManger.GetStudentListByGroupID(groupID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cboStudyPlanID.SelectedIndex = this.cboGroup.SelectedIndex = this.cboDiscipline.SelectedIndex = this.cboSemester.SelectedIndex = this.cboStudent.SelectedIndex =this.cboMark.SelectedIndex = 0;

            // 隐藏面板
            this.gpAdd.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidataUser())
            {
                return;
            }

            MODEL.tb_ExamRecord newExamRecord = null;

            if (gpAdd.Text == "Добавление")
            {
                newExamRecord = new MODEL.tb_ExamRecord();
            }
            else
            {
                newExamRecord = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_ExamRecord;
            }


            // ----------------------------------------------------------------------------------------------------------
            newExamRecord.StudyPlanID = (this.cboStudyPlanID.SelectedItem as MODEL.tb_StudyPlan).IDStudyPlan;
            newExamRecord.StudentID = (this.cboStudent.SelectedItem as MODEL.tb_Student).IDStudent;
            newExamRecord.Mark = this.cboMark.SelectedIndex + 2;
            // ----------------------------------------------------------------------------------------------------------

            // 获取这个员工的账号ID用于显示
            int accountID = MODEL.tb_Account.accountIDNow;
            MODEL.tb_Staff staff = new MODEL.tb_Staff();
            staff = staffManger.getStaffInfo(accountID);

            if (gpAdd.Text == "Добавление")
            {
                if (examRecordManger.InsertExamRecord(newExamRecord) == 1)
                {
                    MessageBox.Show("Successfully added new Exam Record");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = examRecordManger.GetExamRecordsByStaffID(staff.IDStaff);
                }
                else
                {
                    MessageBox.Show("Failed to add new Exam Record");
                }
            }
            else
            {
                if (examRecordManger.UpdateExamRecord(newExamRecord) == 1)
                {
                    MessageBox.Show("Successfully change Exam Record");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = examRecordManger.GetExamRecordsByStaffID(staff.IDStaff);
                }
                else
                {
                    MessageBox.Show("Failed to change Exam Record");
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
            if (cboStudyPlanID.SelectedItem == null ||
                cboGroup.SelectedItem == null ||
                cboDiscipline.SelectedItem == null ||
                cboSemester.SelectedItem == null ||
                cboStudent.SelectedItem == null ||
                cboMark.SelectedItem == null)
            {
                MessageBox.Show("Please choose all items");

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
            MODEL.tb_ExamRecord examRecord = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_ExamRecord;

            // 将绑定项中的内容显示在修改窗口上
            //this.cboInstitute.SelectedValue = 0;
            //this.cboProfession.SelectedValue = 0;
            this.cboStudyPlanID.SelectedValue = examRecord.StudyPlanID;
            //this.cboGroup.SelectedValue = examRecord.IdGroup;
            //this.cboSemester.SelectedValue = examRecord.Semester;
            //this.cboDiscipline.SelectedValue = examRecord.IdDiscipline;
            this.cboStudent.SelectedValue = examRecord.StudentID;
            this.cboMark.SelectedIndex = examRecord.Mark - 2;
        }
    }
}
