namespace UI
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiMyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInstitute = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfession = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiStudyPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMyInfo,
            this.tsmiInstitute,
            this.tsmiProfession,
            this.tsmiClass,
            this.tsmiStaff,
            this.tmiStudyPlan,
            this.tmiStudent,
            this.tsmiWindow,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.tsmiWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiMyInfo
            // 
            this.tsmiMyInfo.Name = "tsmiMyInfo";
            this.tsmiMyInfo.Size = new System.Drawing.Size(123, 21);
            this.tsmiMyInfo.Text = "Личный кабинет";
            this.tsmiMyInfo.Click += new System.EventHandler(this.tsmiMyInfo_Click);
            // 
            // tsmiInstitute
            // 
            this.tsmiInstitute.Name = "tsmiInstitute";
            this.tsmiInstitute.Size = new System.Drawing.Size(73, 21);
            this.tsmiInstitute.Text = "Институт";
            this.tsmiInstitute.Click += new System.EventHandler(this.tsmiInstitute_Click);
            // 
            // tsmiProfession
            // 
            this.tsmiProfession.Name = "tsmiProfession";
            this.tsmiProfession.Size = new System.Drawing.Size(68, 21);
            this.tsmiProfession.Text = "方向管理";
            this.tsmiProfession.Click += new System.EventHandler(this.tsmiProfession_Click);
            // 
            // tsmiStaff
            // 
            this.tsmiStaff.Name = "tsmiStaff";
            this.tsmiStaff.Size = new System.Drawing.Size(68, 21);
            this.tsmiStaff.Text = "员工管理";
            // 
            // tsmiClass
            // 
            this.tsmiClass.Name = "tsmiClass";
            this.tsmiClass.Size = new System.Drawing.Size(68, 21);
            this.tsmiClass.Text = "班级管理";
            this.tsmiClass.Click += new System.EventHandler(this.tsmiClass_Click);
            // 
            // tmiStudyPlan
            // 
            this.tmiStudyPlan.Name = "tmiStudyPlan";
            this.tmiStudyPlan.Size = new System.Drawing.Size(92, 21);
            this.tmiStudyPlan.Text = "学习计划管理";
            // 
            // tmiStudent
            // 
            this.tmiStudent.Name = "tmiStudent";
            this.tmiStudent.Size = new System.Drawing.Size(68, 21);
            this.tmiStudent.Text = "学生管理";
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(53, 21);
            this.tsmiWindow.Text = "Окно";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(58, 21);
            this.tsmiExit.Text = "Выйти";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiInstitute;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfession;
        private System.Windows.Forms.ToolStripMenuItem tsmiClass;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaff;
        private System.Windows.Forms.ToolStripMenuItem tmiStudyPlan;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMyInfo;
        private System.Windows.Forms.ToolStripMenuItem tmiStudent;
    }
}