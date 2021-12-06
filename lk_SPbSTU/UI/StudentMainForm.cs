﻿using System;
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
    }
}
