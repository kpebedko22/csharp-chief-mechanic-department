
namespace OGM {
	partial class AddEquipmentDebitForm {
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
            this.label_ActNumber = new System.Windows.Forms.Label();
            this.textBox_ActNumber = new System.Windows.Forms.TextBox();
            this.button_AddAndClose = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
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
            this.dateTimePicker_DateDebit = new System.Windows.Forms.DateTimePicker();
            this.label_DateDebit = new System.Windows.Forms.Label();
            this.dataGridView_Debit = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWorkshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPK_Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInventoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReasonDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_Equipment = new System.Windows.Forms.Label();
            this.comboBox_ReasonDebit = new System.Windows.Forms.ComboBox();
            this.label_GroupEquipment = new System.Windows.Forms.Label();
            this.comboBox_Equipment = new System.Windows.Forms.ComboBox();
            this.comboBox_GroupEquipment = new System.Windows.Forms.ComboBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Workshop = new System.Windows.Forms.Label();
            this.checkBox_AllGroupDebit = new System.Windows.Forms.CheckBox();
            this.comboBox_Workshop = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Debit = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Debit)).BeginInit();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ActNumber
            // 
            this.label_ActNumber.AutoSize = true;
            this.label_ActNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_ActNumber.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ActNumber.Location = new System.Drawing.Point(114, 0);
            this.label_ActNumber.Name = "label_ActNumber";
            this.label_ActNumber.Size = new System.Drawing.Size(72, 35);
            this.label_ActNumber.TabIndex = 0;
            this.label_ActNumber.Text = "Акт №";
            this.label_ActNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ActNumber
            // 
            this.textBox_ActNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ActNumber.Location = new System.Drawing.Point(192, 3);
            this.textBox_ActNumber.MaxLength = 19;
            this.textBox_ActNumber.Name = "textBox_ActNumber";
            this.textBox_ActNumber.Size = new System.Drawing.Size(150, 29);
            this.textBox_ActNumber.TabIndex = 1;
            // 
            // button_AddAndClose
            // 
            this.button_AddAndClose.Location = new System.Drawing.Point(113, 3);
            this.button_AddAndClose.Name = "button_AddAndClose";
            this.button_AddAndClose.Size = new System.Drawing.Size(250, 39);
            this.button_AddAndClose.TabIndex = 2;
            this.button_AddAndClose.Text = "Добавить акт и закрыть";
            this.button_AddAndClose.UseVisualStyleBackColor = true;
            this.button_AddAndClose.Click += new System.EventHandler(this.button_AddAndClose_Click);
            // 
            // button_Close
            // 
            this.button_Close.Image = global::OGM.Properties.Resources.cancel;
            this.button_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Close.Location = new System.Drawing.Point(625, 3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(250, 39);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Отменить";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
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
            this.menuStrip.TabIndex = 3;
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
            // 
            // ToolStripMenuItem_Find_EquipmentDebit
            // 
            this.ToolStripMenuItem_Find_EquipmentDebit.Name = "ToolStripMenuItem_Find_EquipmentDebit";
            this.ToolStripMenuItem_Find_EquipmentDebit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Find_EquipmentDebit.Text = "Найти";
            this.ToolStripMenuItem_Find_EquipmentDebit.Click += new System.EventHandler(this.ToolStripMenuItem_Find_EquipmentDebit_Click);
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
            // dateTimePicker_DateDebit
            // 
            this.dateTimePicker_DateDebit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_DateDebit.Location = new System.Drawing.Point(563, 3);
            this.dateTimePicker_DateDebit.Name = "dateTimePicker_DateDebit";
            this.dateTimePicker_DateDebit.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_DateDebit.TabIndex = 2;
            // 
            // label_DateDebit
            // 
            this.label_DateDebit.AutoSize = true;
            this.label_DateDebit.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_DateDebit.Location = new System.Drawing.Point(443, 0);
            this.label_DateDebit.Name = "label_DateDebit";
            this.label_DateDebit.Size = new System.Drawing.Size(114, 35);
            this.label_DateDebit.TabIndex = 0;
            this.label_DateDebit.Text = "Дата списания";
            this.label_DateDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView_Debit
            // 
            this.dataGridView_Debit.AllowUserToAddRows = false;
            this.dataGridView_Debit.AllowUserToDeleteRows = false;
            this.dataGridView_Debit.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView_Debit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Debit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.ColumnWorkshop,
            this.ColumnGroup,
            this.ColumnPK_Equipment,
            this.ColumnInventoryNumber,
            this.ColumnName,
            this.ColumnCost,
            this.ColumnReasonDebit});
            this.dataGridView_Debit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Debit.Location = new System.Drawing.Point(3, 318);
            this.dataGridView_Debit.Name = "dataGridView_Debit";
            this.dataGridView_Debit.ReadOnly = true;
            this.dataGridView_Debit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Debit.Size = new System.Drawing.Size(878, 266);
            this.dataGridView_Debit.TabIndex = 11;
            // 
            // Column
            // 
            this.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column.HeaderText = "#";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 50;
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
            // ColumnPK_Equipment
            // 
            this.ColumnPK_Equipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPK_Equipment.HeaderText = "ПК оборудования";
            this.ColumnPK_Equipment.Name = "ColumnPK_Equipment";
            this.ColumnPK_Equipment.ReadOnly = true;
            this.ColumnPK_Equipment.Visible = false;
            // 
            // ColumnInventoryNumber
            // 
            this.ColumnInventoryNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInventoryNumber.HeaderText = "Инвентарный номер";
            this.ColumnInventoryNumber.Name = "ColumnInventoryNumber";
            this.ColumnInventoryNumber.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Наименование оборудования";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(114, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Причина списания";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(415, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(200, 32);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_Equipment
            // 
            this.label_Equipment.AutoSize = true;
            this.label_Equipment.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Equipment.Location = new System.Drawing.Point(99, 82);
            this.label_Equipment.Name = "label_Equipment";
            this.label_Equipment.Size = new System.Drawing.Size(159, 41);
            this.label_Equipment.TabIndex = 2;
            this.label_Equipment.Text = "Инвентарный номер";
            this.label_Equipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_ReasonDebit
            // 
            this.comboBox_ReasonDebit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_ReasonDebit.FormattingEnabled = true;
            this.comboBox_ReasonDebit.Location = new System.Drawing.Point(267, 129);
            this.comboBox_ReasonDebit.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_ReasonDebit.Name = "comboBox_ReasonDebit";
            this.comboBox_ReasonDebit.Size = new System.Drawing.Size(336, 29);
            this.comboBox_ReasonDebit.TabIndex = 6;
            // 
            // label_GroupEquipment
            // 
            this.label_GroupEquipment.AutoSize = true;
            this.label_GroupEquipment.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_GroupEquipment.Location = new System.Drawing.Point(89, 41);
            this.label_GroupEquipment.Name = "label_GroupEquipment";
            this.label_GroupEquipment.Size = new System.Drawing.Size(169, 41);
            this.label_GroupEquipment.TabIndex = 1;
            this.label_GroupEquipment.Text = "Группа оборудования";
            this.label_GroupEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_Equipment
            // 
            this.comboBox_Equipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Equipment.FormattingEnabled = true;
            this.comboBox_Equipment.Location = new System.Drawing.Point(267, 88);
            this.comboBox_Equipment.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Equipment.Name = "comboBox_Equipment";
            this.comboBox_Equipment.Size = new System.Drawing.Size(336, 29);
            this.comboBox_Equipment.TabIndex = 5;
            // 
            // comboBox_GroupEquipment
            // 
            this.comboBox_GroupEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_GroupEquipment.FormattingEnabled = true;
            this.comboBox_GroupEquipment.Location = new System.Drawing.Point(267, 47);
            this.comboBox_GroupEquipment.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_GroupEquipment.Name = "comboBox_GroupEquipment";
            this.comboBox_GroupEquipment.Size = new System.Drawing.Size(336, 29);
            this.comboBox_GroupEquipment.TabIndex = 4;
            this.comboBox_GroupEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBox_GroupEquipment_SelectedIndexChanged);
            // 
            // button_Add
            // 
            this.button_Add.Image = global::OGM.Properties.Resources.file_add;
            this.button_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add.Location = new System.Drawing.Point(369, 3);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(250, 39);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Добавить акт";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.tableLayoutPanel3);
            this.groupBox.Controls.Add(this.flowLayoutPanel2);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(3, 53);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(878, 259);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Строка таблицы";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label_Workshop, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_GroupEquipment, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_AllGroupDebit, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_Equipment, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_ReasonDebit, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_Equipment, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_GroupEquipment, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_Workshop, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(872, 193);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // label_Workshop
            // 
            this.label_Workshop.AutoSize = true;
            this.label_Workshop.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Workshop.Location = new System.Drawing.Point(221, 0);
            this.label_Workshop.Name = "label_Workshop";
            this.label_Workshop.Size = new System.Drawing.Size(37, 41);
            this.label_Workshop.TabIndex = 1;
            this.label_Workshop.Text = "Цех";
            this.label_Workshop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_AllGroupDebit
            // 
            this.checkBox_AllGroupDebit.AutoSize = true;
            this.checkBox_AllGroupDebit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_AllGroupDebit.Location = new System.Drawing.Point(612, 44);
            this.checkBox_AllGroupDebit.Name = "checkBox_AllGroupDebit";
            this.checkBox_AllGroupDebit.Size = new System.Drawing.Size(257, 35);
            this.checkBox_AllGroupDebit.TabIndex = 7;
            this.checkBox_AllGroupDebit.Text = "Списать всю группу";
            this.checkBox_AllGroupDebit.UseVisualStyleBackColor = true;
            this.checkBox_AllGroupDebit.CheckedChanged += new System.EventHandler(this.checkBox_AllGroupDebit_CheckedChanged);
            // 
            // comboBox_Workshop
            // 
            this.comboBox_Workshop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Workshop.FormattingEnabled = true;
            this.comboBox_Workshop.Location = new System.Drawing.Point(267, 6);
            this.comboBox_Workshop.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Workshop.Name = "comboBox_Workshop";
            this.comboBox_Workshop.Size = new System.Drawing.Size(336, 29);
            this.comboBox_Workshop.TabIndex = 3;
            this.comboBox_Workshop.SelectedIndexChanged += new System.EventHandler(this.comboBox_Workshop_SelectedIndexChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.button_Debit);
            this.flowLayoutPanel2.Controls.Add(this.button_Edit);
            this.flowLayoutPanel2.Controls.Add(this.button_Delete);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 218);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(872, 38);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // button_Debit
            // 
            this.button_Debit.Location = new System.Drawing.Point(3, 3);
            this.button_Debit.Name = "button_Debit";
            this.button_Debit.Size = new System.Drawing.Size(200, 32);
            this.button_Debit.TabIndex = 8;
            this.button_Debit.Text = "Списать";
            this.button_Debit.UseVisualStyleBackColor = true;
            this.button_Debit.Click += new System.EventHandler(this.button_Debit_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(209, 3);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(200, 32);
            this.button_Edit.TabIndex = 9;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Debit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 637);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_Close);
            this.flowLayoutPanel1.Controls.Add(this.button_Add);
            this.flowLayoutPanel1.Controls.Add(this.button_AddAndClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 590);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(878, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.label_ActNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_ActNumber, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_DateDebit, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_DateDebit, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 44);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // AddEquipmentDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "AddEquipmentDebitForm";
            this.ShowIcon = false;
            this.Text = "Добавить новый акт списания оборудования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEquipmentDebitForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Debit)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_ActNumber;
		private System.Windows.Forms.TextBox textBox_ActNumber;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.Button button_AddAndClose;
		private System.Windows.Forms.Button button_Close;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EquipmentDebit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add_EquipmentDebit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Find_EquipmentDebit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Handbooks;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Equipment_Handbook;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_GroupEquipment_Handbook;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Workshop_Handbook;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Organization_Handbook;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ReasonDebit_Handbook;
		private System.Windows.Forms.DateTimePicker dateTimePicker_DateDebit;
		private System.Windows.Forms.Label label_DateDebit;
		private System.Windows.Forms.DataGridView dataGridView_Debit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_Delete;
		private System.Windows.Forms.Label label_Equipment;
		private System.Windows.Forms.ComboBox comboBox_ReasonDebit;
		private System.Windows.Forms.Label label_GroupEquipment;
		private System.Windows.Forms.ComboBox comboBox_Equipment;
		private System.Windows.Forms.ComboBox comboBox_GroupEquipment;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button button_Debit;
        private System.Windows.Forms.CheckBox checkBox_AllGroupDebit;
        private System.Windows.Forms.Button button_Edit;
		private System.Windows.Forms.ComboBox comboBox_Workshop;
		private System.Windows.Forms.Label label_Workshop;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWorkshop;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroup;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPK_Equipment;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInventoryNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReasonDebit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_ExitModule;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_ExitProg;
	}
}