
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
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_File_ExitModule = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_File_ExitProg = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ActNumber = new System.Windows.Forms.Label();
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.button_ResetSearch = new System.Windows.Forms.Button();
            this.label_DateDebit = new System.Windows.Forms.Label();
            this.textBox_ActNumber = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.dateTimePicker_DateDebit_From = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_DateDebit_To = new System.Windows.Forms.DateTimePicker();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnView = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_EquipmentDebit,
            this.ToolStripMenuItem_Handbooks});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File_ExitModule,
            this.ToolStripMenuItem_File_ExitProg});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItem_File.Text = "Файл";
            // 
            // ToolStripMenuItem_File_ExitModule
            // 
            this.ToolStripMenuItem_File_ExitModule.Name = "ToolStripMenuItem_File_ExitModule";
            this.ToolStripMenuItem_File_ExitModule.Size = new System.Drawing.Size(193, 22);
            this.ToolStripMenuItem_File_ExitModule.Text = "Выйти из модуля";
            this.ToolStripMenuItem_File_ExitModule.Click += new System.EventHandler(this.ToolStripMenuItem_File_ExitModule_Click);
            // 
            // ToolStripMenuItem_File_ExitProg
            // 
            this.ToolStripMenuItem_File_ExitProg.Name = "ToolStripMenuItem_File_ExitProg";
            this.ToolStripMenuItem_File_ExitProg.Size = new System.Drawing.Size(193, 22);
            this.ToolStripMenuItem_File_ExitProg.Text = "Выйти из программы";
            this.ToolStripMenuItem_File_ExitProg.Click += new System.EventHandler(this.ToolStripMenuItem_File_ExitProg_Click);
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
            this.ToolStripMenuItem_Find_EquipmentDebit.Enabled = false;
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
            this.groupBox_Search.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Search.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(878, 194);
            this.groupBox_Search.TabIndex = 1;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Параметры поиска акта (-ов)";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label_ActNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_Info, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_ResetSearch, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_DateDebit, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_ActNumber, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Search, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_DateDebit_From, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_DateDebit_To, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(872, 166);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label_ActNumber
            // 
            this.label_ActNumber.AutoSize = true;
            this.label_ActNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_ActNumber.Location = new System.Drawing.Point(98, 0);
            this.label_ActNumber.Name = "label_ActNumber";
            this.label_ActNumber.Size = new System.Drawing.Size(93, 41);
            this.label_ActNumber.TabIndex = 2;
            this.label_ActNumber.Text = "Номер акта";
            this.label_ActNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.Image = global::OGM.Properties.Resources.info;
            this.pictureBox_Info.Location = new System.Drawing.Point(851, 3);
            this.pictureBox_Info.Name = "pictureBox_Info";
            this.pictureBox_Info.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Info.TabIndex = 5;
            this.pictureBox_Info.TabStop = false;
            this.toolTip_Info.SetToolTip(this.pictureBox_Info, "Поля необязательны к заполнению.\r\nВы можете выбрать только интересующие Вас парам" +
        "етры.");
            // 
            // button_ResetSearch
            // 
            this.button_ResetSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ResetSearch.Location = new System.Drawing.Point(490, 47);
            this.button_ResetSearch.Margin = new System.Windows.Forms.Padding(6);
            this.button_ResetSearch.Name = "button_ResetSearch";
            this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
            this.button_ResetSearch.TabIndex = 3;
            this.button_ResetSearch.Text = "Сбросить параметры поиска";
            this.button_ResetSearch.UseVisualStyleBackColor = true;
            this.button_ResetSearch.Click += new System.EventHandler(this.button_ResetSearch_Click);
            // 
            // label_DateDebit
            // 
            this.label_DateDebit.AutoSize = true;
            this.label_DateDebit.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_DateDebit.Location = new System.Drawing.Point(57, 41);
            this.label_DateDebit.Name = "label_DateDebit";
            this.label_DateDebit.Size = new System.Drawing.Size(134, 41);
            this.label_DateDebit.TabIndex = 0;
            this.label_DateDebit.Text = "Дата списания от";
            this.label_DateDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ActNumber
            // 
            this.textBox_ActNumber.Location = new System.Drawing.Point(200, 6);
            this.textBox_ActNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_ActNumber.Name = "textBox_ActNumber";
            this.textBox_ActNumber.Size = new System.Drawing.Size(200, 29);
            this.textBox_ActNumber.TabIndex = 0;
            // 
            // button_Search
            // 
            this.button_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Search.Location = new System.Drawing.Point(490, 6);
            this.button_Search.Margin = new System.Windows.Forms.Padding(6);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(300, 29);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dateTimePicker_DateDebit_From
            // 
            this.dateTimePicker_DateDebit_From.Checked = false;
            this.dateTimePicker_DateDebit_From.Location = new System.Drawing.Point(200, 47);
            this.dateTimePicker_DateDebit_From.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker_DateDebit_From.Name = "dateTimePicker_DateDebit_From";
            this.dateTimePicker_DateDebit_From.ShowCheckBox = true;
            this.dateTimePicker_DateDebit_From.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_DateDebit_From.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата списания до";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_DateDebit_To
            // 
            this.dateTimePicker_DateDebit_To.Checked = false;
            this.dateTimePicker_DateDebit_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_DateDebit_To.Location = new System.Drawing.Point(200, 88);
            this.dateTimePicker_DateDebit_To.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker_DateDebit_To.Name = "dateTimePicker_DateDebit_To";
            this.dateTimePicker_DateDebit_To.ShowCheckBox = true;
            this.dateTimePicker_DateDebit_To.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_DateDebit_To.TabIndex = 7;
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
            this.dataGridView_DataSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DataSearch.Location = new System.Drawing.Point(3, 203);
            this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
            this.dataGridView_DataSearch.Size = new System.Drawing.Size(878, 331);
            this.dataGridView_DataSearch.TabIndex = 4;
            this.dataGridView_DataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DataSearch_CellClick);
            this.dataGridView_DataSearch.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_DataSearch_RowPostPaint);
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
            this.ColumnActNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnActNumber.HeaderText = "Номер акта";
            this.ColumnActNumber.Name = "ColumnActNumber";
            // 
            // ColumnDateDebit
            // 
            this.ColumnDateDebit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateDebit.HeaderText = "Дата списания";
            this.ColumnDateDebit.Name = "ColumnDateDebit";
            // 
            // ColumnView
            // 
            this.ColumnView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnView.HeaderText = "";
            this.ColumnView.Name = "ColumnView";
            this.ColumnView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnView.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_DataSearch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Search, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 537);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // EquipmentModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "EquipmentModuleForm";
            this.ShowIcon = false;
            this.Text = "Поиск актов списания оборудования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EquipmentModuleForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_Search.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
		private System.Windows.Forms.DateTimePicker dateTimePicker_DateDebit_From;
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_ExitModule;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_ExitProg;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker_DateDebit_To;
	}
}