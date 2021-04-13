
namespace OGM
{
    partial class AddOrganizationForm
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
            this.textBox_Bank = new System.Windows.Forms.TextBox();
            this.label_Bank = new System.Windows.Forms.Label();
            this.textBox_PostAddress = new System.Windows.Forms.TextBox();
            this.label_PostAddress = new System.Windows.Forms.Label();
            this.textBox_BIK = new System.Windows.Forms.TextBox();
            this.textBox_CorrespondentAccount = new System.Windows.Forms.TextBox();
            this.textBox_PaymentAccount = new System.Windows.Forms.TextBox();
            this.label_BIK = new System.Windows.Forms.Label();
            this.label_CorrespondentAccount = new System.Windows.Forms.Label();
            this.label_PaymentAccount = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.textBox_INN = new System.Windows.Forms.TextBox();
            this.textBox_LegalAddress = new System.Windows.Forms.TextBox();
            this.textBox_NameOrganiztion = new System.Windows.Forms.TextBox();
            this.label_Role = new System.Windows.Forms.Label();
            this.label_INN = new System.Windows.Forms.Label();
            this.label_LegalAddress = new System.Windows.Forms.Label();
            this.label_NameOrganiztion = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddAndClose = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Bank
            // 
            this.textBox_Bank.Location = new System.Drawing.Point(202, 335);
            this.textBox_Bank.MaxLength = 249;
            this.textBox_Bank.Name = "textBox_Bank";
            this.textBox_Bank.Size = new System.Drawing.Size(370, 29);
            this.textBox_Bank.TabIndex = 7;
            // 
            // label_Bank
            // 
            this.label_Bank.AutoSize = true;
            this.label_Bank.Location = new System.Drawing.Point(145, 339);
            this.label_Bank.Name = "label_Bank";
            this.label_Bank.Size = new System.Drawing.Size(47, 21);
            this.label_Bank.TabIndex = 42;
            this.label_Bank.Text = "Банк:";
            // 
            // textBox_PostAddress
            // 
            this.textBox_PostAddress.Location = new System.Drawing.Point(202, 155);
            this.textBox_PostAddress.MaxLength = 249;
            this.textBox_PostAddress.Name = "textBox_PostAddress";
            this.textBox_PostAddress.Size = new System.Drawing.Size(370, 29);
            this.textBox_PostAddress.TabIndex = 3;
            // 
            // label_PostAddress
            // 
            this.label_PostAddress.AutoSize = true;
            this.label_PostAddress.Location = new System.Drawing.Point(62, 159);
            this.label_PostAddress.Name = "label_PostAddress";
            this.label_PostAddress.Size = new System.Drawing.Size(131, 21);
            this.label_PostAddress.TabIndex = 41;
            this.label_PostAddress.Text = "Почтовый адрес:";
            // 
            // textBox_BIK
            // 
            this.textBox_BIK.Location = new System.Drawing.Point(202, 425);
            this.textBox_BIK.MaxLength = 49;
            this.textBox_BIK.Name = "textBox_BIK";
            this.textBox_BIK.Size = new System.Drawing.Size(370, 29);
            this.textBox_BIK.TabIndex = 9;
            // 
            // textBox_CorrespondentAccount
            // 
            this.textBox_CorrespondentAccount.Location = new System.Drawing.Point(202, 380);
            this.textBox_CorrespondentAccount.MaxLength = 49;
            this.textBox_CorrespondentAccount.Name = "textBox_CorrespondentAccount";
            this.textBox_CorrespondentAccount.Size = new System.Drawing.Size(370, 29);
            this.textBox_CorrespondentAccount.TabIndex = 8;
            // 
            // textBox_PaymentAccount
            // 
            this.textBox_PaymentAccount.Location = new System.Drawing.Point(202, 290);
            this.textBox_PaymentAccount.MaxLength = 49;
            this.textBox_PaymentAccount.Name = "textBox_PaymentAccount";
            this.textBox_PaymentAccount.Size = new System.Drawing.Size(370, 29);
            this.textBox_PaymentAccount.TabIndex = 6;
            // 
            // label_BIK
            // 
            this.label_BIK.AutoSize = true;
            this.label_BIK.Location = new System.Drawing.Point(150, 429);
            this.label_BIK.Name = "label_BIK";
            this.label_BIK.Size = new System.Drawing.Size(43, 21);
            this.label_BIK.TabIndex = 40;
            this.label_BIK.Text = "БИК:";
            // 
            // label_CorrespondentAccount
            // 
            this.label_CorrespondentAccount.AutoSize = true;
            this.label_CorrespondentAccount.Location = new System.Drawing.Point(55, 384);
            this.label_CorrespondentAccount.Name = "label_CorrespondentAccount";
            this.label_CorrespondentAccount.Size = new System.Drawing.Size(138, 21);
            this.label_CorrespondentAccount.TabIndex = 39;
            this.label_CorrespondentAccount.Text = "Корреспонд. счёт:";
            // 
            // label_PaymentAccount
            // 
            this.label_PaymentAccount.AutoSize = true;
            this.label_PaymentAccount.Location = new System.Drawing.Point(69, 294);
            this.label_PaymentAccount.Name = "label_PaymentAccount";
            this.label_PaymentAccount.Size = new System.Drawing.Size(125, 21);
            this.label_PaymentAccount.TabIndex = 38;
            this.label_PaymentAccount.Text = "Расчётный счёт:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(202, 200);
            this.textBox_Phone.MaxLength = 19;
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(370, 29);
            this.textBox_Phone.TabIndex = 4;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(80, 204);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(115, 21);
            this.label_Phone.TabIndex = 35;
            this.label_Phone.Text = "Телефон/Факс:";
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "Лизингодатель",
            "Лизингополучатель",
            "Продавец"});
            this.comboBox_Role.Location = new System.Drawing.Point(202, 65);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(370, 29);
            this.comboBox_Role.TabIndex = 1;
            // 
            // textBox_INN
            // 
            this.textBox_INN.Location = new System.Drawing.Point(202, 245);
            this.textBox_INN.MaxLength = 19;
            this.textBox_INN.Name = "textBox_INN";
            this.textBox_INN.Size = new System.Drawing.Size(370, 29);
            this.textBox_INN.TabIndex = 5;
            // 
            // textBox_LegalAddress
            // 
            this.textBox_LegalAddress.Location = new System.Drawing.Point(202, 110);
            this.textBox_LegalAddress.MaxLength = 249;
            this.textBox_LegalAddress.Name = "textBox_LegalAddress";
            this.textBox_LegalAddress.Size = new System.Drawing.Size(370, 29);
            this.textBox_LegalAddress.TabIndex = 2;
            // 
            // textBox_NameOrganiztion
            // 
            this.textBox_NameOrganiztion.Location = new System.Drawing.Point(202, 20);
            this.textBox_NameOrganiztion.MaxLength = 249;
            this.textBox_NameOrganiztion.Name = "textBox_NameOrganiztion";
            this.textBox_NameOrganiztion.Size = new System.Drawing.Size(370, 29);
            this.textBox_NameOrganiztion.TabIndex = 0;
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(147, 69);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(47, 21);
            this.label_Role.TabIndex = 29;
            this.label_Role.Text = "Роль:";
            // 
            // label_INN
            // 
            this.label_INN.AutoSize = true;
            this.label_INN.Location = new System.Drawing.Point(146, 249);
            this.label_INN.Name = "label_INN";
            this.label_INN.Size = new System.Drawing.Size(47, 21);
            this.label_INN.TabIndex = 26;
            this.label_INN.Text = "ИНН:";
            // 
            // label_LegalAddress
            // 
            this.label_LegalAddress.AutoSize = true;
            this.label_LegalAddress.Location = new System.Drawing.Point(33, 114);
            this.label_LegalAddress.Name = "label_LegalAddress";
            this.label_LegalAddress.Size = new System.Drawing.Size(160, 21);
            this.label_LegalAddress.TabIndex = 25;
            this.label_LegalAddress.Text = "Юридический адрес:";
            // 
            // label_NameOrganiztion
            // 
            this.label_NameOrganiztion.AutoSize = true;
            this.label_NameOrganiztion.Location = new System.Drawing.Point(73, 24);
            this.label_NameOrganiztion.Name = "label_NameOrganiztion";
            this.label_NameOrganiztion.Size = new System.Drawing.Size(120, 21);
            this.label_NameOrganiztion.TabIndex = 22;
            this.label_NameOrganiztion.Text = "Наименование:";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(391, 478);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(180, 29);
            this.button_Close.TabIndex = 12;
            this.button_Close.Text = "Отмена";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddAndClose
            // 
            this.button_AddAndClose.Location = new System.Drawing.Point(202, 478);
            this.button_AddAndClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddAndClose.Name = "button_AddAndClose";
            this.button_AddAndClose.Size = new System.Drawing.Size(180, 29);
            this.button_AddAndClose.TabIndex = 11;
            this.button_AddAndClose.Text = "Добавить и закрыть";
            this.button_AddAndClose.UseVisualStyleBackColor = true;
            this.button_AddAndClose.Click += new System.EventHandler(this.button_AddAndClose_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(13, 478);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 29);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AddOrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 521);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_AddAndClose);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Bank);
            this.Controls.Add(this.label_Bank);
            this.Controls.Add(this.textBox_PostAddress);
            this.Controls.Add(this.label_PostAddress);
            this.Controls.Add(this.textBox_BIK);
            this.Controls.Add(this.textBox_CorrespondentAccount);
            this.Controls.Add(this.textBox_PaymentAccount);
            this.Controls.Add(this.label_BIK);
            this.Controls.Add(this.label_CorrespondentAccount);
            this.Controls.Add(this.label_PaymentAccount);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.textBox_INN);
            this.Controls.Add(this.textBox_LegalAddress);
            this.Controls.Add(this.textBox_NameOrganiztion);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.label_INN);
            this.Controls.Add(this.label_LegalAddress);
            this.Controls.Add(this.label_NameOrganiztion);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrganizationForm";
            this.Text = "Справочник - Добавить организацию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Bank;
        private System.Windows.Forms.Label label_Bank;
        private System.Windows.Forms.TextBox textBox_PostAddress;
        private System.Windows.Forms.Label label_PostAddress;
        private System.Windows.Forms.TextBox textBox_BIK;
        private System.Windows.Forms.TextBox textBox_CorrespondentAccount;
        private System.Windows.Forms.TextBox textBox_PaymentAccount;
        private System.Windows.Forms.Label label_BIK;
        private System.Windows.Forms.Label label_CorrespondentAccount;
        private System.Windows.Forms.Label label_PaymentAccount;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.TextBox textBox_INN;
        private System.Windows.Forms.TextBox textBox_LegalAddress;
        private System.Windows.Forms.TextBox textBox_NameOrganiztion;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Label label_INN;
        private System.Windows.Forms.Label label_LegalAddress;
        private System.Windows.Forms.Label label_NameOrganiztion;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddAndClose;
        private System.Windows.Forms.Button button_Add;
    }
}