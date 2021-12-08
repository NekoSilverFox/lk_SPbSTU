namespace UI
{
    partial class AdminGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGroupForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiAddInstitue = new System.Windows.Forms.ToolStripLabel();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripLabel();
            this.tsmiDelete = new System.Windows.Forms.ToolStripLabel();
            this.tsmiExit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.cboProfession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboInstitute = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumStu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameProfession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.toolStrip1.TabIndex = 3;
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
            this.tsmiUpdate.Size = new System.Drawing.Size(32, 22);
            this.tsmiUpdate.Text = "修改";
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
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono NL Light", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Location = new System.Drawing.Point(15, 31);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1235, 619);
            this.dgvList.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "IDGroup";
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Width = 41;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "ShortNameInst";
            this.Column2.FillWeight = 30.45833F;
            this.Column2.HeaderText = "Институт";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "CodeProfession";
            this.Column3.FillWeight = 30.56631F;
            this.Column3.HeaderText = "Код направления";
            this.Column3.MinimumWidth = 30;
            this.Column3.Name = "Column3";
            this.Column3.Width = 111;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "NameProfession";
            this.Column4.FillWeight = 30.66916F;
            this.Column4.HeaderText = "Название направления";
            this.Column4.MinimumWidth = 600;
            this.Column4.Name = "Column4";
            this.Column4.Width = 600;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "NameGroup";
            this.Column5.HeaderText = "Группа";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "Grade";
            this.Column6.HeaderText = "Курс";
            this.Column6.Name = "Column6";
            this.Column6.Width = 53;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Quantity";
            this.Column7.HeaderText = "Кол-во студентов";
            this.Column7.Name = "Column7";
            // 
            // gpAdd
            // 
            this.gpAdd.BackColor = System.Drawing.Color.Linen;
            this.gpAdd.Controls.Add(this.cboProfession);
            this.gpAdd.Controls.Add(this.label2);
            this.gpAdd.Controls.Add(this.cboInstitute);
            this.gpAdd.Controls.Add(this.label9);
            this.gpAdd.Controls.Add(this.txtNumStu);
            this.gpAdd.Controls.Add(this.label1);
            this.gpAdd.Controls.Add(this.btnCancel);
            this.gpAdd.Controls.Add(this.btnOk);
            this.gpAdd.Controls.Add(this.txtGrade);
            this.gpAdd.Controls.Add(this.label4);
            this.gpAdd.Controls.Add(this.txtNameProfession);
            this.gpAdd.Controls.Add(this.label3);
            this.gpAdd.Location = new System.Drawing.Point(182, 90);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(900, 500);
            this.gpAdd.TabIndex = 17;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Добавление";
            this.gpAdd.Visible = false;
            // 
            // cboProfession
            // 
            this.cboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfession.FormattingEnabled = true;
            this.cboProfession.Location = new System.Drawing.Point(117, 260);
            this.cboProfession.Name = "cboProfession";
            this.cboProfession.Size = new System.Drawing.Size(713, 26);
            this.cboProfession.TabIndex = 23;
            this.cboProfession.SelectedIndexChanged += new System.EventHandler(this.cboProfession_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Направление";
            // 
            // cboInstitute
            // 
            this.cboInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstitute.FormattingEnabled = true;
            this.cboInstitute.Location = new System.Drawing.Point(117, 168);
            this.cboInstitute.Name = "cboInstitute";
            this.cboInstitute.Size = new System.Drawing.Size(713, 26);
            this.cboInstitute.TabIndex = 21;
            this.cboInstitute.SelectedIndexChanged += new System.EventHandler(this.cboInstitute_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Институт";
            // 
            // txtNumStu
            // 
            this.txtNumStu.Location = new System.Drawing.Point(625, 340);
            this.txtNumStu.Name = "txtNumStu";
            this.txtNumStu.Size = new System.Drawing.Size(205, 26);
            this.txtNumStu.TabIndex = 19;
            this.txtNumStu.Text = "40";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Количество студентов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(117, 340);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(205, 26);
            this.txtGrade.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Курс";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNameProfession
            // 
            this.txtNameProfession.Location = new System.Drawing.Point(117, 77);
            this.txtNameProfession.Name = "txtNameProfession";
            this.txtNameProfession.Size = new System.Drawing.Size(713, 26);
            this.txtNameProfession.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название";
            // 
            // AdminGroupForm
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
            this.Name = "AdminGroupForm";
            this.Text = "AdminGroupForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminGroupForm_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.ComboBox cboProfession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboInstitute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumStu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameProfession;
        private System.Windows.Forms.Label label3;
    }
}