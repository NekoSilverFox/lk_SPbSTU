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
    public partial class TeacherMainForm : Form
    {
        public TeacherMainForm()
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

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {

        }

        private void tsmiDiscipline_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            TeacherGetStudentExamBoardByNameForm teacherGetStudentExamBoardByNameForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["TeacherGetStudentExamBoardByNameForm"] == null)
            {
                teacherGetStudentExamBoardByNameForm = new TeacherGetStudentExamBoardByNameForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                teacherGetStudentExamBoardByNameForm.MdiParent = this;
                teacherGetStudentExamBoardByNameForm.Show();
            }
            else
            {
                Application.OpenForms["TeacherGetStudentExamBoardByNameForm"].Show();
            }
        }

        private void tmiStudent_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            TeacherWithHisGroupAndStudentForm teacherWithHisGroupAndStudentForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["TeacherWithHisGroupAndStudentForm"] == null)
            {
                teacherWithHisGroupAndStudentForm = new TeacherWithHisGroupAndStudentForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                teacherWithHisGroupAndStudentForm.MdiParent = this;
                teacherWithHisGroupAndStudentForm.Show();
            }
            else
            {
                Application.OpenForms["TeacherWithHisGroupAndStudentForm"].Show();
            }
        }

        private void tsmiMarkForStudent_Click(object sender, EventArgs e)
        {
            // 使用另一种方式打开唯一的窗体
            TeacherMarkForStudentForm teacherMarkForStudentForm = null;

            // 所有生成的窗体都保存在了系统的 `Application` 中，可以通过使用 `Application.OpenForms["窗体名"]` 来调用
            if (Application.OpenForms["TeacherMarkForStudentForm"] == null)
            {
                teacherMarkForStudentForm = new TeacherMarkForStudentForm();

                // 【重点】这里是首次打开此窗体，所以要设置 MDI 父窗体
                teacherMarkForStudentForm.MdiParent = this;
                teacherMarkForStudentForm.Show();
            }
            else
            {
                Application.OpenForms["TeacherMarkForStudentForm"].Show();
            }
        }
    }
}
