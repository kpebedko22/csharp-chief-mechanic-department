
namespace OGM
{
    partial class AddWorkshopForm
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
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_PhoneWorkshop = new System.Windows.Forms.TextBox();
            this.textBox_NameWorkshop = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_AddWorkshopAndClose = new System.Windows.Forms.Button();
            this.button_AddWorkShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(160, 98);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(378, 29);
            this.textBox_Email.TabIndex = 14;
            // 
            // textBox_PhoneWorkshop
            // 
            this.textBox_PhoneWorkshop.Location = new System.Drawing.Point(160, 54);
            this.textBox_PhoneWorkshop.Name = "textBox_PhoneWorkshop";
            this.textBox_PhoneWorkshop.Size = new System.Drawing.Size(378, 29);
            this.textBox_PhoneWorkshop.TabIndex = 13;
            // 
            // textBox_NameWorkshop
            // 
            this.textBox_NameWorkshop.Location = new System.Drawing.Point(160, 12);
            this.textBox_NameWorkshop.Name = "textBox_NameWorkshop";
            this.textBox_NameWorkshop.Size = new System.Drawing.Size(378, 29);
            this.textBox_NameWorkshop.TabIndex = 12;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(16, 101);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(57, 21);
            this.label_Email.TabIndex = 11;
            this.label_Email.Text = "E-mail:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(16, 57);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(133, 21);
            this.label_Phone.TabIndex = 10;
            this.label_Phone.Text = "Номер телефона:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(16, 15);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(120, 21);
            this.label_Name.TabIndex = 9;
            this.label_Name.Text = "Наименование:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(25, 150);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(158, 29);
            this.button_Cancel.TabIndex = 26;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_AddWorkshopAndClose
            // 
            this.button_AddWorkshopAndClose.Location = new System.Drawing.Point(189, 150);
            this.button_AddWorkshopAndClose.Name = "button_AddWorkshopAndClose";
            this.button_AddWorkshopAndClose.Size = new System.Drawing.Size(175, 29);
            this.button_AddWorkshopAndClose.TabIndex = 25;
            this.button_AddWorkshopAndClose.Text = "Добавить и закрыть";
            this.button_AddWorkshopAndClose.UseVisualStyleBackColor = true;
            // 
            // button_AddWorkShop
            // 
            this.button_AddWorkShop.Location = new System.Drawing.Point(370, 150);
            this.button_AddWorkShop.Name = "button_AddWorkShop";
            this.button_AddWorkShop.Size = new System.Drawing.Size(168, 29);
            this.button_AddWorkShop.TabIndex = 24;
            this.button_AddWorkShop.Text = "Добавить";
            this.button_AddWorkShop.UseVisualStyleBackColor = true;
            // 
            // AddWorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 193);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddWorkshopAndClose);
            this.Controls.Add(this.button_AddWorkShop);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_PhoneWorkshop);
            this.Controls.Add(this.textBox_NameWorkshop);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Name);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddWorkshopForm";
            this.Text = "Справочник - Добавить цех";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_PhoneWorkshop;
        private System.Windows.Forms.TextBox textBox_NameWorkshop;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_AddWorkshopAndClose;
        private System.Windows.Forms.Button button_AddWorkShop;
    }
}