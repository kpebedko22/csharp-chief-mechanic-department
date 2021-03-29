
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
			this.button_Add = new System.Windows.Forms.Button();
			this.button_AddAndClose = new System.Windows.Forms.Button();
			this.button_Close = new System.Windows.Forms.Button();
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label_DateDebit = new System.Windows.Forms.Label();
			this.dateTimePicker_DateDebit = new System.Windows.Forms.DateTimePicker();
			this.label_FIO_MainMechanic = new System.Windows.Forms.Label();
			this.textBox_FIO_MainMechanic = new System.Windows.Forms.TextBox();
			this.groupBox_Commission = new System.Windows.Forms.GroupBox();
			this.label_DeputyGeneralDirector = new System.Windows.Forms.Label();
			this.label_HeadOfProcurement = new System.Windows.Forms.Label();
			this.label_Engineer = new System.Windows.Forms.Label();
			this.label_DeputyChiefAccountant = new System.Windows.Forms.Label();
			this.textBox_FIO_DeputyGeneralDirector = new System.Windows.Forms.TextBox();
			this.textBox_FIO_HeadOfProcurement = new System.Windows.Forms.TextBox();
			this.textBox_FIO_Engineer = new System.Windows.Forms.TextBox();
			this.textBox_FIO_DeputyChiefAccountant = new System.Windows.Forms.TextBox();
			this.comboBox_GroupEquipment = new System.Windows.Forms.ComboBox();
			this.label_GroupEquipment = new System.Windows.Forms.Label();
			this.label_Equipment = new System.Windows.Forms.Label();
			this.comboBox_Equipment = new System.Windows.Forms.ComboBox();
			this.button_DebitOneEquipment = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnInventoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnMeasurmentUnitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnMeasurmentUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnReasonDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comboBox_ReasonDebit = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox_Commission.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label_ActNumber
			// 
			this.label_ActNumber.AutoSize = true;
			this.label_ActNumber.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_ActNumber.Location = new System.Drawing.Point(345, 29);
			this.label_ActNumber.Name = "label_ActNumber";
			this.label_ActNumber.Size = new System.Drawing.Size(73, 25);
			this.label_ActNumber.TabIndex = 0;
			this.label_ActNumber.Text = "Акт №";
			// 
			// textBox_ActNumber
			// 
			this.textBox_ActNumber.Location = new System.Drawing.Point(424, 27);
			this.textBox_ActNumber.Name = "textBox_ActNumber";
			this.textBox_ActNumber.Size = new System.Drawing.Size(150, 29);
			this.textBox_ActNumber.TabIndex = 1;
			// 
			// button_Add
			// 
			this.button_Add.Location = new System.Drawing.Point(12, 62);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(200, 39);
			this.button_Add.TabIndex = 2;
			this.button_Add.Text = "Добавить";
			this.button_Add.UseVisualStyleBackColor = true;
			// 
			// button_AddAndClose
			// 
			this.button_AddAndClose.Location = new System.Drawing.Point(218, 62);
			this.button_AddAndClose.Name = "button_AddAndClose";
			this.button_AddAndClose.Size = new System.Drawing.Size(200, 39);
			this.button_AddAndClose.TabIndex = 2;
			this.button_AddAndClose.Text = "Добавить и закрыть";
			this.button_AddAndClose.UseVisualStyleBackColor = true;
			// 
			// button_Close
			// 
			this.button_Close.Location = new System.Drawing.Point(424, 62);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new System.Drawing.Size(200, 39);
			this.button_Close.TabIndex = 2;
			this.button_Close.Text = "Отменить";
			this.button_Close.UseVisualStyleBackColor = true;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_EquipmentDebit,
            this.ToolStripMenuItem_Handbooks});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(884, 24);
			this.menuStrip.TabIndex = 3;
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
			this.ToolStripMenuItem_Add_EquipmentDebit.Size = new System.Drawing.Size(180, 22);
			this.ToolStripMenuItem_Add_EquipmentDebit.Text = "Добавить";
			// 
			// ToolStripMenuItem_Find_EquipmentDebit
			// 
			this.ToolStripMenuItem_Find_EquipmentDebit.Name = "ToolStripMenuItem_Find_EquipmentDebit";
			this.ToolStripMenuItem_Find_EquipmentDebit.Size = new System.Drawing.Size(180, 22);
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
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point(12, 107);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(860, 442);
			this.tabControl.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox_Commission);
			this.tabPage1.Controls.Add(this.textBox_FIO_MainMechanic);
			this.tabPage1.Controls.Add(this.dateTimePicker_DateDebit);
			this.tabPage1.Controls.Add(this.label_FIO_MainMechanic);
			this.tabPage1.Controls.Add(this.label_DateDebit);
			this.tabPage1.Location = new System.Drawing.Point(4, 30);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(852, 408);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Основная информация";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.button_DebitOneEquipment);
			this.tabPage2.Controls.Add(this.label_Equipment);
			this.tabPage2.Controls.Add(this.comboBox_ReasonDebit);
			this.tabPage2.Controls.Add(this.label_GroupEquipment);
			this.tabPage2.Controls.Add(this.comboBox_Equipment);
			this.tabPage2.Controls.Add(this.comboBox_GroupEquipment);
			this.tabPage2.Location = new System.Drawing.Point(4, 30);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(852, 408);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Оборудование";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label_DateDebit
			// 
			this.label_DateDebit.AutoSize = true;
			this.label_DateDebit.Location = new System.Drawing.Point(499, 24);
			this.label_DateDebit.Name = "label_DateDebit";
			this.label_DateDebit.Size = new System.Drawing.Size(117, 21);
			this.label_DateDebit.TabIndex = 0;
			this.label_DateDebit.Text = "Дата списания:";
			// 
			// dateTimePicker_DateDebit
			// 
			this.dateTimePicker_DateDebit.Location = new System.Drawing.Point(622, 20);
			this.dateTimePicker_DateDebit.Name = "dateTimePicker_DateDebit";
			this.dateTimePicker_DateDebit.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker_DateDebit.TabIndex = 1;
			// 
			// label_FIO_MainMechanic
			// 
			this.label_FIO_MainMechanic.AutoSize = true;
			this.label_FIO_MainMechanic.Location = new System.Drawing.Point(31, 24);
			this.label_FIO_MainMechanic.Name = "label_FIO_MainMechanic";
			this.label_FIO_MainMechanic.Size = new System.Drawing.Size(187, 21);
			this.label_FIO_MainMechanic.TabIndex = 0;
			this.label_FIO_MainMechanic.Text = "ФИО главного механика:";
			// 
			// textBox_FIO_MainMechanic
			// 
			this.textBox_FIO_MainMechanic.Location = new System.Drawing.Point(224, 21);
			this.textBox_FIO_MainMechanic.Name = "textBox_FIO_MainMechanic";
			this.textBox_FIO_MainMechanic.Size = new System.Drawing.Size(200, 29);
			this.textBox_FIO_MainMechanic.TabIndex = 2;
			// 
			// groupBox_Commission
			// 
			this.groupBox_Commission.Controls.Add(this.label_DeputyChiefAccountant);
			this.groupBox_Commission.Controls.Add(this.textBox_FIO_DeputyChiefAccountant);
			this.groupBox_Commission.Controls.Add(this.textBox_FIO_Engineer);
			this.groupBox_Commission.Controls.Add(this.textBox_FIO_HeadOfProcurement);
			this.groupBox_Commission.Controls.Add(this.textBox_FIO_DeputyGeneralDirector);
			this.groupBox_Commission.Controls.Add(this.label_Engineer);
			this.groupBox_Commission.Controls.Add(this.label_HeadOfProcurement);
			this.groupBox_Commission.Controls.Add(this.label_DeputyGeneralDirector);
			this.groupBox_Commission.Location = new System.Drawing.Point(6, 73);
			this.groupBox_Commission.Name = "groupBox_Commission";
			this.groupBox_Commission.Size = new System.Drawing.Size(840, 329);
			this.groupBox_Commission.TabIndex = 3;
			this.groupBox_Commission.TabStop = false;
			this.groupBox_Commission.Text = "Комиссия";
			// 
			// label_DeputyGeneralDirector
			// 
			this.label_DeputyGeneralDirector.AutoSize = true;
			this.label_DeputyGeneralDirector.Location = new System.Drawing.Point(42, 47);
			this.label_DeputyGeneralDirector.Name = "label_DeputyGeneralDirector";
			this.label_DeputyGeneralDirector.Size = new System.Drawing.Size(281, 21);
			this.label_DeputyGeneralDirector.TabIndex = 0;
			this.label_DeputyGeneralDirector.Text = "Заместитель генерального директора";
			// 
			// label_HeadOfProcurement
			// 
			this.label_HeadOfProcurement.AutoSize = true;
			this.label_HeadOfProcurement.Location = new System.Drawing.Point(121, 97);
			this.label_HeadOfProcurement.Name = "label_HeadOfProcurement";
			this.label_HeadOfProcurement.Size = new System.Drawing.Size(202, 21);
			this.label_HeadOfProcurement.TabIndex = 0;
			this.label_HeadOfProcurement.Text = "Начальник отдела закупок";
			// 
			// label_Engineer
			// 
			this.label_Engineer.AutoSize = true;
			this.label_Engineer.Location = new System.Drawing.Point(246, 147);
			this.label_Engineer.Name = "label_Engineer";
			this.label_Engineer.Size = new System.Drawing.Size(77, 21);
			this.label_Engineer.TabIndex = 0;
			this.label_Engineer.Text = "Инженер";
			// 
			// label_DeputyChiefAccountant
			// 
			this.label_DeputyChiefAccountant.AutoSize = true;
			this.label_DeputyChiefAccountant.Location = new System.Drawing.Point(75, 197);
			this.label_DeputyChiefAccountant.Name = "label_DeputyChiefAccountant";
			this.label_DeputyChiefAccountant.Size = new System.Drawing.Size(248, 21);
			this.label_DeputyChiefAccountant.TabIndex = 0;
			this.label_DeputyChiefAccountant.Text = "Заместитель главного бухгалтера";
			// 
			// textBox_FIO_DeputyGeneralDirector
			// 
			this.textBox_FIO_DeputyGeneralDirector.Location = new System.Drawing.Point(329, 43);
			this.textBox_FIO_DeputyGeneralDirector.Name = "textBox_FIO_DeputyGeneralDirector";
			this.textBox_FIO_DeputyGeneralDirector.Size = new System.Drawing.Size(300, 29);
			this.textBox_FIO_DeputyGeneralDirector.TabIndex = 2;
			// 
			// textBox_FIO_HeadOfProcurement
			// 
			this.textBox_FIO_HeadOfProcurement.Location = new System.Drawing.Point(329, 93);
			this.textBox_FIO_HeadOfProcurement.Name = "textBox_FIO_HeadOfProcurement";
			this.textBox_FIO_HeadOfProcurement.Size = new System.Drawing.Size(300, 29);
			this.textBox_FIO_HeadOfProcurement.TabIndex = 2;
			// 
			// textBox_FIO_Engineer
			// 
			this.textBox_FIO_Engineer.Location = new System.Drawing.Point(329, 143);
			this.textBox_FIO_Engineer.Name = "textBox_FIO_Engineer";
			this.textBox_FIO_Engineer.Size = new System.Drawing.Size(300, 29);
			this.textBox_FIO_Engineer.TabIndex = 2;
			// 
			// textBox_FIO_DeputyChiefAccountant
			// 
			this.textBox_FIO_DeputyChiefAccountant.Location = new System.Drawing.Point(329, 193);
			this.textBox_FIO_DeputyChiefAccountant.Name = "textBox_FIO_DeputyChiefAccountant";
			this.textBox_FIO_DeputyChiefAccountant.Size = new System.Drawing.Size(300, 29);
			this.textBox_FIO_DeputyChiefAccountant.TabIndex = 2;
			// 
			// comboBox_GroupEquipment
			// 
			this.comboBox_GroupEquipment.FormattingEnabled = true;
			this.comboBox_GroupEquipment.Location = new System.Drawing.Point(196, 21);
			this.comboBox_GroupEquipment.Name = "comboBox_GroupEquipment";
			this.comboBox_GroupEquipment.Size = new System.Drawing.Size(650, 29);
			this.comboBox_GroupEquipment.TabIndex = 0;
			// 
			// label_GroupEquipment
			// 
			this.label_GroupEquipment.AutoSize = true;
			this.label_GroupEquipment.Location = new System.Drawing.Point(23, 25);
			this.label_GroupEquipment.Name = "label_GroupEquipment";
			this.label_GroupEquipment.Size = new System.Drawing.Size(167, 21);
			this.label_GroupEquipment.TabIndex = 1;
			this.label_GroupEquipment.Text = "Группа оборудования";
			// 
			// label_Equipment
			// 
			this.label_Equipment.AutoSize = true;
			this.label_Equipment.Location = new System.Drawing.Point(74, 95);
			this.label_Equipment.Name = "label_Equipment";
			this.label_Equipment.Size = new System.Drawing.Size(116, 21);
			this.label_Equipment.TabIndex = 2;
			this.label_Equipment.Text = "Оборудование";
			// 
			// comboBox_Equipment
			// 
			this.comboBox_Equipment.FormattingEnabled = true;
			this.comboBox_Equipment.Location = new System.Drawing.Point(196, 91);
			this.comboBox_Equipment.Name = "comboBox_Equipment";
			this.comboBox_Equipment.Size = new System.Drawing.Size(650, 29);
			this.comboBox_Equipment.TabIndex = 0;
			// 
			// button_DebitOneEquipment
			// 
			this.button_DebitOneEquipment.Location = new System.Drawing.Point(262, 138);
			this.button_DebitOneEquipment.Name = "button_DebitOneEquipment";
			this.button_DebitOneEquipment.Size = new System.Drawing.Size(300, 29);
			this.button_DebitOneEquipment.TabIndex = 3;
			this.button_DebitOneEquipment.Text = "Списать выбранное оборудование";
			this.button_DebitOneEquipment.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 138);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(250, 29);
			this.button1.TabIndex = 3;
			this.button1.Text = "Списать всю группу";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.ColumnInventoryNumber,
            this.ColumnName,
            this.ColumnMeasurmentUnitCode,
            this.ColumnMeasurmentUnitName,
            this.ColumnAmount,
            this.ColumnCost,
            this.ColumnReasonDebit});
			this.dataGridView1.Location = new System.Drawing.Point(6, 173);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(840, 229);
			this.dataGridView1.TabIndex = 4;
			// 
			// Column
			// 
			this.Column.HeaderText = "#";
			this.Column.Name = "Column";
			this.Column.ReadOnly = true;
			this.Column.Width = 50;
			// 
			// ColumnInventoryNumber
			// 
			this.ColumnInventoryNumber.HeaderText = "Инвентарный номер";
			this.ColumnInventoryNumber.Name = "ColumnInventoryNumber";
			this.ColumnInventoryNumber.ReadOnly = true;
			// 
			// ColumnName
			// 
			this.ColumnName.HeaderText = "Наименование оборудования";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			// 
			// ColumnMeasurmentUnitCode
			// 
			this.ColumnMeasurmentUnitCode.HeaderText = "Ед. изм. - код по ОКЕИ";
			this.ColumnMeasurmentUnitCode.Name = "ColumnMeasurmentUnitCode";
			this.ColumnMeasurmentUnitCode.ReadOnly = true;
			// 
			// ColumnMeasurmentUnitName
			// 
			this.ColumnMeasurmentUnitName.HeaderText = "Ед. изм. - наименование";
			this.ColumnMeasurmentUnitName.Name = "ColumnMeasurmentUnitName";
			this.ColumnMeasurmentUnitName.ReadOnly = true;
			// 
			// ColumnAmount
			// 
			this.ColumnAmount.HeaderText = "Кол-во";
			this.ColumnAmount.Name = "ColumnAmount";
			this.ColumnAmount.ReadOnly = true;
			// 
			// ColumnCost
			// 
			this.ColumnCost.HeaderText = "Стоимость";
			this.ColumnCost.Name = "ColumnCost";
			this.ColumnCost.ReadOnly = true;
			// 
			// ColumnReasonDebit
			// 
			this.ColumnReasonDebit.HeaderText = "Причина списания";
			this.ColumnReasonDebit.Name = "ColumnReasonDebit";
			this.ColumnReasonDebit.ReadOnly = true;
			// 
			// comboBox_ReasonDebit
			// 
			this.comboBox_ReasonDebit.FormattingEnabled = true;
			this.comboBox_ReasonDebit.Location = new System.Drawing.Point(196, 56);
			this.comboBox_ReasonDebit.Name = "comboBox_ReasonDebit";
			this.comboBox_ReasonDebit.Size = new System.Drawing.Size(650, 29);
			this.comboBox_ReasonDebit.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Причина списания";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(568, 138);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(250, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// AddEquipmentDebitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.button_Close);
			this.Controls.Add(this.button_AddAndClose);
			this.Controls.Add(this.button_Add);
			this.Controls.Add(this.textBox_ActNumber);
			this.Controls.Add(this.label_ActNumber);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddEquipmentDebitForm";
			this.Text = "Добавить новый акт списания оборудования";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEquipmentDebitForm_FormClosed);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox_Commission.ResumeLayout(false);
			this.groupBox_Commission.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DateTimePicker dateTimePicker_DateDebit;
		private System.Windows.Forms.Label label_FIO_MainMechanic;
		private System.Windows.Forms.Label label_DateDebit;
		private System.Windows.Forms.TextBox textBox_FIO_MainMechanic;
		private System.Windows.Forms.GroupBox groupBox_Commission;
		private System.Windows.Forms.Label label_DeputyChiefAccountant;
		private System.Windows.Forms.TextBox textBox_FIO_DeputyChiefAccountant;
		private System.Windows.Forms.TextBox textBox_FIO_Engineer;
		private System.Windows.Forms.TextBox textBox_FIO_HeadOfProcurement;
		private System.Windows.Forms.TextBox textBox_FIO_DeputyGeneralDirector;
		private System.Windows.Forms.Label label_Engineer;
		private System.Windows.Forms.Label label_HeadOfProcurement;
		private System.Windows.Forms.Label label_DeputyGeneralDirector;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInventoryNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMeasurmentUnitCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMeasurmentUnitName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReasonDebit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button_DebitOneEquipment;
		private System.Windows.Forms.Label label_Equipment;
		private System.Windows.Forms.ComboBox comboBox_ReasonDebit;
		private System.Windows.Forms.Label label_GroupEquipment;
		private System.Windows.Forms.ComboBox comboBox_Equipment;
		private System.Windows.Forms.ComboBox comboBox_GroupEquipment;
	}
}