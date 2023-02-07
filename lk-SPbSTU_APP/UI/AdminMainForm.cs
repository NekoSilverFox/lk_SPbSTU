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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void tsmiMyInfo_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            LKStaffInfoForm lKStaffInfoForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["LKStaffInfoForm"] == null)
            {
                lKStaffInfoForm = new LKStaffInfoForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                lKStaffInfoForm.MdiParent = this;
                lKStaffInfoForm.Show();
            }
            else
            {
                Application.OpenForms["LKStaffInfoForm"].Show();
            }
        }

        private void tsmiInstitute_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            AdminInstitueForm adminInstitueForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["AdminInstitueForm"] == null)
            {
                adminInstitueForm = new AdminInstitueForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                adminInstitueForm.MdiParent = this;
                adminInstitueForm.Show();
            }
            else
            {
                Application.OpenForms["AdminInstitueForm"].Show();
            }
        }

        private void tsmiProfession_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            AdminProfessionForm adminProfessionForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["AdminProfessionForm"] == null)
            {
                adminProfessionForm = new AdminProfessionForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                adminProfessionForm.MdiParent = this;
                adminProfessionForm.Show();
            }
            else
            {
                Application.OpenForms["AdminProfessionForm"].Show();
            }
        }

        private void tsmiClass_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            AdminGroupForm adminGroupForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["AdminGroupForm"] == null)
            {
                adminGroupForm = new AdminGroupForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                adminGroupForm.MdiParent = this;
                adminGroupForm.Show();
            }
            else
            {
                Application.OpenForms["AdminGroupForm"].Show();
            }
        }

        private void tsmiDiscipline_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            AdminDisciplineForm adminDisciplineForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["AdminDisciplineForm"] == null)
            {
                adminDisciplineForm = new AdminDisciplineForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                adminDisciplineForm.MdiParent = this;
                adminDisciplineForm.Show();
            }
            else
            {
                Application.OpenForms["AdminDisciplineForm"].Show();
            }
        }

        private void tsmiStudyPlan_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            AdminStudyPlanForm studyPlanForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["AdminStudyPlanForm"] == null)
            {
                studyPlanForm = new AdminStudyPlanForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                studyPlanForm.MdiParent = this;
                studyPlanForm.Show();
            }
            else
            {
                Application.OpenForms["AdminStudyPlanForm"].Show();
            }
        }

        private void tsmiStaff_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            AdminStaffForm adminStaffForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["AdminStaffForm"] == null)
            {
                adminStaffForm = new AdminStaffForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                adminStaffForm.MdiParent = this;
                adminStaffForm.Show();
            }
            else
            {
                Application.OpenForms["AdminStaffForm"].Show();
            }
        }

        private void tmiStudent_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            AdminStudentForm adminStudentForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["AdminStudentForm"] == null)
            {
                adminStudentForm = new AdminStudentForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                adminStudentForm.MdiParent = this;
                adminStudentForm.Show();
            }
            else
            {
                Application.OpenForms["AdminStudentForm"].Show();
            }
        }
    }
}
