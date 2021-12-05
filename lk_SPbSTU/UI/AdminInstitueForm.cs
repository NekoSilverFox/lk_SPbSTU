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
    public partial class AdminInstitueForm : Form
    {
        /// <summary>
        /// 全局的 Institute 表业务层处理对象
        /// </summary>
        BLL.InstituteManger instituteManger = new BLL.InstituteManger();


        public AdminInstitueForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载，显示 dgv 控件的显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminInstitueForm_Load(object sender, EventArgs e)
        {
            this.dgvList.DataSource = instituteManger.getAllInstituteList();
        }
    }
}
