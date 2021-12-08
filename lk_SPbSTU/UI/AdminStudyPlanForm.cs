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
    }
}
