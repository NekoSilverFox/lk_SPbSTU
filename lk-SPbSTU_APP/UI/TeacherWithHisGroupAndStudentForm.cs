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
    public partial class TeacherWithHisGroupAndStudentForm : Form
    {
        BLL.StudentManger studentManger = new BLL.StudentManger();
        BLL.StaffManger staffManger = new BLL.StaffManger();

        public TeacherWithHisGroupAndStudentForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void TeacherWithHisGroupAndStudentForm_Load(object sender, EventArgs e)
        {
            // 获取这个员工的账号ID用于显示
            int accountID = MODEL.tb_Account.accountIDNow;
            MODEL.tb_Staff staff = new MODEL.tb_Staff();
            staff = staffManger.getStaffInfo(accountID);

            this.dgvList.DataSource = studentManger.GetStudentListByStaffID(staff.IDStaff);
        }
    }
}
