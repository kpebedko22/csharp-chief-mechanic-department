
namespace OGM
{
    partial class AddGroupEquipment
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_AddGroupEquipmentAndClose = new System.Windows.Forms.Button();
            this.button_AddGroupEquipment = new System.Windows.Forms.Button();
            this.textBox_Cipher = new System.Windows.Forms.TextBox();
            this.textBox_NameEquipment = new System.Windows.Forms.TextBox();
            this.label_Cipher = new System.Windows.Forms.Label();
            this.label_NameEquipment = new System.Windows.Forms.Label();
            this.label_Workshop = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(391, 170);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(180, 29);
            this.button_Cancel.TabIndex = 30;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_AddGroupEquipmentAndClose
            // 
            this.button_AddGroupEquipmentAndClose.Location = new System.Drawing.Point(202, 170);
            this.button_AddGroupEquipmentAndClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddGroupEquipmentAndClose.Name = "button_AddGroupEquipmentAndClose";
            this.button_AddGroupEquipmentAndClose.Size = new System.Drawing.Size(180, 29);
            this.button_AddGroupEquipmentAndClose.TabIndex = 29;
            this.button_AddGroupEquipmentAndClose.Text = "Добавить и закрыть";
            this.button_AddGroupEquipmentAndClose.UseVisualStyleBackColor = true;
            this.button_AddGroupEquipmentAndClose.Click += new System.EventHandler(this.button_AddGroupEquipmentAndClose_Click);
            // 
            // button_AddGroupEquipment
            // 
            this.button_AddGroupEquipment.Location = new System.Drawing.Point(13, 170);
            this.button_AddGroupEquipment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddGroupEquipment.Name = "button_AddGroupEquipment";
            this.button_AddGroupEquipment.Size = new System.Drawing.Size(180, 29);
            this.button_AddGroupEquipment.TabIndex = 28;
            this.button_AddGroupEquipment.Text = "Добавить";
            this.button_AddGroupEquipment.UseVisualStyleBackColor = true;
            this.button_AddGroupEquipment.Click += new System.EventHandler(this.button_AddGroupEquipment_Click);
            // 
            // textBox_Cipher
            // 
            this.textBox_Cipher.Location = new System.Drawing.Point(202, 65);
            this.textBox_Cipher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Cipher.Name = "textBox_Cipher";
            this.textBox_Cipher.Size = new System.Drawing.Size(370, 29);
            this.textBox_Cipher.TabIndex = 27;
            // 
            // textBox_NameEquipment
            // 
            this.textBox_NameEquipment.Location = new System.Drawing.Point(202, 20);
            this.textBox_NameEquipment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_NameEquipment.Name = "textBox_NameEquipment";
            this.textBox_NameEquipment.Size = new System.Drawing.Size(370, 29);
            this.textBox_NameEquipment.TabIndex = 26;
            // 
            // label_Cipher
            // 
            this.label_Cipher.AutoSize = true;
            this.label_Cipher.Location = new System.Drawing.Point(137, 69);
            this.label_Cipher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Cipher.Name = "label_Cipher";
            this.label_Cipher.Size = new System.Drawing.Size(57, 21);
            this.label_Cipher.TabIndex = 25;
            this.label_Cipher.Text = "Шифр:";
            // 
            // label_NameEquipment
            // 
            this.label_NameEquipment.AutoSize = true;
            this.label_NameEquipment.Location = new System.Drawing.Point(74, 24);
            this.label_NameEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NameEquipment.Name = "label_NameEquipment";
            this.label_NameEquipment.Size = new System.Drawing.Size(120, 21);
            this.label_NameEquipment.TabIndex = 24;
            this.label_NameEquipment.Text = "Наименование:";
            // 
            // label_Workshop
            // 
            this.label_Workshop.AutoSize = true;
            this.label_Workshop.Location = new System.Drawing.Point(155, 114);
            this.label_Workshop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Workshop.Name = "label_Workshop";
            this.label_Workshop.Size = new System.Drawing.Size(40, 21);
            this.label_Workshop.TabIndex = 31;
            this.label_Workshop.Text = "Цех:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 29);
            this.comboBox1.TabIndex = 32;
            // 
            // AddGroupEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_Workshop);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddGroupEquipmentAndClose);
            this.Controls.Add(this.button_AddGroupEquipment);
            this.Controls.Add(this.textBox_Cipher);
            this.Controls.Add(this.textBox_NameEquipment);
            this.Controls.Add(this.label_Cipher);
            this.Controls.Add(this.label_NameEquipment);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroupEquipment";
            this.Text = "Справочник - Добавить группу оборудования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_AddGroupEquipmentAndClose;
        private System.Windows.Forms.Button button_AddGroupEquipment;
        private System.Windows.Forms.TextBox textBox_Cipher;
        private System.Windows.Forms.TextBox textBox_NameEquipment;
        private System.Windows.Forms.Label label_Cipher;
        private System.Windows.Forms.Label label_NameEquipment;
        private System.Windows.Forms.Label label_Workshop;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}