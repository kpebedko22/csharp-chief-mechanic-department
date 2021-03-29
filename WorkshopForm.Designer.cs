
namespace OGM
{
    partial class WorkshopForm
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
            this.button_RemoveEquipment = new System.Windows.Forms.Button();
            this.button_EditEquipment = new System.Windows.Forms.Button();
            this.button_AddEquipment = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_PhoneWorkshop = new System.Windows.Forms.TextBox();
            this.textBox_NameWorkshop = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.Column_NameWorkshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_RemoveEquipment
            // 
            this.button_RemoveEquipment.Location = new System.Drawing.Point(436, 135);
            this.button_RemoveEquipment.Name = "button_RemoveEquipment";
            this.button_RemoveEquipment.Size = new System.Drawing.Size(206, 29);
            this.button_RemoveEquipment.TabIndex = 16;
            this.button_RemoveEquipment.Text = "Удалить";
            this.button_RemoveEquipment.UseVisualStyleBackColor = true;
            // 
            // button_EditEquipment
            // 
            this.button_EditEquipment.Location = new System.Drawing.Point(224, 135);
            this.button_EditEquipment.Name = "button_EditEquipment";
            this.button_EditEquipment.Size = new System.Drawing.Size(206, 29);
            this.button_EditEquipment.TabIndex = 15;
            this.button_EditEquipment.Text = "Редактировать";
            this.button_EditEquipment.UseVisualStyleBackColor = true;
            // 
            // button_AddEquipment
            // 
            this.button_AddEquipment.Location = new System.Drawing.Point(12, 135);
            this.button_AddEquipment.Name = "button_AddEquipment";
            this.button_AddEquipment.Size = new System.Drawing.Size(206, 29);
            this.button_AddEquipment.TabIndex = 14;
            this.button_AddEquipment.Text = "Добавить";
            this.button_AddEquipment.UseVisualStyleBackColor = true;
            this.button_AddEquipment.Click += new System.EventHandler(this.button_AddEquipment_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NameWorkshop,
            this.Column_Phone,
            this.Column_Email});
            this.dataGridView.Location = new System.Drawing.Point(12, 170);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(675, 327);
            this.dataGridView.TabIndex = 13;
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.button_Search);
            this.groupBox_Search.Controls.Add(this.textBox_Email);
            this.groupBox_Search.Controls.Add(this.textBox_PhoneWorkshop);
            this.groupBox_Search.Controls.Add(this.textBox_NameWorkshop);
            this.groupBox_Search.Controls.Add(this.label_Email);
            this.groupBox_Search.Controls.Add(this.label_Phone);
            this.groupBox_Search.Controls.Add(this.label_Name);
            this.groupBox_Search.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(683, 111);
            this.groupBox_Search.TabIndex = 12;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Параметры поиска";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(452, 64);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(206, 29);
            this.button_Search.TabIndex = 8;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(452, 22);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(206, 29);
            this.textBox_Email.TabIndex = 6;
            // 
            // textBox_PhoneWorkshop
            // 
            this.textBox_PhoneWorkshop.Location = new System.Drawing.Point(167, 64);
            this.textBox_PhoneWorkshop.Name = "textBox_PhoneWorkshop";
            this.textBox_PhoneWorkshop.Size = new System.Drawing.Size(193, 29);
            this.textBox_PhoneWorkshop.TabIndex = 5;
            // 
            // textBox_NameWorkshop
            // 
            this.textBox_NameWorkshop.Location = new System.Drawing.Point(167, 22);
            this.textBox_NameWorkshop.Name = "textBox_NameWorkshop";
            this.textBox_NameWorkshop.Size = new System.Drawing.Size(193, 29);
            this.textBox_NameWorkshop.TabIndex = 4;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(389, 25);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(57, 21);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "E-mail:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(21, 64);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(133, 21);
            this.label_Phone.TabIndex = 1;
            this.label_Phone.Text = "Номер телефона:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(21, 25);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(120, 21);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Наименование:";
            // 
            // Column_NameWorkshop
            // 
            this.Column_NameWorkshop.HeaderText = "Наименование";
            this.Column_NameWorkshop.Name = "Column_NameWorkshop";
            this.Column_NameWorkshop.ReadOnly = true;
            this.Column_NameWorkshop.Width = 260;
            // 
            // Column_Phone
            // 
            this.Column_Phone.HeaderText = "Номер телефона";
            this.Column_Phone.Name = "Column_Phone";
            this.Column_Phone.ReadOnly = true;
            this.Column_Phone.Width = 170;
            // 
            // Column_Email
            // 
            this.Column_Email.HeaderText = "E-mail";
            this.Column_Email.Name = "Column_Email";
            this.Column_Email.ReadOnly = true;
            this.Column_Email.Width = 200;
            // 
            // WorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 508);
            this.Controls.Add(this.button_RemoveEquipment);
            this.Controls.Add(this.button_EditEquipment);
            this.Controls.Add(this.button_AddEquipment);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox_Search);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WorkshopForm";
            this.Text = "Справочник - Цех";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RemoveEquipment;
        private System.Windows.Forms.Button button_EditEquipment;
        private System.Windows.Forms.Button button_AddEquipment;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_PhoneWorkshop;
        private System.Windows.Forms.TextBox textBox_NameWorkshop;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameWorkshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
    }
}