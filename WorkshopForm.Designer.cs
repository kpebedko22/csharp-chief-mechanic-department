
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
			this.Column_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_NameWorkshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox_Search = new System.Windows.Forms.GroupBox();
			this.button_ResetSearch = new System.Windows.Forms.Button();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_Email = new System.Windows.Forms.TextBox();
			this.textBox_PhoneWorkshop = new System.Windows.Forms.TextBox();
			this.textBox_NameWorkshop = new System.Windows.Forms.TextBox();
			this.label_Email = new System.Windows.Forms.Label();
			this.label_Phone = new System.Windows.Forms.Label();
			this.label_Name = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
			this.groupBox_Search.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_RemoveEquipment
			// 
			this.button_RemoveEquipment.Location = new System.Drawing.Point(415, 3);
			this.button_RemoveEquipment.Name = "button_RemoveEquipment";
			this.button_RemoveEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_RemoveEquipment.TabIndex = 7;
			this.button_RemoveEquipment.Text = "Удалить";
			this.button_RemoveEquipment.UseVisualStyleBackColor = true;
			this.button_RemoveEquipment.Click += new System.EventHandler(this.button_RemoveEquipment_Click);
			// 
			// button_EditEquipment
			// 
			this.button_EditEquipment.Location = new System.Drawing.Point(209, 3);
			this.button_EditEquipment.Name = "button_EditEquipment";
			this.button_EditEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_EditEquipment.TabIndex = 6;
			this.button_EditEquipment.Text = "Редактировать";
			this.button_EditEquipment.UseVisualStyleBackColor = true;
			this.button_EditEquipment.Click += new System.EventHandler(this.button_EditEquipment_Click);
			// 
			// button_AddEquipment
			// 
			this.button_AddEquipment.Location = new System.Drawing.Point(3, 3);
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
            this.Column_PK,
            this.Column_NameWorkshop,
            this.Column_Phone,
            this.Column_Email});
			this.dataGridView_DataSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_DataSearch.Location = new System.Drawing.Point(6, 217);
			this.dataGridView_DataSearch.Margin = new System.Windows.Forms.Padding(6);
			this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
			this.dataGridView_DataSearch.ReadOnly = true;
			this.dataGridView_DataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_DataSearch.Size = new System.Drawing.Size(872, 338);
			this.dataGridView_DataSearch.TabIndex = 8;
			// 
			// Column_PK
			// 
			this.Column_PK.HeaderText = "Первичный ключ";
			this.Column_PK.Name = "Column_PK";
			this.Column_PK.ReadOnly = true;
			this.Column_PK.Visible = false;
			// 
			// Column_NameWorkshop
			// 
			this.Column_NameWorkshop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_NameWorkshop.HeaderText = "Наименование";
			this.Column_NameWorkshop.Name = "Column_NameWorkshop";
			this.Column_NameWorkshop.ReadOnly = true;
			// 
			// Column_Phone
			// 
			this.Column_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_Phone.HeaderText = "Номер телефона";
			this.Column_Phone.Name = "Column_Phone";
			this.Column_Phone.ReadOnly = true;
			// 
			// Column_Email
			// 
			this.Column_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_Email.HeaderText = "E-mail";
			this.Column_Email.Name = "Column_Email";
			this.Column_Email.ReadOnly = true;
			// 
			// groupBox_Search
			// 
			this.groupBox_Search.Controls.Add(this.tableLayoutPanel2);
			this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_Search.Location = new System.Drawing.Point(6, 6);
			this.groupBox_Search.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(872, 158);
			this.groupBox_Search.TabIndex = 12;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска";
			// 
			// button_ResetSearch
			// 
			this.button_ResetSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_ResetSearch.Location = new System.Drawing.Point(498, 47);
			this.button_ResetSearch.Margin = new System.Windows.Forms.Padding(6);
			this.button_ResetSearch.Name = "button_ResetSearch";
			this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
			this.button_ResetSearch.TabIndex = 4;
			this.button_ResetSearch.Text = "Сбросить параметры поиска";
			this.button_ResetSearch.UseVisualStyleBackColor = true;
			this.button_ResetSearch.Click += new System.EventHandler(this.button_ResetSearch_Click);
			// 
			// button_Search
			// 
			this.button_Search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_Search.Location = new System.Drawing.Point(498, 6);
			this.button_Search.Margin = new System.Windows.Forms.Padding(6);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(300, 29);
			this.button_Search.TabIndex = 3;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
			// 
			// textBox_Email
			// 
			this.textBox_Email.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_Email.Location = new System.Drawing.Point(205, 88);
			this.textBox_Email.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_Email.Name = "textBox_Email";
			this.textBox_Email.Size = new System.Drawing.Size(200, 29);
			this.textBox_Email.TabIndex = 2;
			// 
			// textBox_PhoneWorkshop
			// 
			this.textBox_PhoneWorkshop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_PhoneWorkshop.Location = new System.Drawing.Point(205, 47);
			this.textBox_PhoneWorkshop.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_PhoneWorkshop.Name = "textBox_PhoneWorkshop";
			this.textBox_PhoneWorkshop.Size = new System.Drawing.Size(200, 29);
			this.textBox_PhoneWorkshop.TabIndex = 1;
			// 
			// textBox_NameWorkshop
			// 
			this.textBox_NameWorkshop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_NameWorkshop.Location = new System.Drawing.Point(205, 6);
			this.textBox_NameWorkshop.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_NameWorkshop.Name = "textBox_NameWorkshop";
			this.textBox_NameWorkshop.Size = new System.Drawing.Size(200, 29);
			this.textBox_NameWorkshop.TabIndex = 0;
			// 
			// label_Email
			// 
			this.label_Email.AutoSize = true;
			this.label_Email.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Email.Location = new System.Drawing.Point(139, 82);
			this.label_Email.Name = "label_Email";
			this.label_Email.Size = new System.Drawing.Size(57, 41);
			this.label_Email.TabIndex = 2;
			this.label_Email.Text = "E-mail:";
			this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_Phone
			// 
			this.label_Phone.AutoSize = true;
			this.label_Phone.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Phone.Location = new System.Drawing.Point(63, 41);
			this.label_Phone.Name = "label_Phone";
			this.label_Phone.Size = new System.Drawing.Size(133, 41);
			this.label_Phone.TabIndex = 1;
			this.label_Phone.Text = "Номер телефона:";
			this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Name.Location = new System.Drawing.Point(76, 0);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(120, 41);
			this.label_Name.TabIndex = 0;
			this.label_Name.Text = "Наименование:";
			this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 561);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.button_AddEquipment);
			this.flowLayoutPanel1.Controls.Add(this.button_EditEquipment);
			this.flowLayoutPanel1.Controls.Add(this.button_RemoveEquipment);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 173);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 35);
			this.flowLayoutPanel1.TabIndex = 14;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 6;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.Controls.Add(this.label_Name, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.button_ResetSearch, 4, 1);
			this.tableLayoutPanel2.Controls.Add(this.label_Phone, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.button_Search, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.label_Email, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBox_Email, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBox_NameWorkshop, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox_PhoneWorkshop, 2, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(866, 130);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// WorkshopForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(900, 600);
			this.Name = "WorkshopForm";
			this.ShowIcon = false;
			this.Text = "Справочник - Цех";
			this.Activated += new System.EventHandler(this.WorkshopForm_Activated);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).EndInit();
			this.groupBox_Search.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameWorkshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}