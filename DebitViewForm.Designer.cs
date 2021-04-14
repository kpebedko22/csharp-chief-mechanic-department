
namespace OGM {
	partial class DebitViewForm {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Export_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label_ActDebitNum = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWorkshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInventoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReasonDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ActNumber = new System.Windows.Forms.TextBox();
            this.textBox_ActTotalPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ActDate = new System.Windows.Forms.DateTimePicker();
            this.tabPageExportData = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Organization = new System.Windows.Forms.ComboBox();
            this.textBox_FIO_DeputyDirector = new System.Windows.Forms.TextBox();
            this.textBox_FIO_HeadProcurement = new System.Windows.Forms.TextBox();
            this.textBox_FIO_Engineer = new System.Windows.Forms.TextBox();
            this.textBox_FIO_DeputyAccountant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FIO_MainMechanic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Export = new System.Windows.Forms.Button();
            this.checkBox_OpenFileExport = new System.Windows.Forms.CheckBox();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageExportData.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(784, 20);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Export_File});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(48, 19);
            this.ToolStripMenuItem_File.Text = "Файл";
            // 
            // ToolStripMenuItem_Export_File
            // 
            this.ToolStripMenuItem_Export_File.Name = "ToolStripMenuItem_Export_File";
            this.ToolStripMenuItem_Export_File.Size = new System.Drawing.Size(119, 22);
            this.ToolStripMenuItem_Export_File.Text = "Экспорт";
            this.ToolStripMenuItem_Export_File.Click += new System.EventHandler(this.ToolStripMenuItem_Export_File_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Edit_Edit,
            this.ToolStripMenuItem_Delete_Edit});
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(59, 19);
            this.ToolStripMenuItem_Edit.Text = "Правка";
            // 
            // ToolStripMenuItem_Edit_Edit
            // 
            this.ToolStripMenuItem_Edit_Edit.Name = "ToolStripMenuItem_Edit_Edit";
            this.ToolStripMenuItem_Edit_Edit.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_Edit_Edit.Text = "Редактирование";
            // 
            // ToolStripMenuItem_Delete_Edit
            // 
            this.ToolStripMenuItem_Delete_Edit.Name = "ToolStripMenuItem_Delete_Edit";
            this.ToolStripMenuItem_Delete_Edit.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_Delete_Edit.Text = "Удаление";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.label_ActDebitNum, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(784, 494);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // label_ActDebitNum
            // 
            this.label_ActDebitNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ActDebitNum.AutoSize = true;
            this.label_ActDebitNum.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ActDebitNum.Location = new System.Drawing.Point(236, 12);
            this.label_ActDebitNum.Name = "label_ActDebitNum";
            this.label_ActDebitNum.Size = new System.Drawing.Size(312, 26);
            this.label_ActDebitNum.TabIndex = 0;
            this.label_ActDebitNum.Text = "Акт списания оборудования №";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPageExportData);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 53);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(778, 438);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спецификация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Data, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.AllowUserToAddRows = false;
            this.dataGridView_Data.AllowUserToDeleteRows = false;
            this.dataGridView_Data.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnWorkshop,
            this.ColumnGroup,
            this.ColumnInventoryNumber,
            this.ColumnEquipmentName,
            this.ColumnCost,
            this.ColumnReasonDebit});
            this.dataGridView_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Data.Location = new System.Drawing.Point(3, 103);
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.ReadOnly = true;
            this.dataGridView_Data.Size = new System.Drawing.Size(758, 292);
            this.dataGridView_Data.TabIndex = 1;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnIndex.HeaderText = "#";
            this.ColumnIndex.MinimumWidth = 50;
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.Visible = false;
            // 
            // ColumnWorkshop
            // 
            this.ColumnWorkshop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnWorkshop.HeaderText = "Цех";
            this.ColumnWorkshop.Name = "ColumnWorkshop";
            this.ColumnWorkshop.ReadOnly = true;
            // 
            // ColumnGroup
            // 
            this.ColumnGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnGroup.HeaderText = "Группа оборудования";
            this.ColumnGroup.Name = "ColumnGroup";
            this.ColumnGroup.ReadOnly = true;
            // 
            // ColumnInventoryNumber
            // 
            this.ColumnInventoryNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInventoryNumber.HeaderText = "Инвентарный номер";
            this.ColumnInventoryNumber.Name = "ColumnInventoryNumber";
            this.ColumnInventoryNumber.ReadOnly = true;
            // 
            // ColumnEquipmentName
            // 
            this.ColumnEquipmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEquipmentName.HeaderText = "Наименование оборудования";
            this.ColumnEquipmentName.Name = "ColumnEquipmentName";
            this.ColumnEquipmentName.ReadOnly = true;
            // 
            // ColumnCost
            // 
            this.ColumnCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCost.HeaderText = "Остаточная стоимость";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            // 
            // ColumnReasonDebit
            // 
            this.ColumnReasonDebit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnReasonDebit.HeaderText = "Причина списания";
            this.ColumnReasonDebit.Name = "ColumnReasonDebit";
            this.ColumnReasonDebit.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_ActNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_ActTotalPrice, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_ActDate, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 94);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Номер акта списания";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(18, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "Дата акта списания";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(350, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 35);
            this.label8.TabIndex = 2;
            this.label8.Text = "Стоимость списания";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ActNumber
            // 
            this.textBox_ActNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ActNumber.Enabled = false;
            this.textBox_ActNumber.Location = new System.Drawing.Point(173, 3);
            this.textBox_ActNumber.Name = "textBox_ActNumber";
            this.textBox_ActNumber.Size = new System.Drawing.Size(164, 29);
            this.textBox_ActNumber.TabIndex = 3;
            // 
            // textBox_ActTotalPrice
            // 
            this.textBox_ActTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ActTotalPrice.Enabled = false;
            this.textBox_ActTotalPrice.Location = new System.Drawing.Point(513, 3);
            this.textBox_ActTotalPrice.Name = "textBox_ActTotalPrice";
            this.textBox_ActTotalPrice.Size = new System.Drawing.Size(164, 29);
            this.textBox_ActTotalPrice.TabIndex = 4;
            // 
            // dateTimePicker_ActDate
            // 
            this.dateTimePicker_ActDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_ActDate.Enabled = false;
            this.dateTimePicker_ActDate.Location = new System.Drawing.Point(173, 38);
            this.dateTimePicker_ActDate.Name = "dateTimePicker_ActDate";
            this.dateTimePicker_ActDate.Size = new System.Drawing.Size(164, 29);
            this.dateTimePicker_ActDate.TabIndex = 5;
            // 
            // tabPageExportData
            // 
            this.tabPageExportData.Controls.Add(this.tableLayoutPanel3);
            this.tabPageExportData.Controls.Add(this.flowLayoutPanel1);
            this.tabPageExportData.Location = new System.Drawing.Point(4, 30);
            this.tabPageExportData.Name = "tabPageExportData";
            this.tabPageExportData.Size = new System.Drawing.Size(770, 396);
            this.tabPageExportData.TabIndex = 2;
            this.tabPageExportData.Text = "Данные для экспорта";
            this.tabPageExportData.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_Organization, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_FIO_DeputyDirector, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox_FIO_HeadProcurement, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBox_FIO_Engineer, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.textBox_FIO_DeputyAccountant, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.textBox_FIO_MainMechanic, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.progressBar, 1, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(770, 361);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(292, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Организация";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_Organization
            // 
            this.comboBox_Organization.FormattingEnabled = true;
            this.comboBox_Organization.Location = new System.Drawing.Point(409, 35);
            this.comboBox_Organization.Margin = new System.Windows.Forms.Padding(9);
            this.comboBox_Organization.Name = "comboBox_Organization";
            this.comboBox_Organization.Size = new System.Drawing.Size(250, 29);
            this.comboBox_Organization.TabIndex = 0;
            // 
            // textBox_FIO_DeputyDirector
            // 
            this.textBox_FIO_DeputyDirector.Location = new System.Drawing.Point(409, 121);
            this.textBox_FIO_DeputyDirector.Margin = new System.Windows.Forms.Padding(9);
            this.textBox_FIO_DeputyDirector.MaxLength = 250;
            this.textBox_FIO_DeputyDirector.Name = "textBox_FIO_DeputyDirector";
            this.textBox_FIO_DeputyDirector.Size = new System.Drawing.Size(250, 29);
            this.textBox_FIO_DeputyDirector.TabIndex = 2;
            // 
            // textBox_FIO_HeadProcurement
            // 
            this.textBox_FIO_HeadProcurement.Location = new System.Drawing.Point(409, 168);
            this.textBox_FIO_HeadProcurement.Margin = new System.Windows.Forms.Padding(9);
            this.textBox_FIO_HeadProcurement.MaxLength = 250;
            this.textBox_FIO_HeadProcurement.Name = "textBox_FIO_HeadProcurement";
            this.textBox_FIO_HeadProcurement.Size = new System.Drawing.Size(250, 29);
            this.textBox_FIO_HeadProcurement.TabIndex = 3;
            // 
            // textBox_FIO_Engineer
            // 
            this.textBox_FIO_Engineer.Location = new System.Drawing.Point(409, 215);
            this.textBox_FIO_Engineer.Margin = new System.Windows.Forms.Padding(9);
            this.textBox_FIO_Engineer.MaxLength = 250;
            this.textBox_FIO_Engineer.Name = "textBox_FIO_Engineer";
            this.textBox_FIO_Engineer.Size = new System.Drawing.Size(250, 29);
            this.textBox_FIO_Engineer.TabIndex = 4;
            // 
            // textBox_FIO_DeputyAccountant
            // 
            this.textBox_FIO_DeputyAccountant.Location = new System.Drawing.Point(409, 262);
            this.textBox_FIO_DeputyAccountant.Margin = new System.Windows.Forms.Padding(9);
            this.textBox_FIO_DeputyAccountant.MaxLength = 250;
            this.textBox_FIO_DeputyAccountant.Name = "textBox_FIO_DeputyAccountant";
            this.textBox_FIO_DeputyAccountant.Size = new System.Drawing.Size(250, 29);
            this.textBox_FIO_DeputyAccountant.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(105, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 47);
            this.label5.TabIndex = 2;
            this.label5.Text = "Заместитель главного бухгалтера, ФИО";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_FIO_MainMechanic
            // 
            this.textBox_FIO_MainMechanic.Location = new System.Drawing.Point(409, 74);
            this.textBox_FIO_MainMechanic.Margin = new System.Windows.Forms.Padding(9);
            this.textBox_FIO_MainMechanic.MaxLength = 250;
            this.textBox_FIO_MainMechanic.Name = "textBox_FIO_MainMechanic";
            this.textBox_FIO_MainMechanic.Size = new System.Drawing.Size(250, 29);
            this.textBox_FIO_MainMechanic.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(277, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 47);
            this.label4.TabIndex = 2;
            this.label4.Text = "Инженер, ФИО";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(219, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Главный механик, ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(152, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начальник отдела закупок, ФИО";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(144, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заместитель ген. директора, ФИО";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.progressBar, 2);
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(108, 306);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(554, 23);
            this.progressBar.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button_Export);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_OpenFileExport);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 35);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(567, 3);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(200, 29);
            this.button_Export.TabIndex = 7;
            this.button_Export.Text = "Экспортировать";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // checkBox_OpenFileExport
            // 
            this.checkBox_OpenFileExport.AutoSize = true;
            this.checkBox_OpenFileExport.Checked = true;
            this.checkBox_OpenFileExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_OpenFileExport.Location = new System.Drawing.Point(211, 3);
            this.checkBox_OpenFileExport.Name = "checkBox_OpenFileExport";
            this.checkBox_OpenFileExport.Size = new System.Drawing.Size(350, 25);
            this.checkBox_OpenFileExport.TabIndex = 6;
            this.checkBox_OpenFileExport.Text = "Открыть документ по завершению экспорта";
            this.checkBox_OpenFileExport.UseVisualStyleBackColor = true;
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // DebitViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 638);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "DebitViewForm";
            this.ShowIcon = false;
            this.Text = "Просмотр акта списания";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageExportData.ResumeLayout(false);
            this.tabPageExportData.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Export_File;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit_Edit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete_Edit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label label_ActDebitNum;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPageExportData;
		private System.Windows.Forms.TextBox textBox_FIO_MainMechanic;
		private System.Windows.Forms.Button button_Export;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_FIO_DeputyAccountant;
		private System.Windows.Forms.TextBox textBox_FIO_Engineer;
		private System.Windows.Forms.TextBox textBox_FIO_HeadProcurement;
		private System.Windows.Forms.TextBox textBox_FIO_DeputyDirector;
		private System.Windows.Forms.CheckBox checkBox_OpenFileExport;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridView_Data;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox_ActNumber;
		private System.Windows.Forms.TextBox textBox_ActTotalPrice;
		private System.Windows.Forms.DateTimePicker dateTimePicker_ActDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox_Organization;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWorkshop;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroup;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInventoryNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEquipmentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReasonDebit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.ComponentModel.BackgroundWorker BGWorker;
	}
}