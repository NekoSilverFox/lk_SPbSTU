namespace UI
{
    partial class StudentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiMyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiStudyPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiExamRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiMyTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMyInfo,
            this.tmiStudyPlan,
            this.tmiExamRecord,
            this.tmiMyTeacher,
            this.tsmiWindow,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.tsmiWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiMyInfo
            // 
            this.tsmiMyInfo.Name = "tsmiMyInfo";
            this.tsmiMyInfo.Size = new System.Drawing.Size(123, 21);
            this.tsmiMyInfo.Text = "Личный кабинет";
            this.tsmiMyInfo.Click += new System.EventHandler(this.tsmiMyInfo_Click);
            // 
            // tmiStudyPlan
            // 
            this.tmiStudyPlan.Name = "tmiStudyPlan";
            this.tmiStudyPlan.Size = new System.Drawing.Size(108, 21);
            this.tmiStudyPlan.Text = "Учебный план";
            this.tmiStudyPlan.Click += new System.EventHandler(this.tmiStudyPlan_Click);
            // 
            // tmiExamRecord
            // 
            this.tmiExamRecord.Name = "tmiExamRecord";
            this.tmiExamRecord.Size = new System.Drawing.Size(126, 21);
            this.tmiExamRecord.Text = "Зачетная книжка";
            this.tmiExamRecord.Click += new System.EventHandler(this.tmiExamRecord_Click);
            // 
            // tmiMyTeacher
            // 
            this.tmiMyTeacher.Name = "tmiMyTeacher";
            this.tmiMyTeacher.Size = new System.Drawing.Size(145, 21);
            this.tmiMyTeacher.Text = "Мой преподаватель";
            this.tmiMyTeacher.Click += new System.EventHandler(this.tmiMyTeacher_Click);
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
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMyInfo;
        private System.Windows.Forms.ToolStripMenuItem tmiStudyPlan;
        private System.Windows.Forms.ToolStripMenuItem tmiExamRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tmiMyTeacher;
    }
}