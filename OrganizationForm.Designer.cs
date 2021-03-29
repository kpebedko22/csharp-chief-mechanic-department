
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
            this.label_Phone = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.textBox_InventoryNum = new System.Windows.Forms.TextBox();
            this.textBox_LegalAddress = new System.Windows.Forms.TextBox();
            this.textBox_NameOrganiztion = new System.Windows.Forms.TextBox();
            this.label_Role = new System.Windows.Forms.Label();
            this.label_INN = new System.Windows.Forms.Label();
            this.label_LegalAddress = new System.Windows.Forms.Label();
            this.label_NameOrganiztion = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_PostAddress = new System.Windows.Forms.TextBox();
            this.label_PostAddress = new System.Windows.Forms.Label();
            this.textBox_BIK = new System.Windows.Forms.TextBox();
            this.textBox_CorrespondentAccount = new System.Windows.Forms.TextBox();
            this.textBox_PaymentAccount = new System.Windows.Forms.TextBox();
            this.label_BIK = new System.Windows.Forms.Label();
            this.label_CorrespondentAccount = new System.Windows.Forms.Label();
            this.label_PaymentAccount = new System.Windows.Forms.Label();
            this.textBox_Bank = new System.Windows.Forms.TextBox();
            this.label_Bank = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_RemoveOrganization = new System.Windows.Forms.Button();
            this.button_EditOrganization = new System.Windows.Forms.Button();
            this.button_AddOrganization = new System.Windows.Forms.Button();
            this.Column_NameOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LegalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PostAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PaymentAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CorrespondentAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.textBox_Bank);
            this.groupBox_Search.Controls.Add(this.label_Bank);
            this.groupBox_Search.Controls.Add(this.textBox_PostAddress);
            this.groupBox_Search.Controls.Add(this.label_PostAddress);
            this.groupBox_Search.Controls.Add(this.textBox_BIK);
            this.groupBox_Search.Controls.Add(this.textBox_CorrespondentAccount);
            this.groupBox_Search.Controls.Add(this.textBox_PaymentAccount);
            this.groupBox_Search.Controls.Add(this.label_BIK);
            this.groupBox_Search.Controls.Add(this.label_CorrespondentAccount);
            this.groupBox_Search.Controls.Add(this.label_PaymentAccount);
            this.groupBox_Search.Controls.Add(this.textBox_Phone);
            this.groupBox_Search.Controls.Add(this.label_Phone);
            this.groupBox_Search.Controls.Add(this.button_Search);
            this.groupBox_Search.Controls.Add(this.comboBox_Role);
            this.groupBox_Search.Controls.Add(this.textBox_InventoryNum);
            this.groupBox_Search.Controls.Add(this.textBox_LegalAddress);
            this.groupBox_Search.Controls.Add(this.textBox_NameOrganiztion);
            this.groupBox_Search.Controls.Add(this.label_Role);
            this.groupBox_Search.Controls.Add(this.label_INN);
            this.groupBox_Search.Controls.Add(this.label_LegalAddress);
            this.groupBox_Search.Controls.Add(this.label_NameOrganiztion);
            this.groupBox_Search.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(972, 282);
            this.groupBox_Search.TabIndex = 1;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Параметры поиска";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(21, 194);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(115, 21);
            this.label_Phone.TabIndex = 9;
            this.label_Phone.Text = "Телефон/Факс:";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(686, 240);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(260, 29);
            this.button_Search.TabIndex = 10;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "Лизингодатель",
            "Лизингополучатель",
            "Продавец"});
            this.comboBox_Role.Location = new System.Drawing.Point(187, 61);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(260, 29);
            this.comboBox_Role.TabIndex = 1;
            // 
            // textBox_InventoryNum
            // 
            this.textBox_InventoryNum.Location = new System.Drawing.Point(686, 22);
            this.textBox_InventoryNum.Name = "textBox_InventoryNum";
            this.textBox_InventoryNum.Size = new System.Drawing.Size(260, 29);
            this.textBox_InventoryNum.TabIndex = 5;
            // 
            // textBox_LegalAddress
            // 
            this.textBox_LegalAddress.Location = new System.Drawing.Point(187, 104);
            this.textBox_LegalAddress.Name = "textBox_LegalAddress";
            this.textBox_LegalAddress.Size = new System.Drawing.Size(260, 29);
            this.textBox_LegalAddress.TabIndex = 2;
            // 
            // textBox_NameOrganiztion
            // 
            this.textBox_NameOrganiztion.Location = new System.Drawing.Point(187, 22);
            this.textBox_NameOrganiztion.Name = "textBox_NameOrganiztion";
            this.textBox_NameOrganiztion.Size = new System.Drawing.Size(260, 29);
            this.textBox_NameOrganiztion.TabIndex = 0;
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(21, 64);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(47, 21);
            this.label_Role.TabIndex = 3;
            this.label_Role.Text = "Роль:";
            // 
            // label_INN
            // 
            this.label_INN.AutoSize = true;
            this.label_INN.Location = new System.Drawing.Point(520, 25);
            this.label_INN.Name = "label_INN";
            this.label_INN.Size = new System.Drawing.Size(47, 21);
            this.label_INN.TabIndex = 2;
            this.label_INN.Text = "ИНН:";
            // 
            // label_LegalAddress
            // 
            this.label_LegalAddress.AutoSize = true;
            this.label_LegalAddress.Location = new System.Drawing.Point(21, 107);
            this.label_LegalAddress.Name = "label_LegalAddress";
            this.label_LegalAddress.Size = new System.Drawing.Size(160, 21);
            this.label_LegalAddress.TabIndex = 1;
            this.label_LegalAddress.Text = "Юридический адрес:";
            // 
            // label_NameOrganiztion
            // 
            this.label_NameOrganiztion.AutoSize = true;
            this.label_NameOrganiztion.Location = new System.Drawing.Point(21, 25);
            this.label_NameOrganiztion.Name = "label_NameOrganiztion";
            this.label_NameOrganiztion.Size = new System.Drawing.Size(120, 21);
            this.label_NameOrganiztion.TabIndex = 0;
            this.label_NameOrganiztion.Text = "Наименование:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(187, 191);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(260, 29);
            this.textBox_Phone.TabIndex = 4;
            // 
            // textBox_PostAddress
            // 
            this.textBox_PostAddress.Location = new System.Drawing.Point(187, 148);
            this.textBox_PostAddress.Name = "textBox_PostAddress";
            this.textBox_PostAddress.Size = new System.Drawing.Size(260, 29);
            this.textBox_PostAddress.TabIndex = 3;
            // 
            // label_PostAddress
            // 
            this.label_PostAddress.AutoSize = true;
            this.label_PostAddress.Location = new System.Drawing.Point(21, 151);
            this.label_PostAddress.Name = "label_PostAddress";
            this.label_PostAddress.Size = new System.Drawing.Size(131, 21);
            this.label_PostAddress.TabIndex = 19;
            this.label_PostAddress.Text = "Почтовый адрес:";
            // 
            // textBox_BIK
            // 
            this.textBox_BIK.Location = new System.Drawing.Point(686, 191);
            this.textBox_BIK.Name = "textBox_BIK";
            this.textBox_BIK.Size = new System.Drawing.Size(260, 29);
            this.textBox_BIK.TabIndex = 9;
            // 
            // textBox_CorrespondentAccount
            // 
            this.textBox_CorrespondentAccount.Location = new System.Drawing.Point(686, 146);
            this.textBox_CorrespondentAccount.Name = "textBox_CorrespondentAccount";
            this.textBox_CorrespondentAccount.Size = new System.Drawing.Size(260, 29);
            this.textBox_CorrespondentAccount.TabIndex = 8;
            // 
            // textBox_PaymentAccount
            // 
            this.textBox_PaymentAccount.Location = new System.Drawing.Point(686, 61);
            this.textBox_PaymentAccount.Name = "textBox_PaymentAccount";
            this.textBox_PaymentAccount.Size = new System.Drawing.Size(260, 29);
            this.textBox_PaymentAccount.TabIndex = 6;
            // 
            // label_BIK
            // 
            this.label_BIK.AutoSize = true;
            this.label_BIK.Location = new System.Drawing.Point(520, 194);
            this.label_BIK.Name = "label_BIK";
            this.label_BIK.Size = new System.Drawing.Size(43, 21);
            this.label_BIK.TabIndex = 13;
            this.label_BIK.Text = "БИК:";
            // 
            // label_CorrespondentAccount
            // 
            this.label_CorrespondentAccount.AutoSize = true;
            this.label_CorrespondentAccount.Location = new System.Drawing.Point(520, 149);
            this.label_CorrespondentAccount.Name = "label_CorrespondentAccount";
            this.label_CorrespondentAccount.Size = new System.Drawing.Size(138, 21);
            this.label_CorrespondentAccount.TabIndex = 12;
            this.label_CorrespondentAccount.Text = "Корреспонд. счёт:";
            this.toolTip1.SetToolTip(this.label_CorrespondentAccount, "Корреспондентский счёт");
            // 
            // label_PaymentAccount
            // 
            this.label_PaymentAccount.AutoSize = true;
            this.label_PaymentAccount.Location = new System.Drawing.Point(520, 67);
            this.label_PaymentAccount.Name = "label_PaymentAccount";
            this.label_PaymentAccount.Size = new System.Drawing.Size(125, 21);
            this.label_PaymentAccount.TabIndex = 11;
            this.label_PaymentAccount.Text = "Расчётный счёт:";
            // 
            // textBox_Bank
            // 
            this.textBox_Bank.Location = new System.Drawing.Point(686, 104);
            this.textBox_Bank.Name = "textBox_Bank";
            this.textBox_Bank.Size = new System.Drawing.Size(260, 29);
            this.textBox_Bank.TabIndex = 7;
            // 
            // label_Bank
            // 
            this.label_Bank.AutoSize = true;
            this.label_Bank.Location = new System.Drawing.Point(520, 107);
            this.label_Bank.Name = "label_Bank";
            this.label_Bank.Size = new System.Drawing.Size(47, 21);
            this.label_Bank.TabIndex = 21;
            this.label_Bank.Text = "Банк:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NameOrganization,
            this.Column_Role,
            this.Column_LegalAddress,
            this.Column_PostAddress,
            this.Column_INN,
            this.Column_PaymentAccount,
            this.Column_Bank,
            this.Column_CorrespondentAccount,
            this.Column_BIK});
            this.dataGridView.Location = new System.Drawing.Point(12, 335);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(972, 380);
            this.dataGridView.TabIndex = 14;
            // 
            // button_RemoveOrganization
            // 
            this.button_RemoveOrganization.Location = new System.Drawing.Point(436, 300);
            this.button_RemoveOrganization.Name = "button_RemoveOrganization";
            this.button_RemoveOrganization.Size = new System.Drawing.Size(206, 29);
            this.button_RemoveOrganization.TabIndex = 13;
            this.button_RemoveOrganization.Text = "Удалить";
            this.button_RemoveOrganization.UseVisualStyleBackColor = true;
            // 
            // button_EditOrganization
            // 
            this.button_EditOrganization.Location = new System.Drawing.Point(224, 300);
            this.button_EditOrganization.Name = "button_EditOrganization";
            this.button_EditOrganization.Size = new System.Drawing.Size(206, 29);
            this.button_EditOrganization.TabIndex = 12;
            this.button_EditOrganization.Text = "Редактировать";
            this.button_EditOrganization.UseVisualStyleBackColor = true;
            // 
            // button_AddOrganization
            // 
            this.button_AddOrganization.Location = new System.Drawing.Point(12, 300);
            this.button_AddOrganization.Name = "button_AddOrganization";
            this.button_AddOrganization.Size = new System.Drawing.Size(206, 29);
            this.button_AddOrganization.TabIndex = 11;
            this.button_AddOrganization.Text = "Добавить";
            this.button_AddOrganization.UseVisualStyleBackColor = true;
            this.button_AddOrganization.Click += new System.EventHandler(this.button_AddOrganization_Click);
            // 
            // Column_NameOrganization
            // 
            this.Column_NameOrganization.HeaderText = "Наименование";
            this.Column_NameOrganization.Name = "Column_NameOrganization";
            this.Column_NameOrganization.ReadOnly = true;
            this.Column_NameOrganization.Width = 118;
            // 
            // Column_Role
            // 
            this.Column_Role.HeaderText = "Роль";
            this.Column_Role.Name = "Column_Role";
            this.Column_Role.ReadOnly = true;
            // 
            // Column_LegalAddress
            // 
            this.Column_LegalAddress.HeaderText = "Юр. Адрес";
            this.Column_LegalAddress.Name = "Column_LegalAddress";
            this.Column_LegalAddress.ReadOnly = true;
            this.Column_LegalAddress.Width = 110;
            // 
            // Column_PostAddress
            // 
            this.Column_PostAddress.HeaderText = "Почтовый адрес";
            this.Column_PostAddress.Name = "Column_PostAddress";
            this.Column_PostAddress.ReadOnly = true;
            // 
            // Column_INN
            // 
            this.Column_INN.HeaderText = "ИНН";
            this.Column_INN.Name = "Column_INN";
            this.Column_INN.ReadOnly = true;
            // 
            // Column_PaymentAccount
            // 
            this.Column_PaymentAccount.HeaderText = "Расчётный счёт";
            this.Column_PaymentAccount.Name = "Column_PaymentAccount";
            this.Column_PaymentAccount.ReadOnly = true;
            // 
            // Column_Bank
            // 
            this.Column_Bank.HeaderText = "Банк";
            this.Column_Bank.Name = "Column_Bank";
            this.Column_Bank.ReadOnly = true;
            // 
            // Column_CorrespondentAccount
            // 
            this.Column_CorrespondentAccount.HeaderText = "Корреспонд. счёт";
            this.Column_CorrespondentAccount.Name = "Column_CorrespondentAccount";
            this.Column_CorrespondentAccount.ReadOnly = true;
            // 
            // Column_BIK
            // 
            this.Column_BIK.HeaderText = "БИК";
            this.Column_BIK.Name = "Column_BIK";
            this.Column_BIK.ReadOnly = true;
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 727);
            this.Controls.Add(this.button_RemoveOrganization);
            this.Controls.Add(this.button_EditOrganization);
            this.Controls.Add(this.button_AddOrganization);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox_Search);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrganizationForm";
            this.Text = "Справочник - Организация";
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.TextBox textBox_InventoryNum;
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameOrganization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LegalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PostAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_INN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PaymentAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CorrespondentAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BIK;
        private System.Windows.Forms.Button button_RemoveOrganization;
        private System.Windows.Forms.Button button_EditOrganization;
        private System.Windows.Forms.Button button_AddOrganization;
    }
}