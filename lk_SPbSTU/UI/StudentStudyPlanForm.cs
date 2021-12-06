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
    public partial class StudentStudyPlanForm : Form
    {
        public StudentStudyPlanForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void StudentStudyPlanForm_Load(object sender, EventArgs e)
        {
            // 获取这个学生的账号ID用于显示
            int accountID = MODEL.tb_Account.accountIDNow;

            // 从 Student 表中获取他的具体信息
            BLL.StudyPlanManger studyPlanManger = new BLL.StudyPlanManger();
            this.dgvList.DataSource = studyPlanManger.GetStudentStudyPlanByAccountID(accountID);
        }
    }
}
