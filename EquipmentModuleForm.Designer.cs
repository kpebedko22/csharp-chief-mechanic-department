
namespace OGM {
	partial class EquipmentModuleForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem_EquipmentDebit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Add_EquipmentDebit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Find_EquipmentDebit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Handbooks = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Equipment_Handbook = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_GroupEquipment_Handbook = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Workshop_Handbook = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Organization_Handbook = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_ReasonDebit_Handbook = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox_Search = new System.Windows.Forms.GroupBox();
			this.button_ResetSearch = new System.Windows.Forms.Button();
			this.pictureBox_Info = new System.Windows.Forms.PictureBox();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_ActNumber = new System.Windows.Forms.TextBox();
			this.label_ActNumber = new System.Windows.Forms.Label();
			this.dateTimePicker_DateDebit = new System.Windows.Forms.DateTimePicker();
			this.label_DateDebit = new System.Windows.Forms.Label();
			this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
			this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
			this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnActNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnView = new System.Windows.Forms.DataGridViewLinkColumn();
			this.menuStrip.SuspendLayout();
			this.groupBox_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_EquipmentDebit,
            this.ToolStripMenuItem_Handbooks});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(884, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// ToolStripMenuItem_EquipmentDebit
			// 
			this.ToolStripMenuItem_EquipmentDebit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add_EquipmentDebit,
            this.ToolStripMenuItem_Find_EquipmentDebit});
			this.ToolStripMenuItem_EquipmentDebit.Name = "ToolStripMenuItem_EquipmentDebit";
			this.ToolStripMenuItem_EquipmentDebit.Size = new System.Drawing.Size(155, 20);
			this.ToolStripMenuItem_EquipmentDebit.Text = "Списание оборудования";
			// 
			// ToolStripMenuItem_Add_EquipmentDebit
			// 
			this.ToolStripMenuItem_Add_EquipmentDebit.Name = "ToolStripMenuItem_Add_EquipmentDebit";
			this.ToolStripMenuItem_Add_EquipmentDebit.Size = new System.Drawing.Size(126, 22);
			this.ToolStripMenuItem_Add_EquipmentDebit.Text = "Добавить";
			this.ToolStripMenuItem_Add_EquipmentDebit.Click += new System.EventHandler(this.ToolStripMenuItem_Add_EquipmentDebit_Click);
			// 
			// ToolStripMenuItem_Find_EquipmentDebit
			// 
			this.ToolStripMenuItem_Find_EquipmentDebit.Name = "ToolStripMenuItem_Find_EquipmentDebit";
			this.ToolStripMenuItem_Find_EquipmentDebit.Size = new System.Drawing.Size(126, 22);
			this.ToolStripMenuItem_Find_EquipmentDebit.Text = "Найти";
			// 
			// ToolStripMenuItem_Handbooks
			// 
			this.ToolStripMenuItem_Handbooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Equipment_Handbook,
            this.ToolStripMenuItem_GroupEquipment_Handbook,
            this.ToolStripMenuItem_Workshop_Handbook,
            this.ToolStripMenuItem_Organization_Handbook,
            this.ToolStripMenuItem_ReasonDebit_Handbook});
			this.ToolStripMenuItem_Handbooks.Name = "ToolStripMenuItem_Handbooks";
			this.ToolStripMenuItem_Handbooks.Size = new System.Drawing.Size(94, 20);
			this.ToolStripMenuItem_Handbooks.Text = "Справочники";
			// 
			// ToolStripMenuItem_Equipment_Handbook
			// 
			this.ToolStripMenuItem_Equipment_Handbook.Name = "ToolStripMenuItem_Equipment_Handbook";
			this.ToolStripMenuItem_Equipment_Handbook.Size = new System.Drawing.Size(195, 22);
			this.ToolStripMenuItem_Equipment_Handbook.Text = "Оборудование";
			this.ToolStripMenuItem_Equipment_Handbook.Click += new System.EventHandler(this.ToolStripMenuItem_Equipment_Handbook_Click);
			// 
			// ToolStripMenuItem_GroupEquipment_Handbook
			// 
			this.ToolStripMenuItem_GroupEquipment_Handbook.Name = "ToolStripMenuItem_GroupEquipment_Handbook";
			this.ToolStripMenuItem_GroupEquipment_Handbook.Size = new System.Drawing.Size(195, 22);
			this.ToolStripMenuItem_GroupEquipment_Handbook.Text = "Группа оборудования";
			this.ToolStripMenuItem_GroupEquipment_Handbook.Click += new System.EventHandler(this.ToolStripMenuItem_GroupEquipment_Handbook_Click);
			// 
			// ToolStripMenuItem_Workshop_Handbook
			// 
			this.ToolStripMenuItem_Workshop_Handbook.Name = "ToolStripMenuItem_Workshop_Handbook";
			this.ToolStripMenuItem_Workshop_Handbook.Size = new System.Drawing.Size(195, 22);
			this.ToolStripMenuItem_Workshop_Handbook.Text = "Цех";
			this.ToolStripMenuItem_Workshop_Handbook.Click += new System.EventHandler(this.ToolStripMenuItem_Workshop_Handbook_Click);
			// 
			// ToolStripMenuItem_Organization_Handbook
			// 
			this.ToolStripMenuItem_Organization_Handbook.Name = "ToolStripMenuItem_Organization_Handbook";
			this.ToolStripMenuItem_Organization_Handbook.Size = new System.Drawing.Size(195, 22);
			this.ToolStripMenuItem_Organization_Handbook.Text = "Организация";
			this.ToolStripMenuItem_Organization_Handbook.Click += new System.EventHandler(this.ToolStripMenuItem_Organization_Handbook_Click);
			// 
			// ToolStripMenuItem_ReasonDebit_Handbook
			// 
			this.ToolStripMenuItem_ReasonDebit_Handbook.Name = "ToolStripMenuItem_ReasonDebit_Handbook";
			this.ToolStripMenuItem_ReasonDebit_Handbook.Size = new System.Drawing.Size(195, 22);
			this.ToolStripMenuItem_ReasonDebit_Handbook.Text = "Причина списания";
			this.ToolStripMenuItem_ReasonDebit_Handbook.Click += new System.EventHandler(this.ToolStripMenuItem_ReasonDebit_Handbook_Click);
			// 
			// groupBox_Search
			// 
			this.groupBox_Search.Controls.Add(this.button_ResetSearch);
			this.groupBox_Search.Controls.Add(this.pictureBox_Info);
			this.groupBox_Search.Controls.Add(this.button_Search);
			this.groupBox_Search.Controls.Add(this.textBox_ActNumber);
			this.groupBox_Search.Controls.Add(this.label_ActNumber);
			this.groupBox_Search.Controls.Add(this.dateTimePicker_DateDebit);
			this.groupBox_Search.Controls.Add(this.label_DateDebit);
			this.groupBox_Search.Location = new System.Drawing.Point(12, 27);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(860, 141);
			this.groupBox_Search.TabIndex = 1;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска акта (-ов)";
			// 
			// button_ResetSearch
			// 
			this.button_ResetSearch.Location = new System.Drawing.Point(520, 76);
			this.button_ResetSearch.Name = "button_ResetSearch";
			this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
			this.button_ResetSearch.TabIndex = 3;
			this.button_ResetSearch.Text = "Сбросить параметры поиска";
			this.button_ResetSearch.UseVisualStyleBackColor = true;
			this.button_ResetSearch.Click += new System.EventHandler(this.button_ResetSearch_Click);
			// 
			// pictureBox_Info
			// 
			this.pictureBox_Info.Image = global::OGM.Properties.Resources.info;
			this.pictureBox_Info.Location = new System.Drawing.Point(838, 18);
			this.pictureBox_Info.Name = "pictureBox_Info";
			this.pictureBox_Info.Size = new System.Drawing.Size(16, 16);
			this.pictureBox_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Info.TabIndex = 5;
			this.pictureBox_Info.TabStop = false;
			this.toolTip_Info.SetToolTip(this.pictureBox_Info, "Поля необязательны к заполнению.\r\nВы можете выбрать только интересующие Вас парам" +
        "етры.");
			// 
			// button_Search
			// 
			this.button_Search.Location = new System.Drawing.Point(520, 36);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(300, 29);
			this.button_Search.TabIndex = 2;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
			// 
			// textBox_ActNumber
			// 
			this.textBox_ActNumber.Location = new System.Drawing.Point(179, 36);
			this.textBox_ActNumber.Name = "textBox_ActNumber";
			this.textBox_ActNumber.Size = new System.Drawing.Size(200, 29);
			this.textBox_ActNumber.TabIndex = 0;
			// 
			// label_ActNumber
			// 
			this.label_ActNumber.AutoSize = true;
			this.label_ActNumber.Location = new System.Drawing.Point(77, 40);
			this.label_ActNumber.Name = "label_ActNumber";
			this.label_ActNumber.Size = new System.Drawing.Size(96, 21);
			this.label_ActNumber.TabIndex = 2;
			this.label_ActNumber.Text = "Номер акта:";
			// 
			// dateTimePicker_DateDebit
			// 
			this.dateTimePicker_DateDebit.Checked = false;
			this.dateTimePicker_DateDebit.Location = new System.Drawing.Point(179, 76);
			this.dateTimePicker_DateDebit.Name = "dateTimePicker_DateDebit";
			this.dateTimePicker_DateDebit.ShowCheckBox = true;
			this.dateTimePicker_DateDebit.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker_DateDebit.TabIndex = 1;
			// 
			// label_DateDebit
			// 
			this.label_DateDebit.AutoSize = true;
			this.label_DateDebit.Location = new System.Drawing.Point(56, 80);
			this.label_DateDebit.Name = "label_DateDebit";
			this.label_DateDebit.Size = new System.Drawing.Size(117, 21);
			this.label_DateDebit.TabIndex = 0;
			this.label_DateDebit.Text = "Дата списания:";
			// 
			// dataGridView_DataSearch
			// 
			this.dataGridView_DataSearch.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView_DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNum,
            this.ColumnPK,
            this.ColumnActNumber,
            this.ColumnDateDebit,
            this.ColumnView});
			this.dataGridView_DataSearch.Location = new System.Drawing.Point(12, 174);
			this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
			this.dataGridView_DataSearch.Size = new System.Drawing.Size(860, 375);
			this.dataGridView_DataSearch.TabIndex = 4;
			this.dataGridView_DataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DataSearch_CellClick);
			// 
			// ColumnNum
			// 
			this.ColumnNum.HeaderText = "#";
			this.ColumnNum.Name = "ColumnNum";
			// 
			// ColumnPK
			// 
			this.ColumnPK.HeaderText = "Первичный ключ";
			this.ColumnPK.Name = "ColumnPK";
			this.ColumnPK.ReadOnly = true;
			this.ColumnPK.Visible = false;
			// 
			// ColumnActNumber
			// 
			this.ColumnActNumber.HeaderText = "Номер акта";
			this.ColumnActNumber.Name = "ColumnActNumber";
			this.ColumnActNumber.Width = 200;
			// 
			// ColumnDateDebit
			// 
			this.ColumnDateDebit.HeaderText = "Дата списания";
			this.ColumnDateDebit.Name = "ColumnDateDebit";
			this.ColumnDateDebit.Width = 200;
			// 
			// ColumnView
			// 
			this.ColumnView.HeaderText = "";
			this.ColumnView.Name = "ColumnView";
			this.ColumnView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColumnView.Width = 200;
			// 
			// EquipmentModuleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.dataGridView_DataSearch);
			this.Controls.Add(this.groupBox_Search);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EquipmentModuleForm";
			this.Text = "Поиск актов списания оборудования";
			this.Activated += new System.EventHandler(this.EquipmentModuleForm_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EquipmentModuleForm_FormClosed);
			this.Load += new System.EventHandler(this.EquipmentModuleForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.groupBox_Search.ResumeLayout(false);
			this.groupBox_Search.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EquipmentDebit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Handbooks;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add_EquipmentDebit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Find_EquipmentDebit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Equipment_Handbook;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_GroupEquipment_Handbook;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Workshop_Handbook;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Organization_Handbook;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ReasonDebit_Handbook;
		private System.Windows.Forms.GroupBox groupBox_Search;
		private System.Windows.Forms.Label label_DateDebit;
		private System.Windows.Forms.DateTimePicker dateTimePicker_DateDebit;
		private System.Windows.Forms.Label label_ActNumber;
		private System.Windows.Forms.TextBox textBox_ActNumber;
		private System.Windows.Forms.Button button_Search;
		private System.Windows.Forms.ToolTip toolTip_Info;
		private System.Windows.Forms.PictureBox pictureBox_Info;
		private System.Windows.Forms.DataGridView dataGridView_DataSearch;
		private System.Windows.Forms.Button button_ResetSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPK;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateDebit;
		private System.Windows.Forms.DataGridViewLinkColumn ColumnView;
	}
}