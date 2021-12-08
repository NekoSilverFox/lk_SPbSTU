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
    public partial class AdminDisciplineForm : Form
    {
        /// <summary>
        /// 全局的 DisciplineManger 表业务层处理对象
        /// </summary>
        BLL.DisciplineManger disciplineManger = new BLL.DisciplineManger();

        public AdminDisciplineForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void AdminDisciplineForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = disciplineManger.GetAllDisciplineList();
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
    }
}
