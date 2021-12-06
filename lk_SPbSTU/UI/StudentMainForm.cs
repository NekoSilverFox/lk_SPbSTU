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
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void tsmiMyInfo_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            LKStudentInfoForm lKStudentInfoForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["LKStudentInfoForm"] == null)
            {
                lKStudentInfoForm = new LKStudentInfoForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                lKStudentInfoForm.MdiParent = this;
                lKStudentInfoForm.Show();
            }
            else
            {
                Application.OpenForms["LKStudentInfoForm"].Show();
            }
        }

        private void tmiExamRecord_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            StudentExamRecordForm studentExamRecordForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["StudentExamRecordForm"] == null)
            {
                studentExamRecordForm = new StudentExamRecordForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                studentExamRecordForm.MdiParent = this;
                studentExamRecordForm.Show();
            }
            else
            {
                Application.OpenForms["StudentExamRecordForm"].Show();
            }
        }

        private void tmiStudyPlan_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            StudentStudyPlanForm studentStudyPlanForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["StudentStudyPlanForm"] == null)
            {
                studentStudyPlanForm = new StudentStudyPlanForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                studentStudyPlanForm.MdiParent = this;
                studentStudyPlanForm.Show();
            }
            else
            {
                Application.OpenForms["StudentStudyPlanForm"].Show();
            }
        }

        private void tmiMyTeacher_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            StudentMyTeacherForm studentMyTeacherForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["StudentMyTeacherForm"] == null)
            {
                studentMyTeacherForm = new StudentMyTeacherForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                studentMyTeacherForm.MdiParent = this;
                studentMyTeacherForm.Show();
            }
            else
            {
                Application.OpenForms["StudentMyTeacherForm"].Show();
            }
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
