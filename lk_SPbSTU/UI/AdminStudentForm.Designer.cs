namespace UI
{
    partial class AdminStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStudentForm));
            this.cboProfession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboInstitute = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiAddInstitue = new System.Windows.Forms.ToolStripLabel();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripLabel();
            this.tsmiDelete = new System.Windows.Forms.ToolStripLabel();
            this.tsmiExit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeach = new System.Windows.Forms.Button();
            this.btnSerchByName = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.rdoMam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHiredate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lbPwd = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.kbName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cboAddGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAddProfession = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboIAddnstitute = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProfession
            // 
            this.cboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfession.FormattingEnabled = true;
            this.cboProfession.Location = new System.Drawing.Point(359, 31);
            this.cboProfession.Name = "cboProfession";
            this.cboProfession.Size = new System.Drawing.Size(357, 26);
            this.cboProfession.TabIndex = 27;
            this.cboProfession.SelectedIndexChanged += new System.EventHandler(this.cboProfession_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Направление";
            // 
            // cboInstitute
            // 
            this.cboInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstitute.FormattingEnabled = true;
            this.cboInstitute.Location = new System.Drawing.Point(104, 31);
            this.cboInstitute.Name = "cboInstitute";
            this.cboInstitute.Size = new System.Drawing.Size(134, 26);
            this.cboInstitute.TabIndex = 25;
            this.cboInstitute.SelectedIndexChanged += new System.EventHandler(this.cboInstitute_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Институт";
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
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiAddInstitue
            // 
            this.tsmiAddInstitue.Name = "tsmiAddInstitue";
            this.tsmiAddInstitue.Size = new System.Drawing.Size(84, 22);
            this.tsmiAddInstitue.Text = "Добавление";
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
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(795, 32);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(172, 26);
            this.cboGroup.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Группа";
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(987, 31);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(106, 27);
            this.btnSeach.TabIndex = 31;
            this.btnSeach.Text = "Найти";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // btnSerchByName
            // 
            this.btnSerchByName.Location = new System.Drawing.Point(1121, 31);
            this.btnSerchByName.Name = "btnSerchByName";
            this.btnSerchByName.Size = new System.Drawing.Size(127, 27);
            this.btnSerchByName.TabIndex = 31;
            this.btnSerchByName.Text = "Найти по ФИО";
            this.btnSerchByName.UseVisualStyleBackColor = true;
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
            this.Column4,
            this.Column5,
            this.Column3,
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono NL Light", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Location = new System.Drawing.Point(19, 69);
            this.dgvList.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1229, 564);
            this.dgvList.TabIndex = 32;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "IDStudent";
            this.Column6.HeaderText = "№";
            this.Column6.Name = "Column6";
            this.Column6.Width = 41;
            // 
            // с5
            // 
            this.с5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.с5.DataPropertyName = "NameStudent";
            this.с5.HeaderText = "ФИО";
            this.с5.MinimumWidth = 300;
            this.с5.Name = "с5";
            this.с5.Width = 300;
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
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Login";
            this.Column5.HeaderText = "EDU почта";
            this.Column5.Name = "Column5";
            this.Column5.Width = 105;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Email";
            this.Column3.FillWeight = 30.56631F;
            this.Column3.HeaderText = "Почта";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 73;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Grade";
            this.Column7.HeaderText = "Курс";
            this.Column7.MinimumWidth = 140;
            this.Column7.Name = "Column7";
            // 
            // gpAdd
            // 
            this.gpAdd.BackColor = System.Drawing.Color.Linen;
            this.gpAdd.Controls.Add(this.cboAddGroup);
            this.gpAdd.Controls.Add(this.label5);
            this.gpAdd.Controls.Add(this.cboAddProfession);
            this.gpAdd.Controls.Add(this.label8);
            this.gpAdd.Controls.Add(this.cboIAddnstitute);
            this.gpAdd.Controls.Add(this.label10);
            this.gpAdd.Controls.Add(this.rdoWoman);
            this.gpAdd.Controls.Add(this.rdoMam);
            this.gpAdd.Controls.Add(this.label7);
            this.gpAdd.Controls.Add(this.dtpHiredate);
            this.gpAdd.Controls.Add(this.txtEmail);
            this.gpAdd.Controls.Add(this.label6);
            this.gpAdd.Controls.Add(this.txtPhone);
            this.gpAdd.Controls.Add(this.label3);
            this.gpAdd.Controls.Add(this.lbPhone);
            this.gpAdd.Controls.Add(this.lbBirthday);
            this.gpAdd.Controls.Add(this.dtpBirthday);
            this.gpAdd.Controls.Add(this.txtPwd);
            this.gpAdd.Controls.Add(this.lbPwd);
            this.gpAdd.Controls.Add(this.txtLogin);
            this.gpAdd.Controls.Add(this.label4);
            this.gpAdd.Controls.Add(this.txtName);
            this.gpAdd.Controls.Add(this.kbName);
            this.gpAdd.Controls.Add(this.btnCancel);
            this.gpAdd.Controls.Add(this.btnOk);
            this.gpAdd.Location = new System.Drawing.Point(193, 113);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(900, 500);
            this.gpAdd.TabIndex = 33;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Добавление";
            this.gpAdd.Visible = false;
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Location = new System.Drawing.Point(723, 105);
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
            this.rdoMam.Location = new System.Drawing.Point(602, 105);
            this.rdoMam.Name = "rdoMam";
            this.rdoMam.Size = new System.Drawing.Size(34, 22);
            this.rdoMam.TabIndex = 38;
            this.rdoMam.TabStop = true;
            this.rdoMam.Text = "M";
            this.rdoMam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 36);
            this.label7.TabIndex = 35;
            this.label7.Text = "Год\r\nпоступления";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpHiredate
            // 
            this.dtpHiredate.Location = new System.Drawing.Point(541, 240);
            this.dtpHiredate.Name = "dtpHiredate";
            this.dtpHiredate.Size = new System.Drawing.Size(286, 26);
            this.dtpHiredate.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 26);
            this.txtEmail.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Почта";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(541, 172);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(286, 26);
            this.txtPhone.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Пол";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(471, 175);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(64, 18);
            this.lbPhone.TabIndex = 30;
            this.lbPhone.Text = "Телефон";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(36, 162);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(72, 36);
            this.lbBirthday.TabIndex = 29;
            this.lbBirthday.Text = "День\r\nрождения";
            this.lbBirthday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(114, 172);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Логин";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 26);
            this.txtName.TabIndex = 23;
            // 
            // kbName
            // 
            this.kbName.AutoSize = true;
            this.kbName.Location = new System.Drawing.Point(74, 109);
            this.kbName.Name = "kbName";
            this.kbName.Size = new System.Drawing.Size(32, 18);
            this.kbName.TabIndex = 22;
            this.kbName.Text = "ФИО";
            this.kbName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(755, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(635, 434);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Insert";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // cboAddGroup
            // 
            this.cboAddGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddGroup.FormattingEnabled = true;
            this.cboAddGroup.Location = new System.Drawing.Point(541, 311);
            this.cboAddGroup.Name = "cboAddGroup";
            this.cboAddGroup.Size = new System.Drawing.Size(286, 26);
            this.cboAddGroup.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Группа";
            // 
            // cboAddProfession
            // 
            this.cboAddProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddProfession.FormattingEnabled = true;
            this.cboAddProfession.Location = new System.Drawing.Point(114, 380);
            this.cboAddProfession.Name = "cboAddProfession";
            this.cboAddProfession.Size = new System.Drawing.Size(713, 26);
            this.cboAddProfession.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Направление";
            // 
            // cboIAddnstitute
            // 
            this.cboIAddnstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIAddnstitute.FormattingEnabled = true;
            this.cboIAddnstitute.Location = new System.Drawing.Point(114, 311);
            this.cboIAddnstitute.Name = "cboIAddnstitute";
            this.cboIAddnstitute.Size = new System.Drawing.Size(286, 26);
            this.cboIAddnstitute.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Институт";
            // 
            // AdminStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gpAdd);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSerchByName);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboProfession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboInstitute);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("JetBrains Mono NL Light", 10.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminStudentForm";
            this.Text = "AdminStudentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminStudentForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gpAdd.ResumeLayout(false);
            this.gpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProfession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboInstitute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsmiAddInstitue;
        private System.Windows.Forms.ToolStripLabel tsmiUpdate;
        private System.Windows.Forms.ToolStripLabel tsmiDelete;
        private System.Windows.Forms.ToolStripLabel tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnSerchByName;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn с5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHiredate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label kbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cboAddGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAddProfession;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboIAddnstitute;
        private System.Windows.Forms.Label label10;
    }
}