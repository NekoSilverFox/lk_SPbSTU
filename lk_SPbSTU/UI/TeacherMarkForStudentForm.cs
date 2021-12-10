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
        }
    }
}
