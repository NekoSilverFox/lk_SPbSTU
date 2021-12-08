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
    public partial class AdminStaffForm : Form
    {
        BLL.StaffManger staffManger = new BLL.StaffManger();

        public AdminStaffForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void AdminStaffForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = staffManger.GetAllStaffList();
        }
    }
}
