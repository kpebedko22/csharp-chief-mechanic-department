
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
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddAndClose = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(202, 110);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(370, 29);
            this.textBox_Email.TabIndex = 14;
            // 
            // textBox_PhoneWorkshop
            // 
            this.textBox_PhoneWorkshop.Location = new System.Drawing.Point(202, 65);
            this.textBox_PhoneWorkshop.Name = "textBox_PhoneWorkshop";
            this.textBox_PhoneWorkshop.Size = new System.Drawing.Size(370, 29);
            this.textBox_PhoneWorkshop.TabIndex = 13;
            // 
            // textBox_NameWorkshop
            // 
            this.textBox_NameWorkshop.Location = new System.Drawing.Point(202, 20);
            this.textBox_NameWorkshop.Name = "textBox_NameWorkshop";
            this.textBox_NameWorkshop.Size = new System.Drawing.Size(370, 29);
            this.textBox_NameWorkshop.TabIndex = 12;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(139, 114);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(57, 21);
            this.label_Email.TabIndex = 11;
            this.label_Email.Text = "E-mail:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(63, 69);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(133, 21);
            this.label_Phone.TabIndex = 10;
            this.label_Phone.Text = "Номер телефона:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(76, 24);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(120, 21);
            this.label_Name.TabIndex = 9;
            this.label_Name.Text = "Наименование:";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(392, 170);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(180, 29);
            this.button_Close.TabIndex = 26;
            this.button_Close.Text = "Отмена";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddAndClose
            // 
            this.button_AddAndClose.Location = new System.Drawing.Point(202, 170);
            this.button_AddAndClose.Name = "button_AddAndClose";
            this.button_AddAndClose.Size = new System.Drawing.Size(180, 29);
            this.button_AddAndClose.TabIndex = 25;
            this.button_AddAndClose.Text = "Добавить и закрыть";
            this.button_AddAndClose.UseVisualStyleBackColor = true;
            this.button_AddAndClose.Click += new System.EventHandler(this.button_AddAndClose_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 170);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 29);
            this.button_Add.TabIndex = 24;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AddWorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_AddAndClose);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_PhoneWorkshop);
            this.Controls.Add(this.textBox_NameWorkshop);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Name);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddAndClose;
        private System.Windows.Forms.Button button_Add;
    }
}