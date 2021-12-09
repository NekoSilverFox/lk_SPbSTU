namespace UI
{
    partial class TeacherMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiMyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiscipline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudyPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMyInfo,
            this.tmiStudent,
            this.tsmiClass,
            this.tsmiDiscipline,
            this.tsmiStudyPlan,
            this.tsmiStaff,
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
            // tsmiClass
            // 
            this.tsmiClass.Name = "tsmiClass";
            this.tsmiClass.Size = new System.Drawing.Size(63, 21);
            this.tsmiClass.Text = "Группа";
            // 
            // tsmiDiscipline
            // 
            this.tsmiDiscipline.Name = "tsmiDiscipline";
            this.tsmiDiscipline.Size = new System.Drawing.Size(97, 21);
            this.tsmiDiscipline.Text = "Дисциплине";
            // 
            // tsmiStudyPlan
            // 
            this.tsmiStudyPlan.Name = "tsmiStudyPlan";
            this.tsmiStudyPlan.Size = new System.Drawing.Size(108, 21);
            this.tsmiStudyPlan.Text = "Учебный план";
            // 
            // tmiStudent
            // 
            this.tmiStudent.Name = "tmiStudent";
            this.tmiStudent.Size = new System.Drawing.Size(66, 21);
            this.tmiStudent.Text = "Студент";
            // 
            // tsmiStaff
            // 
            this.tsmiStaff.Name = "tsmiStaff";
            this.tsmiStaff.Size = new System.Drawing.Size(78, 21);
            this.tsmiStaff.Text = "Работник";
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
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "TeacherMainForm";
            this.Text = "TeacherMainForm";
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMyInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiClass;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiscipline;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudyPlan;
        private System.Windows.Forms.ToolStripMenuItem tmiStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}