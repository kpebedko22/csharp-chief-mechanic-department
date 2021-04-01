
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
			this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
			this.groupBox_Search = new System.Windows.Forms.GroupBox();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_Email = new System.Windows.Forms.TextBox();
			this.textBox_PhoneWorkshop = new System.Windows.Forms.TextBox();
			this.textBox_NameWorkshop = new System.Windows.Forms.TextBox();
			this.label_Email = new System.Windows.Forms.Label();
			this.label_Phone = new System.Windows.Forms.Label();
			this.label_Name = new System.Windows.Forms.Label();
			this.button_ResetSearch = new System.Windows.Forms.Button();
			this.Column_NameWorkshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
			this.groupBox_Search.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_RemoveEquipment
			// 
			this.button_RemoveEquipment.Location = new System.Drawing.Point(424, 190);
			this.button_RemoveEquipment.Name = "button_RemoveEquipment";
			this.button_RemoveEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_RemoveEquipment.TabIndex = 7;
			this.button_RemoveEquipment.Text = "Удалить";
			this.button_RemoveEquipment.UseVisualStyleBackColor = true;
			// 
			// button_EditEquipment
			// 
			this.button_EditEquipment.Location = new System.Drawing.Point(218, 190);
			this.button_EditEquipment.Name = "button_EditEquipment";
			this.button_EditEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_EditEquipment.TabIndex = 6;
			this.button_EditEquipment.Text = "Редактировать";
			this.button_EditEquipment.UseVisualStyleBackColor = true;
			// 
			// button_AddEquipment
			// 
			this.button_AddEquipment.Location = new System.Drawing.Point(12, 190);
			this.button_AddEquipment.Name = "button_AddEquipment";
			this.button_AddEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_AddEquipment.TabIndex = 5;
			this.button_AddEquipment.Text = "Добавить";
			this.button_AddEquipment.UseVisualStyleBackColor = true;
			this.button_AddEquipment.Click += new System.EventHandler(this.button_AddEquipment_Click);
			// 
			// dataGridView_DataSearch
			// 
			this.dataGridView_DataSearch.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView_DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NameWorkshop,
            this.Column_Phone,
            this.Column_Email});
			this.dataGridView_DataSearch.Location = new System.Drawing.Point(12, 239);
			this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
			this.dataGridView_DataSearch.Size = new System.Drawing.Size(860, 310);
			this.dataGridView_DataSearch.TabIndex = 8;
			// 
			// groupBox_Search
			// 
			this.groupBox_Search.Controls.Add(this.button_ResetSearch);
			this.groupBox_Search.Controls.Add(this.button_Search);
			this.groupBox_Search.Controls.Add(this.textBox_Email);
			this.groupBox_Search.Controls.Add(this.textBox_PhoneWorkshop);
			this.groupBox_Search.Controls.Add(this.textBox_NameWorkshop);
			this.groupBox_Search.Controls.Add(this.label_Email);
			this.groupBox_Search.Controls.Add(this.label_Phone);
			this.groupBox_Search.Controls.Add(this.label_Name);
			this.groupBox_Search.Location = new System.Drawing.Point(12, 12);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(860, 162);
			this.groupBox_Search.TabIndex = 12;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска";
			// 
			// button_Search
			// 
			this.button_Search.Location = new System.Drawing.Point(520, 36);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(300, 29);
			this.button_Search.TabIndex = 3;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
			// 
			// textBox_Email
			// 
			this.textBox_Email.Location = new System.Drawing.Point(179, 116);
			this.textBox_Email.Name = "textBox_Email";
			this.textBox_Email.Size = new System.Drawing.Size(200, 29);
			this.textBox_Email.TabIndex = 2;
			// 
			// textBox_PhoneWorkshop
			// 
			this.textBox_PhoneWorkshop.Location = new System.Drawing.Point(179, 76);
			this.textBox_PhoneWorkshop.Name = "textBox_PhoneWorkshop";
			this.textBox_PhoneWorkshop.Size = new System.Drawing.Size(200, 29);
			this.textBox_PhoneWorkshop.TabIndex = 1;
			// 
			// textBox_NameWorkshop
			// 
			this.textBox_NameWorkshop.Location = new System.Drawing.Point(179, 36);
			this.textBox_NameWorkshop.Name = "textBox_NameWorkshop";
			this.textBox_NameWorkshop.Size = new System.Drawing.Size(200, 29);
			this.textBox_NameWorkshop.TabIndex = 0;
			// 
			// label_Email
			// 
			this.label_Email.AutoSize = true;
			this.label_Email.Location = new System.Drawing.Point(116, 120);
			this.label_Email.Name = "label_Email";
			this.label_Email.Size = new System.Drawing.Size(57, 21);
			this.label_Email.TabIndex = 2;
			this.label_Email.Text = "E-mail:";
			// 
			// label_Phone
			// 
			this.label_Phone.AutoSize = true;
			this.label_Phone.Location = new System.Drawing.Point(40, 80);
			this.label_Phone.Name = "label_Phone";
			this.label_Phone.Size = new System.Drawing.Size(133, 21);
			this.label_Phone.TabIndex = 1;
			this.label_Phone.Text = "Номер телефона:";
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Location = new System.Drawing.Point(53, 40);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(120, 21);
			this.label_Name.TabIndex = 0;
			this.label_Name.Text = "Наименование:";
			// 
			// button_ResetSearch
			// 
			this.button_ResetSearch.Location = new System.Drawing.Point(520, 76);
			this.button_ResetSearch.Name = "button_ResetSearch";
			this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
			this.button_ResetSearch.TabIndex = 4;
			this.button_ResetSearch.Text = "Сбросить параметры поиска";
			this.button_ResetSearch.UseVisualStyleBackColor = true;
			this.button_ResetSearch.Click += new System.EventHandler(this.button_Search_Click);
			// 
			// Column_NameWorkshop
			// 
			this.Column_NameWorkshop.HeaderText = "Наименование";
			this.Column_NameWorkshop.Name = "Column_NameWorkshop";
			this.Column_NameWorkshop.ReadOnly = true;
			this.Column_NameWorkshop.Width = 300;
			// 
			// Column_Phone
			// 
			this.Column_Phone.HeaderText = "Номер телефона";
			this.Column_Phone.Name = "Column_Phone";
			this.Column_Phone.ReadOnly = true;
			this.Column_Phone.Width = 200;
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
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.button_RemoveEquipment);
			this.Controls.Add(this.button_EditEquipment);
			this.Controls.Add(this.button_AddEquipment);
			this.Controls.Add(this.dataGridView_DataSearch);
			this.Controls.Add(this.groupBox_Search);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WorkshopForm";
			this.Text = "Справочник - Цех";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).EndInit();
			this.groupBox_Search.ResumeLayout(false);
			this.groupBox_Search.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RemoveEquipment;
        private System.Windows.Forms.Button button_EditEquipment;
        private System.Windows.Forms.Button button_AddEquipment;
        private System.Windows.Forms.DataGridView dataGridView_DataSearch;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_PhoneWorkshop;
        private System.Windows.Forms.TextBox textBox_NameWorkshop;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Name;
		private System.Windows.Forms.Button button_ResetSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameWorkshop;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
	}
}