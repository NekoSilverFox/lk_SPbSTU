namespace UI
{
    partial class AdminDisciplineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDisciplineForm));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiAddInstitue = new System.Windows.Forms.ToolStripLabel();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripLabel();
            this.tsmiDelete = new System.Windows.Forms.ToolStripLabel();
            this.tsmiExit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.txtDescriptionDiscipline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPeriodDiscipline = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameDiscipline = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
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
            this.dgvList.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "IDDiscipline";
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Width = 41;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "NameDiscipline";
            this.Column4.FillWeight = 30.66916F;
            this.Column4.HeaderText = "Название дисциплины";
            this.Column4.MinimumWidth = 600;
            this.Column4.Name = "Column4";
            this.Column4.Width = 600;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "PeriodDiscipline";
            this.Column5.HeaderText = "Учебный час";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "DescriptionDiscipline";
            this.Column7.HeaderText = "Описание";
            this.Column7.Name = "Column7";
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
            this.toolStrip1.TabIndex = 18;
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
            // gpAdd
            // 
            this.gpAdd.BackColor = System.Drawing.Color.Linen;
            this.gpAdd.Controls.Add(this.txtDescriptionDiscipline);
            this.gpAdd.Controls.Add(this.label1);
            this.gpAdd.Controls.Add(this.btnCancel);
            this.gpAdd.Controls.Add(this.btnOk);
            this.gpAdd.Controls.Add(this.txtPeriodDiscipline);
            this.gpAdd.Controls.Add(this.label4);
            this.gpAdd.Controls.Add(this.txtNameDiscipline);
            this.gpAdd.Controls.Add(this.label3);
            this.gpAdd.Location = new System.Drawing.Point(182, 90);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(900, 500);
            this.gpAdd.TabIndex = 19;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Добавление";
            this.gpAdd.Visible = false;
            // 
            // txtDescriptionDiscipline
            // 
            this.txtDescriptionDiscipline.Location = new System.Drawing.Point(117, 278);
            this.txtDescriptionDiscipline.Multiline = true;
            this.txtDescriptionDiscipline.Name = "txtDescriptionDiscipline";
            this.txtDescriptionDiscipline.Size = new System.Drawing.Size(713, 102);
            this.txtDescriptionDiscipline.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Описание";
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
            // txtPeriodDiscipline
            // 
            this.txtPeriodDiscipline.Location = new System.Drawing.Point(117, 193);
            this.txtPeriodDiscipline.Name = "txtPeriodDiscipline";
            this.txtPeriodDiscipline.Size = new System.Drawing.Size(326, 26);
            this.txtPeriodDiscipline.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Учебный час";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNameDiscipline
            // 
            this.txtNameDiscipline.Location = new System.Drawing.Point(117, 39);
            this.txtNameDiscipline.Multiline = true;
            this.txtNameDiscipline.Name = "txtNameDiscipline";
            this.txtNameDiscipline.Size = new System.Drawing.Size(713, 77);
            this.txtNameDiscipline.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название";
            // 
            // AdminDisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gpAdd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvList);
            this.Font = new System.Drawing.Font("JetBrains Mono NL Light", 10.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDisciplineForm";
            this.Text = "AdminDisciplineForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDisciplineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpAdd.ResumeLayout(false);
            this.gpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsmiAddInstitue;
        private System.Windows.Forms.ToolStripLabel tsmiUpdate;
        private System.Windows.Forms.ToolStripLabel tsmiDelete;
        private System.Windows.Forms.ToolStripLabel tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.TextBox txtDescriptionDiscipline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPeriodDiscipline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameDiscipline;
        private System.Windows.Forms.Label label3;
    }
}