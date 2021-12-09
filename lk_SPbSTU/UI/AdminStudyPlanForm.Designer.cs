namespace UI
{
    partial class AdminStudyPlanForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStudyPlanForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiAddInstitue = new System.Windows.Forms.ToolStripLabel();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripLabel();
            this.tsmiDelete = new System.Windows.Forms.ToolStripLabel();
            this.tsmiExit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDiscipline = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProfession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboInstitute = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddInstitue,
            this.tsmiUpdate,
            this.tsmiDelete,
            this.tsmiExit,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiAddInstitue
            // 
            this.tsmiAddInstitue.Name = "tsmiAddInstitue";
            this.tsmiAddInstitue.Size = new System.Drawing.Size(84, 22);
            this.tsmiAddInstitue.Text = "Добавление";
            this.tsmiAddInstitue.Click += new System.EventHandler(this.tsmiAddInstitue_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(78, 22);
            this.tsmiUpdate.Text = "Изменение";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(32, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(32, 22);
            this.tsmiExit.Text = "退出";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.NameGroup,
            this.Column2,
            this.Column4,
            this.Column3,
            this.NameStaff});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono NL Light", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Location = new System.Drawing.Point(16, 34);
            this.dgvList.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1229, 598);
            this.dgvList.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "IDStudyPlan";
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 41;
            // 
            // NameGroup
            // 
            this.NameGroup.DataPropertyName = "NameGroup";
            this.NameGroup.HeaderText = "Группа";
            this.NameGroup.MinimumWidth = 200;
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "NameDiscipline";
            this.Column2.FillWeight = 30.45833F;
            this.Column2.HeaderText = "Название дисциплины";
            this.Column2.MinimumWidth = 550;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 550;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "PeriodDiscipline";
            this.Column4.FillWeight = 30.66916F;
            this.Column4.HeaderText = "Всего, ч";
            this.Column4.MinimumWidth = 70;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "Semestr";
            this.Column3.FillWeight = 30.56631F;
            this.Column3.HeaderText = "Семестр";
            this.Column3.MinimumWidth = 70;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // NameStaff
            // 
            this.NameStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameStaff.DataPropertyName = "NameStaff";
            this.NameStaff.HeaderText = "Преподаватель";
            this.NameStaff.MinimumWidth = 150;
            this.NameStaff.Name = "NameStaff";
            // 
            // gpAdd
            // 
            this.gpAdd.BackColor = System.Drawing.Color.Linen;
            this.gpAdd.Controls.Add(this.cboStaff);
            this.gpAdd.Controls.Add(this.label5);
            this.gpAdd.Controls.Add(this.cboSemester);
            this.gpAdd.Controls.Add(this.label4);
            this.gpAdd.Controls.Add(this.cboDiscipline);
            this.gpAdd.Controls.Add(this.label3);
            this.gpAdd.Controls.Add(this.cboGroup);
            this.gpAdd.Controls.Add(this.label1);
            this.gpAdd.Controls.Add(this.cboProfession);
            this.gpAdd.Controls.Add(this.label2);
            this.gpAdd.Controls.Add(this.cboInstitute);
            this.gpAdd.Controls.Add(this.label9);
            this.gpAdd.Controls.Add(this.btnCancel);
            this.gpAdd.Controls.Add(this.btnOk);
            this.gpAdd.Location = new System.Drawing.Point(182, 90);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(900, 500);
            this.gpAdd.TabIndex = 19;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Добавление";
            this.gpAdd.Visible = false;
            // 
            // cboStaff
            // 
            this.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Location = new System.Drawing.Point(520, 304);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(310, 26);
            this.cboStaff.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Преподаватель";
            // 
            // cboSemester
            // 
            this.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboSemester.Location = new System.Drawing.Point(117, 304);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(260, 26);
            this.cboSemester.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Семестра";
            // 
            // cboDiscipline
            // 
            this.cboDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiscipline.FormattingEnabled = true;
            this.cboDiscipline.Location = new System.Drawing.Point(520, 216);
            this.cboDiscipline.Name = "cboDiscipline";
            this.cboDiscipline.Size = new System.Drawing.Size(310, 26);
            this.cboDiscipline.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Дисциплине";
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(117, 216);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(260, 26);
            this.cboGroup.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Группа";
            // 
            // cboProfession
            // 
            this.cboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfession.FormattingEnabled = true;
            this.cboProfession.Location = new System.Drawing.Point(117, 128);
            this.cboProfession.Name = "cboProfession";
            this.cboProfession.Size = new System.Drawing.Size(713, 26);
            this.cboProfession.TabIndex = 32;
            this.cboProfession.SelectedIndexChanged += new System.EventHandler(this.cboProfession_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Направление";
            // 
            // cboInstitute
            // 
            this.cboInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstitute.FormattingEnabled = true;
            this.cboInstitute.Location = new System.Drawing.Point(117, 51);
            this.cboInstitute.Name = "cboInstitute";
            this.cboInstitute.Size = new System.Drawing.Size(713, 26);
            this.cboInstitute.TabIndex = 21;
            this.cboInstitute.SelectedIndexChanged += new System.EventHandler(this.cboInstitute_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Институт";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(755, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(635, 434);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Insert";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AdminStudyPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gpAdd);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("JetBrains Mono NL Light", 10.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminStudyPlanForm";
            this.Text = "AdminStudyPlanForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminStudyPlanForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gpAdd.ResumeLayout(false);
            this.gpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsmiAddInstitue;
        private System.Windows.Forms.ToolStripLabel tsmiUpdate;
        private System.Windows.Forms.ToolStripLabel tsmiDelete;
        private System.Windows.Forms.ToolStripLabel tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStaff;
        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.ComboBox cboInstitute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProfession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDiscipline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.Label label4;
    }
}