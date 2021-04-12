
namespace OGM
{
    partial class OrganizationForm
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
			this.components = new System.ComponentModel.Container();
			this.groupBox_Search = new System.Windows.Forms.GroupBox();
			this.textBox_Bank = new System.Windows.Forms.TextBox();
			this.label_Bank = new System.Windows.Forms.Label();
			this.textBox_PostAddress = new System.Windows.Forms.TextBox();
			this.label_PostAddress = new System.Windows.Forms.Label();
			this.textBox_BIK = new System.Windows.Forms.TextBox();
			this.button_ResetComboBoxRole = new System.Windows.Forms.Button();
			this.button_ResetSearch = new System.Windows.Forms.Button();
			this.textBox_CorrespondentAccount = new System.Windows.Forms.TextBox();
			this.textBox_PaymentAccount = new System.Windows.Forms.TextBox();
			this.label_BIK = new System.Windows.Forms.Label();
			this.label_CorrespondentAccount = new System.Windows.Forms.Label();
			this.label_PaymentAccount = new System.Windows.Forms.Label();
			this.textBox_Phone = new System.Windows.Forms.TextBox();
			this.label_Phone = new System.Windows.Forms.Label();
			this.button_Search = new System.Windows.Forms.Button();
			this.comboBox_Role = new System.Windows.Forms.ComboBox();
			this.textBox_INN = new System.Windows.Forms.TextBox();
			this.textBox_LegalAddress = new System.Windows.Forms.TextBox();
			this.textBox_NameOrganiztion = new System.Windows.Forms.TextBox();
			this.label_Role = new System.Windows.Forms.Label();
			this.label_INN = new System.Windows.Forms.Label();
			this.label_LegalAddress = new System.Windows.Forms.Label();
			this.label_NameOrganiztion = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
			this.button_RemoveOrganization = new System.Windows.Forms.Button();
			this.button_EditOrganization = new System.Windows.Forms.Button();
			this.button_AddOrganization = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.ColumnPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_NameOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_LegalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_PostAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_PaymentAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_CorrespondentAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_BIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_Search
			// 
			this.groupBox_Search.Controls.Add(this.flowLayoutPanel2);
			this.groupBox_Search.Controls.Add(this.tableLayoutPanel2);
			this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_Search.Location = new System.Drawing.Point(3, 3);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(978, 284);
			this.groupBox_Search.TabIndex = 1;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска";
			// 
			// textBox_Bank
			// 
			this.textBox_Bank.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_Bank.Location = new System.Drawing.Point(682, 88);
			this.textBox_Bank.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_Bank.Name = "textBox_Bank";
			this.textBox_Bank.Size = new System.Drawing.Size(260, 29);
			this.textBox_Bank.TabIndex = 7;
			// 
			// label_Bank
			// 
			this.label_Bank.AutoSize = true;
			this.label_Bank.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Bank.Location = new System.Drawing.Point(625, 82);
			this.label_Bank.Name = "label_Bank";
			this.label_Bank.Size = new System.Drawing.Size(48, 41);
			this.label_Bank.TabIndex = 21;
			this.label_Bank.Text = "Банк:";
			this.label_Bank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_PostAddress
			// 
			this.textBox_PostAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_PostAddress.Location = new System.Drawing.Point(195, 129);
			this.textBox_PostAddress.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_PostAddress.Name = "textBox_PostAddress";
			this.textBox_PostAddress.Size = new System.Drawing.Size(260, 29);
			this.textBox_PostAddress.TabIndex = 3;
			// 
			// label_PostAddress
			// 
			this.label_PostAddress.AutoSize = true;
			this.label_PostAddress.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_PostAddress.Location = new System.Drawing.Point(55, 123);
			this.label_PostAddress.Name = "label_PostAddress";
			this.label_PostAddress.Size = new System.Drawing.Size(131, 41);
			this.label_PostAddress.TabIndex = 19;
			this.label_PostAddress.Text = "Почтовый адрес:";
			this.label_PostAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_BIK
			// 
			this.textBox_BIK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_BIK.Location = new System.Drawing.Point(682, 170);
			this.textBox_BIK.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_BIK.Name = "textBox_BIK";
			this.textBox_BIK.Size = new System.Drawing.Size(260, 29);
			this.textBox_BIK.TabIndex = 9;
			// 
			// button_ResetComboBoxRole
			// 
			this.button_ResetComboBoxRole.BackgroundImage = global::OGM.Properties.Resources.cancel;
			this.button_ResetComboBoxRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button_ResetComboBoxRole.Location = new System.Drawing.Point(467, 47);
			this.button_ResetComboBoxRole.Margin = new System.Windows.Forms.Padding(6);
			this.button_ResetComboBoxRole.Name = "button_ResetComboBoxRole";
			this.button_ResetComboBoxRole.Size = new System.Drawing.Size(29, 29);
			this.button_ResetComboBoxRole.TabIndex = 10;
			this.button_ResetComboBoxRole.UseVisualStyleBackColor = true;
			this.button_ResetComboBoxRole.Click += new System.EventHandler(this.button_ResetComboBoxRole_Click);
			// 
			// button_ResetSearch
			// 
			this.button_ResetSearch.Location = new System.Drawing.Point(443, 3);
			this.button_ResetSearch.Name = "button_ResetSearch";
			this.button_ResetSearch.Size = new System.Drawing.Size(260, 29);
			this.button_ResetSearch.TabIndex = 10;
			this.button_ResetSearch.Text = "Сбросить параметры поиска";
			this.button_ResetSearch.UseVisualStyleBackColor = true;
			this.button_ResetSearch.Click += new System.EventHandler(this.button_ResetSearch_Click);
			// 
			// textBox_CorrespondentAccount
			// 
			this.textBox_CorrespondentAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_CorrespondentAccount.Location = new System.Drawing.Point(682, 129);
			this.textBox_CorrespondentAccount.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_CorrespondentAccount.Name = "textBox_CorrespondentAccount";
			this.textBox_CorrespondentAccount.Size = new System.Drawing.Size(260, 29);
			this.textBox_CorrespondentAccount.TabIndex = 8;
			// 
			// textBox_PaymentAccount
			// 
			this.textBox_PaymentAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_PaymentAccount.Location = new System.Drawing.Point(682, 47);
			this.textBox_PaymentAccount.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_PaymentAccount.Name = "textBox_PaymentAccount";
			this.textBox_PaymentAccount.Size = new System.Drawing.Size(260, 29);
			this.textBox_PaymentAccount.TabIndex = 6;
			// 
			// label_BIK
			// 
			this.label_BIK.AutoSize = true;
			this.label_BIK.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_BIK.Location = new System.Drawing.Point(630, 164);
			this.label_BIK.Name = "label_BIK";
			this.label_BIK.Size = new System.Drawing.Size(43, 41);
			this.label_BIK.TabIndex = 13;
			this.label_BIK.Text = "БИК:";
			this.label_BIK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_CorrespondentAccount
			// 
			this.label_CorrespondentAccount.AutoSize = true;
			this.label_CorrespondentAccount.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_CorrespondentAccount.Location = new System.Drawing.Point(535, 123);
			this.label_CorrespondentAccount.Name = "label_CorrespondentAccount";
			this.label_CorrespondentAccount.Size = new System.Drawing.Size(138, 41);
			this.label_CorrespondentAccount.TabIndex = 12;
			this.label_CorrespondentAccount.Text = "Корреспонд. счёт:";
			this.label_CorrespondentAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.label_CorrespondentAccount, "Корреспондентский счёт");
			// 
			// label_PaymentAccount
			// 
			this.label_PaymentAccount.AutoSize = true;
			this.label_PaymentAccount.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_PaymentAccount.Location = new System.Drawing.Point(549, 41);
			this.label_PaymentAccount.Name = "label_PaymentAccount";
			this.label_PaymentAccount.Size = new System.Drawing.Size(124, 41);
			this.label_PaymentAccount.TabIndex = 11;
			this.label_PaymentAccount.Text = "Расчётный счёт:";
			this.label_PaymentAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_Phone
			// 
			this.textBox_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_Phone.Location = new System.Drawing.Point(195, 170);
			this.textBox_Phone.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_Phone.Name = "textBox_Phone";
			this.textBox_Phone.Size = new System.Drawing.Size(260, 29);
			this.textBox_Phone.TabIndex = 4;
			// 
			// label_Phone
			// 
			this.label_Phone.AutoSize = true;
			this.label_Phone.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Phone.Location = new System.Drawing.Point(73, 164);
			this.label_Phone.Name = "label_Phone";
			this.label_Phone.Size = new System.Drawing.Size(113, 41);
			this.label_Phone.TabIndex = 9;
			this.label_Phone.Text = "Телефон/Факс:";
			this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button_Search
			// 
			this.button_Search.Location = new System.Drawing.Point(709, 3);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(260, 29);
			this.button_Search.TabIndex = 10;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
			// 
			// comboBox_Role
			// 
			this.comboBox_Role.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_Role.FormattingEnabled = true;
			this.comboBox_Role.Items.AddRange(new object[] {
            "Лизингодатель",
            "Лизингополучатель",
            "Продавец"});
			this.comboBox_Role.Location = new System.Drawing.Point(195, 47);
			this.comboBox_Role.Margin = new System.Windows.Forms.Padding(6);
			this.comboBox_Role.Name = "comboBox_Role";
			this.comboBox_Role.Size = new System.Drawing.Size(260, 29);
			this.comboBox_Role.TabIndex = 1;
			// 
			// textBox_INN
			// 
			this.textBox_INN.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_INN.Location = new System.Drawing.Point(682, 6);
			this.textBox_INN.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_INN.Name = "textBox_INN";
			this.textBox_INN.Size = new System.Drawing.Size(260, 29);
			this.textBox_INN.TabIndex = 5;
			// 
			// textBox_LegalAddress
			// 
			this.textBox_LegalAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_LegalAddress.Location = new System.Drawing.Point(195, 88);
			this.textBox_LegalAddress.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_LegalAddress.Name = "textBox_LegalAddress";
			this.textBox_LegalAddress.Size = new System.Drawing.Size(260, 29);
			this.textBox_LegalAddress.TabIndex = 2;
			// 
			// textBox_NameOrganiztion
			// 
			this.textBox_NameOrganiztion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_NameOrganiztion.Location = new System.Drawing.Point(195, 6);
			this.textBox_NameOrganiztion.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_NameOrganiztion.Name = "textBox_NameOrganiztion";
			this.textBox_NameOrganiztion.Size = new System.Drawing.Size(260, 29);
			this.textBox_NameOrganiztion.TabIndex = 0;
			// 
			// label_Role
			// 
			this.label_Role.AutoSize = true;
			this.label_Role.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Role.Location = new System.Drawing.Point(140, 41);
			this.label_Role.Name = "label_Role";
			this.label_Role.Size = new System.Drawing.Size(46, 41);
			this.label_Role.TabIndex = 3;
			this.label_Role.Text = "Роль:";
			this.label_Role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_INN
			// 
			this.label_INN.AutoSize = true;
			this.label_INN.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_INN.Location = new System.Drawing.Point(626, 0);
			this.label_INN.Name = "label_INN";
			this.label_INN.Size = new System.Drawing.Size(47, 41);
			this.label_INN.TabIndex = 2;
			this.label_INN.Text = "ИНН:";
			this.label_INN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_LegalAddress
			// 
			this.label_LegalAddress.AutoSize = true;
			this.label_LegalAddress.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_LegalAddress.Location = new System.Drawing.Point(26, 82);
			this.label_LegalAddress.Name = "label_LegalAddress";
			this.label_LegalAddress.Size = new System.Drawing.Size(160, 41);
			this.label_LegalAddress.TabIndex = 1;
			this.label_LegalAddress.Text = "Юридический адрес:";
			this.label_LegalAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_NameOrganiztion
			// 
			this.label_NameOrganiztion.AutoSize = true;
			this.label_NameOrganiztion.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_NameOrganiztion.Location = new System.Drawing.Point(66, 0);
			this.label_NameOrganiztion.Name = "label_NameOrganiztion";
			this.label_NameOrganiztion.Size = new System.Drawing.Size(120, 41);
			this.label_NameOrganiztion.TabIndex = 0;
			this.label_NameOrganiztion.Text = "Наименование:";
			this.label_NameOrganiztion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGridView_DataSearch
			// 
			this.dataGridView_DataSearch.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView_DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPK,
            this.Column_NameOrganization,
            this.Column_Role,
            this.Column_LegalAddress,
            this.Column_PostAddress,
            this.ColumnPhone,
            this.Column_INN,
            this.Column_PaymentAccount,
            this.Column_Bank,
            this.Column_CorrespondentAccount,
            this.Column_BIK});
			this.dataGridView_DataSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_DataSearch.Location = new System.Drawing.Point(3, 334);
			this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
			this.dataGridView_DataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_DataSearch.Size = new System.Drawing.Size(978, 324);
			this.dataGridView_DataSearch.TabIndex = 14;
			// 
			// button_RemoveOrganization
			// 
			this.button_RemoveOrganization.Location = new System.Drawing.Point(415, 3);
			this.button_RemoveOrganization.Name = "button_RemoveOrganization";
			this.button_RemoveOrganization.Size = new System.Drawing.Size(200, 29);
			this.button_RemoveOrganization.TabIndex = 13;
			this.button_RemoveOrganization.Text = "Удалить";
			this.button_RemoveOrganization.UseVisualStyleBackColor = true;
			this.button_RemoveOrganization.Click += new System.EventHandler(this.button_RemoveOrganization_Click);
			// 
			// button_EditOrganization
			// 
			this.button_EditOrganization.Location = new System.Drawing.Point(209, 3);
			this.button_EditOrganization.Name = "button_EditOrganization";
			this.button_EditOrganization.Size = new System.Drawing.Size(200, 29);
			this.button_EditOrganization.TabIndex = 12;
			this.button_EditOrganization.Text = "Редактировать";
			this.button_EditOrganization.UseVisualStyleBackColor = true;
			this.button_EditOrganization.Click += new System.EventHandler(this.button_EditOrganization_Click);
			// 
			// button_AddOrganization
			// 
			this.button_AddOrganization.Location = new System.Drawing.Point(3, 3);
			this.button_AddOrganization.Name = "button_AddOrganization";
			this.button_AddOrganization.Size = new System.Drawing.Size(200, 29);
			this.button_AddOrganization.TabIndex = 11;
			this.button_AddOrganization.Text = "Добавить";
			this.button_AddOrganization.UseVisualStyleBackColor = true;
			this.button_AddOrganization.Click += new System.EventHandler(this.button_AddOrganization_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView_DataSearch, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.groupBox_Search, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 661);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.button_AddOrganization);
			this.flowLayoutPanel1.Controls.Add(this.button_EditOrganization);
			this.flowLayoutPanel1.Controls.Add(this.button_RemoveOrganization);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 293);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 35);
			this.flowLayoutPanel1.TabIndex = 16;
			// 
			// ColumnPK
			// 
			this.ColumnPK.HeaderText = "Первичный ключ";
			this.ColumnPK.Name = "ColumnPK";
			this.ColumnPK.ReadOnly = true;
			this.ColumnPK.Visible = false;
			// 
			// Column_NameOrganization
			// 
			this.Column_NameOrganization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_NameOrganization.HeaderText = "Наименование";
			this.Column_NameOrganization.Name = "Column_NameOrganization";
			this.Column_NameOrganization.ReadOnly = true;
			// 
			// Column_Role
			// 
			this.Column_Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_Role.HeaderText = "Роль";
			this.Column_Role.Name = "Column_Role";
			this.Column_Role.ReadOnly = true;
			// 
			// Column_LegalAddress
			// 
			this.Column_LegalAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_LegalAddress.HeaderText = "Юр. адрес";
			this.Column_LegalAddress.Name = "Column_LegalAddress";
			this.Column_LegalAddress.ReadOnly = true;
			// 
			// Column_PostAddress
			// 
			this.Column_PostAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_PostAddress.HeaderText = "Почтовый адрес";
			this.Column_PostAddress.Name = "Column_PostAddress";
			this.Column_PostAddress.ReadOnly = true;
			// 
			// ColumnPhone
			// 
			this.ColumnPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnPhone.HeaderText = "Телефон/факс";
			this.ColumnPhone.Name = "ColumnPhone";
			this.ColumnPhone.ReadOnly = true;
			// 
			// Column_INN
			// 
			this.Column_INN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_INN.HeaderText = "ИНН";
			this.Column_INN.Name = "Column_INN";
			this.Column_INN.ReadOnly = true;
			// 
			// Column_PaymentAccount
			// 
			this.Column_PaymentAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_PaymentAccount.HeaderText = "Расчётный счёт";
			this.Column_PaymentAccount.Name = "Column_PaymentAccount";
			this.Column_PaymentAccount.ReadOnly = true;
			// 
			// Column_Bank
			// 
			this.Column_Bank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_Bank.HeaderText = "Банк";
			this.Column_Bank.Name = "Column_Bank";
			this.Column_Bank.ReadOnly = true;
			// 
			// Column_CorrespondentAccount
			// 
			this.Column_CorrespondentAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_CorrespondentAccount.HeaderText = "Корреспонд. счёт";
			this.Column_CorrespondentAccount.Name = "Column_CorrespondentAccount";
			this.Column_CorrespondentAccount.ReadOnly = true;
			// 
			// Column_BIK
			// 
			this.Column_BIK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_BIK.HeaderText = "БИК";
			this.Column_BIK.Name = "Column_BIK";
			this.Column_BIK.ReadOnly = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 8;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.Controls.Add(this.label_NameOrganiztion, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox_BIK, 6, 4);
			this.tableLayoutPanel2.Controls.Add(this.textBox_Bank, 6, 2);
			this.tableLayoutPanel2.Controls.Add(this.label_Role, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBox_CorrespondentAccount, 6, 3);
			this.tableLayoutPanel2.Controls.Add(this.label_Bank, 5, 2);
			this.tableLayoutPanel2.Controls.Add(this.label_LegalAddress, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBox_PostAddress, 2, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBox_PaymentAccount, 6, 1);
			this.tableLayoutPanel2.Controls.Add(this.button_ResetComboBoxRole, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.label_BIK, 5, 4);
			this.tableLayoutPanel2.Controls.Add(this.textBox_INN, 6, 0);
			this.tableLayoutPanel2.Controls.Add(this.label_PostAddress, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.label_CorrespondentAccount, 5, 3);
			this.tableLayoutPanel2.Controls.Add(this.label_Phone, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.textBox_NameOrganiztion, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.comboBox_Role, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.label_PaymentAccount, 5, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBox_LegalAddress, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBox_Phone, 2, 4);
			this.tableLayoutPanel2.Controls.Add(this.label_INN, 5, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 7;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 256);
			this.tableLayoutPanel2.TabIndex = 22;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.button_Search);
			this.flowLayoutPanel2.Controls.Add(this.button_ResetSearch);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 246);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(972, 35);
			this.flowLayoutPanel2.TabIndex = 23;
			// 
			// OrganizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(1000, 700);
			this.Name = "OrganizationForm";
			this.ShowIcon = false;
			this.Text = "Справочник - Организация";
			this.Activated += new System.EventHandler(this.OrganizationForm_Activated);
			this.Load += new System.EventHandler(this.OrganizationForm_Load);
			this.groupBox_Search.ResumeLayout(false);
			this.groupBox_Search.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.TextBox textBox_INN;
        private System.Windows.Forms.TextBox textBox_LegalAddress;
        private System.Windows.Forms.TextBox textBox_NameOrganiztion;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Label label_INN;
        private System.Windows.Forms.Label label_LegalAddress;
        private System.Windows.Forms.Label label_NameOrganiztion;
        private System.Windows.Forms.TextBox textBox_Bank;
        private System.Windows.Forms.Label label_Bank;
        private System.Windows.Forms.TextBox textBox_PostAddress;
        private System.Windows.Forms.Label label_PostAddress;
        private System.Windows.Forms.TextBox textBox_BIK;
        private System.Windows.Forms.TextBox textBox_CorrespondentAccount;
        private System.Windows.Forms.TextBox textBox_PaymentAccount;
        private System.Windows.Forms.Label label_BIK;
        private System.Windows.Forms.Label label_CorrespondentAccount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_PaymentAccount;
        private System.Windows.Forms.DataGridView dataGridView_DataSearch;
        private System.Windows.Forms.Button button_RemoveOrganization;
        private System.Windows.Forms.Button button_EditOrganization;
        private System.Windows.Forms.Button button_AddOrganization;
		private System.Windows.Forms.Button button_ResetSearch;
		private System.Windows.Forms.Button button_ResetComboBoxRole;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPK;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameOrganization;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_Role;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_LegalAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_PostAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_INN;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_PaymentAccount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_Bank;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_CorrespondentAccount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_BIK;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}