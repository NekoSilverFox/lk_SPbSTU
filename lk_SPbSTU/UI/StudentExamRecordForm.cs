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
    public partial class StudentExamRecordForm : Form
    {
        /// <summary>
        /// 全局的 ExamRecordsManger 表业务层处理对象
        /// </summary>
        BLL.ExamRecordManger examRecordManger = new BLL.ExamRecordManger();


        public StudentExamRecordForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void StudentExamRecordForm_Load(object sender, EventArgs e)
        {
            // 获取这个学生的账号ID用于显示
            int accountID = MODEL.tb_Account.accountIDNow;

            // 从 Student 表中获取他的具体信息
            BLL.StudentManger studentManger = new BLL.StudentManger();
            MODEL.tb_Student student = studentManger.getStudentInfo(accountID);

            this.dgvList.DataSource = examRecordManger.GetExamRecordsByStudentID(student.IDStudent);
        }
    }
}
