
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
			this.button_Edit = new System.Windows.Forms.Button();
			this.button_Debit = new System.Windows.Forms.Button();
			this.checkBox_AllGroupDebit = new System.Windows.Forms.CheckBox();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Debit)).BeginInit();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_ActNumber
			// 
			this.label_ActNumber.AutoSize = true;
			this.label_ActNumber.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_ActNumber.Location = new System.Drawing.Point(155, 29);
			this.label_ActNumber.Name = "label_ActNumber";
			this.label_ActNumber.Size = new System.Drawing.Size(73, 25);
			this.label_ActNumber.TabIndex = 0;
			this.label_ActNumber.Text = "Акт №";
			// 
			// textBox_ActNumber
			// 
			this.textBox_ActNumber.Location = new System.Drawing.Point(234, 27);
			this.textBox_ActNumber.Name = "textBox_ActNumber";
			this.textBox_ActNumber.Size = new System.Drawing.Size(150, 29);
			this.textBox_ActNumber.TabIndex = 1;
			// 
			// button_AddAndClose
			// 
			this.button_AddAndClose.Location = new System.Drawing.Point(366, 610);
			this.button_AddAndClose.Name = "button_AddAndClose";
			this.button_AddAndClose.Size = new System.Drawing.Size(250, 39);
			this.button_AddAndClose.TabIndex = 2;
			this.button_AddAndClose.Text = "Добавить акт и закрыть";
			this.button_AddAndClose.UseVisualStyleBackColor = true;
			// 
			// button_Close
			// 
			this.button_Close.Image = global::OGM.Properties.Resources.cancel;
			this.button_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_Close.Location = new System.Drawing.Point(622, 610);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new System.Drawing.Size(250, 39);
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
			this.ToolStripMenuItem_Add_EquipmentDebit.Size = new System.Drawing.Size(126, 22);
			this.ToolStripMenuItem_Add_EquipmentDebit.Text = "Добавить";
			// 
			// ToolStripMenuItem_Find_EquipmentDebit
			// 
			this.ToolStripMenuItem_Find_EquipmentDebit.Name = "ToolStripMenuItem_Find_EquipmentDebit";
			this.ToolStripMenuItem_Find_EquipmentDebit.Size = new System.Drawing.Size(180, 22);
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
			this.dateTimePicker_DateDebit.Location = new System.Drawing.Point(555, 27);
			this.dateTimePicker_DateDebit.Name = "dateTimePicker_DateDebit";
			this.dateTimePicker_DateDebit.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker_DateDebit.TabIndex = 1;
			// 
			// label_DateDebit
			// 
			this.label_DateDebit.AutoSize = true;
			this.label_DateDebit.Location = new System.Drawing.Point(432, 32);
			this.label_DateDebit.Name = "label_DateDebit";
			this.label_DateDebit.Size = new System.Drawing.Size(117, 21);
			this.label_DateDebit.TabIndex = 0;
			this.label_DateDebit.Text = "Дата списания:";
			// 
			// dataGridView_Debit
			// 
			this.dataGridView_Debit.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView_Debit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Debit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.ColumnInventoryNumber,
            this.ColumnName,
            this.ColumnCost,
            this.ColumnReasonDebit});
			this.dataGridView_Debit.Location = new System.Drawing.Point(12, 332);
			this.dataGridView_Debit.Name = "dataGridView_Debit";
			this.dataGridView_Debit.Size = new System.Drawing.Size(860, 272);
			this.dataGridView_Debit.TabIndex = 4;
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
			this.ColumnInventoryNumber.Width = 200;
			// 
			// ColumnName
			// 
			this.ColumnName.HeaderText = "Наименование оборудования";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.Width = 250;
			// 
			// ColumnCost
			// 
			this.ColumnCost.HeaderText = "Остаточная стоимость";
			this.ColumnCost.Name = "ColumnCost";
			this.ColumnCost.ReadOnly = true;
			this.ColumnCost.Width = 200;
			// 
			// ColumnReasonDebit
			// 
			this.ColumnReasonDebit.HeaderText = "Причина списания";
			this.ColumnReasonDebit.Name = "ColumnReasonDebit";
			this.ColumnReasonDebit.ReadOnly = true;
			this.ColumnReasonDebit.Width = 200;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(137, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Причина списания";
			// 
			// button_Delete
			// 
			this.button_Delete.Location = new System.Drawing.Point(417, 226);
			this.button_Delete.Name = "button_Delete";
			this.button_Delete.Size = new System.Drawing.Size(200, 32);
			this.button_Delete.TabIndex = 3;
			this.button_Delete.Text = "Удалить";
			this.button_Delete.UseVisualStyleBackColor = true;
			// 
			// label_Equipment
			// 
			this.label_Equipment.AutoSize = true;
			this.label_Equipment.Location = new System.Drawing.Point(122, 86);
			this.label_Equipment.Name = "label_Equipment";
			this.label_Equipment.Size = new System.Drawing.Size(159, 21);
			this.label_Equipment.TabIndex = 2;
			this.label_Equipment.Text = "Инвентарный номер";
			// 
			// comboBox_ReasonDebit
			// 
			this.comboBox_ReasonDebit.FormattingEnabled = true;
			this.comboBox_ReasonDebit.Location = new System.Drawing.Point(287, 118);
			this.comboBox_ReasonDebit.Name = "comboBox_ReasonDebit";
			this.comboBox_ReasonDebit.Size = new System.Drawing.Size(250, 29);
			this.comboBox_ReasonDebit.TabIndex = 0;
			// 
			// label_GroupEquipment
			// 
			this.label_GroupEquipment.AutoSize = true;
			this.label_GroupEquipment.Location = new System.Drawing.Point(114, 51);
			this.label_GroupEquipment.Name = "label_GroupEquipment";
			this.label_GroupEquipment.Size = new System.Drawing.Size(167, 21);
			this.label_GroupEquipment.TabIndex = 1;
			this.label_GroupEquipment.Text = "Группа оборудования";
			// 
			// comboBox_Equipment
			// 
			this.comboBox_Equipment.FormattingEnabled = true;
			this.comboBox_Equipment.Location = new System.Drawing.Point(287, 83);
			this.comboBox_Equipment.Name = "comboBox_Equipment";
			this.comboBox_Equipment.Size = new System.Drawing.Size(250, 29);
			this.comboBox_Equipment.TabIndex = 0;
			// 
			// comboBox_GroupEquipment
			// 
			this.comboBox_GroupEquipment.FormattingEnabled = true;
			this.comboBox_GroupEquipment.Location = new System.Drawing.Point(287, 48);
			this.comboBox_GroupEquipment.Name = "comboBox_GroupEquipment";
			this.comboBox_GroupEquipment.Size = new System.Drawing.Size(250, 29);
			this.comboBox_GroupEquipment.TabIndex = 0;
			// 
			// button_Add
			// 
			this.button_Add.Image = global::OGM.Properties.Resources.file_add;
			this.button_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_Add.Location = new System.Drawing.Point(110, 610);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(250, 39);
			this.button_Add.TabIndex = 2;
			this.button_Add.Text = "Добавить акт";
			this.button_Add.UseVisualStyleBackColor = true;
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.button_Edit);
			this.groupBox.Controls.Add(this.button_Debit);
			this.groupBox.Controls.Add(this.checkBox_AllGroupDebit);
			this.groupBox.Controls.Add(this.comboBox_ReasonDebit);
			this.groupBox.Controls.Add(this.comboBox_GroupEquipment);
			this.groupBox.Controls.Add(this.comboBox_Equipment);
			this.groupBox.Controls.Add(this.label_GroupEquipment);
			this.groupBox.Controls.Add(this.label1);
			this.groupBox.Controls.Add(this.label_Equipment);
			this.groupBox.Controls.Add(this.button_Delete);
			this.groupBox.Location = new System.Drawing.Point(12, 62);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(860, 264);
			this.groupBox.TabIndex = 5;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Строка таблицы";
			// 
			// button_Edit
			// 
			this.button_Edit.Location = new System.Drawing.Point(211, 226);
			this.button_Edit.Name = "button_Edit";
			this.button_Edit.Size = new System.Drawing.Size(200, 32);
			this.button_Edit.TabIndex = 5;
			this.button_Edit.Text = "Редактировать";
			this.button_Edit.UseVisualStyleBackColor = true;
			// 
			// button_Debit
			// 
			this.button_Debit.Location = new System.Drawing.Point(6, 226);
			this.button_Debit.Name = "button_Debit";
			this.button_Debit.Size = new System.Drawing.Size(200, 32);
			this.button_Debit.TabIndex = 5;
			this.button_Debit.Text = "Списать";
			this.button_Debit.UseVisualStyleBackColor = true;
			// 
			// checkBox_AllGroupDebit
			// 
			this.checkBox_AllGroupDebit.AutoSize = true;
			this.checkBox_AllGroupDebit.Location = new System.Drawing.Point(566, 86);
			this.checkBox_AllGroupDebit.Name = "checkBox_AllGroupDebit";
			this.checkBox_AllGroupDebit.Size = new System.Drawing.Size(172, 25);
			this.checkBox_AllGroupDebit.TabIndex = 4;
			this.checkBox_AllGroupDebit.Text = "Списать всю группу";
			this.checkBox_AllGroupDebit.UseVisualStyleBackColor = true;
			this.checkBox_AllGroupDebit.CheckedChanged += new System.EventHandler(this.checkBox_AllGroupDebit_CheckedChanged);
			// 
			// AddEquipmentDebitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 661);
			this.Controls.Add(this.groupBox);
			this.Controls.Add(this.dataGridView_Debit);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.dateTimePicker_DateDebit);
			this.Controls.Add(this.button_Close);
			this.Controls.Add(this.label_DateDebit);
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Debit)).EndInit();
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInventoryNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReasonDebit;
	}
}