namespace UI
{
    partial class AdminStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStaffForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiAddInstitue = new System.Windows.Forms.ToolStripLabel();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripLabel();
            this.tsmiExit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.rdoMam = new System.Windows.Forms.RadioButton();
            this.cboAddInstitute = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHiredate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lbPwd = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.kbName = new System.Windows.Forms.Label();
            this.cboAddPost = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cboPost = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboInstitute = new System.Windows.Forms.ComboBox();
            this.btnSeachByInst = new System.Windows.Forms.Button();
            this.btnSeachByPost = new System.Windows.Forms.Button();
            this.btnShowAllStaff = new System.Windows.Forms.Button();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.btnFindByName = new System.Windows.Forms.Button();
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
            this.tsmiExit,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 4;
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
            this.Column6,
            this.с5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono NL Light", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Location = new System.Drawing.Point(16, 65);
            this.dgvList.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1229, 581);
            this.dgvList.TabIndex = 17;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "IDStaff";
            this.Column6.HeaderText = "№";
            this.Column6.Name = "Column6";
            this.Column6.Width = 41;
            // 
            // с5
            // 
            this.с5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.с5.DataPropertyName = "NameStaff";
            this.с5.HeaderText = "ФИО";
            this.с5.MinimumWidth = 300;
            this.с5.Name = "с5";
            this.с5.Width = 300;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "ShortNameInst";
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "Институт";
            this.Column1.MinimumWidth = 20;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 68;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "NamePost";
            this.Column2.FillWeight = 30.45833F;
            this.Column2.HeaderText = "Отдел";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Email";
            this.Column3.FillWeight = 30.56631F;
            this.Column3.HeaderText = "Почта";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Login";
            this.Column5.HeaderText = "EDU почта";
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Phone";
            this.Column4.FillWeight = 30.66916F;
            this.Column4.HeaderText = "Тел";
            this.Column4.MinimumWidth = 130;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "Hiredate";
            this.Column7.HeaderText = "Время введения в должность";
            this.Column7.MinimumWidth = 140;
            this.Column7.Name = "Column7";
            this.Column7.Width = 140;
            // 
            // gpAdd
            // 
            this.gpAdd.BackColor = System.Drawing.Color.Linen;
            this.gpAdd.Controls.Add(this.rdoWoman);
            this.gpAdd.Controls.Add(this.rdoMam);
            this.gpAdd.Controls.Add(this.cboAddInstitute);
            this.gpAdd.Controls.Add(this.label8);
            this.gpAdd.Controls.Add(this.label7);
            this.gpAdd.Controls.Add(this.dtpHiredate);
            this.gpAdd.Controls.Add(this.txtEmail);
            this.gpAdd.Controls.Add(this.label6);
            this.gpAdd.Controls.Add(this.txtPhone);
            this.gpAdd.Controls.Add(this.label2);
            this.gpAdd.Controls.Add(this.lbPhone);
            this.gpAdd.Controls.Add(this.lbBirthday);
            this.gpAdd.Controls.Add(this.dtpBirthday);
            this.gpAdd.Controls.Add(this.txtPwd);
            this.gpAdd.Controls.Add(this.lbPwd);
            this.gpAdd.Controls.Add(this.txtLogin);
            this.gpAdd.Controls.Add(this.label1);
            this.gpAdd.Controls.Add(this.txtName);
            this.gpAdd.Controls.Add(this.kbName);
            this.gpAdd.Controls.Add(this.cboAddPost);
            this.gpAdd.Controls.Add(this.label9);
            this.gpAdd.Controls.Add(this.btnCancel);
            this.gpAdd.Controls.Add(this.btnOk);
            this.gpAdd.Location = new System.Drawing.Point(177, 120);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(900, 500);
            this.gpAdd.TabIndex = 20;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Добавление";
            this.gpAdd.Visible = false;
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Location = new System.Drawing.Point(725, 118);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(34, 22);
            this.rdoWoman.TabIndex = 39;
            this.rdoWoman.TabStop = true;
            this.rdoWoman.Text = "W";
            this.rdoWoman.UseVisualStyleBackColor = true;
            // 
            // rdoMam
            // 
            this.rdoMam.AutoSize = true;
            this.rdoMam.Checked = true;
            this.rdoMam.Location = new System.Drawing.Point(604, 118);
            this.rdoMam.Name = "rdoMam";
            this.rdoMam.Size = new System.Drawing.Size(34, 22);
            this.rdoMam.TabIndex = 38;
            this.rdoMam.TabStop = true;
            this.rdoMam.Text = "M";
            this.rdoMam.UseVisualStyleBackColor = true;
            // 
            // cboAddInstitute
            // 
            this.cboAddInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddInstitute.FormattingEnabled = true;
            this.cboAddInstitute.Location = new System.Drawing.Point(541, 358);
            this.cboAddInstitute.Name = "cboAddInstitute";
            this.cboAddInstitute.Size = new System.Drawing.Size(286, 26);
            this.cboAddInstitute.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Институт";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Время введения";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpHiredate
            // 
            this.dtpHiredate.Location = new System.Drawing.Point(541, 271);
            this.dtpHiredate.Name = "dtpHiredate";
            this.dtpHiredate.Size = new System.Drawing.Size(286, 26);
            this.dtpHiredate.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 271);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 26);
            this.txtEmail.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Почта";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(541, 189);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(286, 26);
            this.txtPhone.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Пол";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(471, 192);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(64, 18);
            this.lbPhone.TabIndex = 30;
            this.lbPhone.Text = "Телефон";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(36, 179);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(72, 36);
            this.lbBirthday.TabIndex = 29;
            this.lbBirthday.Text = "День\r\nрождения";
            this.lbBirthday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(114, 189);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(286, 26);
            this.dtpBirthday.TabIndex = 28;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(541, 45);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(286, 26);
            this.txtPwd.TabIndex = 27;
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Location = new System.Drawing.Point(479, 48);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(56, 18);
            this.lbPwd.TabIndex = 26;
            this.lbPwd.Text = "Пароль";
            this.lbPwd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(114, 45);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(286, 26);
            this.txtLogin.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Логин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 26);
            this.txtName.TabIndex = 23;
            // 
            // kbName
            // 
            this.kbName.AutoSize = true;
            this.kbName.Location = new System.Drawing.Point(76, 122);
            this.kbName.Name = "kbName";
            this.kbName.Size = new System.Drawing.Size(32, 18);
            this.kbName.TabIndex = 22;
            this.kbName.Text = "ФИО";
            this.kbName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboAddPost
            // 
            this.cboAddPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddPost.FormattingEnabled = true;
            this.cboAddPost.Location = new System.Drawing.Point(114, 355);
            this.cboAddPost.Name = "cboAddPost";
            this.cboAddPost.Size = new System.Drawing.Size(286, 26);
            this.cboAddPost.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Отдел";
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
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cboPost
            // 
            this.cboPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPost.FormattingEnabled = true;
            this.cboPost.Location = new System.Drawing.Point(380, 29);
            this.cboPost.Name = "cboPost";
            this.cboPost.Size = new System.Drawing.Size(174, 26);
            this.cboPost.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Отдел";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Институт";
            // 
            // cboInstitute
            // 
            this.cboInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstitute.FormattingEnabled = true;
            this.cboInstitute.Location = new System.Drawing.Point(91, 30);
            this.cboInstitute.Name = "cboInstitute";
            this.cboInstitute.Size = new System.Drawing.Size(109, 26);
            this.cboInstitute.TabIndex = 42;
            // 
            // btnSeachByInst
            // 
            this.btnSeachByInst.Location = new System.Drawing.Point(206, 28);
            this.btnSeachByInst.Name = "btnSeachByInst";
            this.btnSeachByInst.Size = new System.Drawing.Size(106, 29);
            this.btnSeachByInst.TabIndex = 43;
            this.btnSeachByInst.Text = "Найти";
            this.btnSeachByInst.UseVisualStyleBackColor = true;
            this.btnSeachByInst.Click += new System.EventHandler(this.btnSeachByInst_Click);
            // 
            // btnSeachByPost
            // 
            this.btnSeachByPost.Location = new System.Drawing.Point(560, 29);
            this.btnSeachByPost.Name = "btnSeachByPost";
            this.btnSeachByPost.Size = new System.Drawing.Size(106, 26);
            this.btnSeachByPost.TabIndex = 44;
            this.btnSeachByPost.Text = "Найти";
            this.btnSeachByPost.UseVisualStyleBackColor = true;
            this.btnSeachByPost.Click += new System.EventHandler(this.btnSeachByPost_Click);
            // 
            // btnShowAllStaff
            // 
            this.btnShowAllStaff.BackColor = System.Drawing.Color.Gold;
            this.btnShowAllStaff.Location = new System.Drawing.Point(1114, 28);
            this.btnShowAllStaff.Name = "btnShowAllStaff";
            this.btnShowAllStaff.Size = new System.Drawing.Size(131, 28);
            this.btnShowAllStaff.TabIndex = 45;
            this.btnShowAllStaff.Text = "Найти все";
            this.btnShowAllStaff.UseVisualStyleBackColor = false;
            this.btnShowAllStaff.Click += new System.EventHandler(this.btnShowAllStaff_Click);
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(691, 29);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(265, 26);
            this.txtFindName.TabIndex = 46;
            // 
            // btnFindByName
            // 
            this.btnFindByName.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnFindByName.Location = new System.Drawing.Point(962, 28);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(125, 28);
            this.btnFindByName.TabIndex = 47;
            this.btnFindByName.Text = "Найти по ФИО";
            this.btnFindByName.UseVisualStyleBackColor = false;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // AdminStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnFindByName);
            this.Controls.Add(this.txtFindName);
            this.Controls.Add(this.btnShowAllStaff);
            this.Controls.Add(this.btnSeachByPost);
            this.Controls.Add(this.btnSeachByInst);
            this.Controls.Add(this.cboInstitute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpAdd);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("JetBrains Mono NL Light", 10.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminStaffForm";
            this.Text = "Работник";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminStaffForm_Load);
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
        private System.Windows.Forms.ToolStripLabel tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn с5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.ComboBox cboAddPost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label kbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHiredate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.ComboBox cboAddInstitute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMam;
        private System.Windows.Forms.ComboBox cboPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboInstitute;
        private System.Windows.Forms.Button btnSeachByInst;
        private System.Windows.Forms.Button btnSeachByPost;
        private System.Windows.Forms.Button btnShowAllStaff;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.Button btnFindByName;
    }
}