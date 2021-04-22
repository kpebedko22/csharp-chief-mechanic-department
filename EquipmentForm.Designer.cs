
namespace OGM
{
    partial class EquipmentForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox_Search = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.button_Search = new System.Windows.Forms.Button();
			this.button_ResetSearch = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButton_all = new System.Windows.Forms.RadioButton();
			this.radioButton_is_leasing = new System.Windows.Forms.RadioButton();
			this.radioButton_is_debit = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox_SerialNum = new System.Windows.Forms.TextBox();
			this.textBox_NameEquipment = new System.Windows.Forms.TextBox();
			this.textBox_InventoryNum = new System.Windows.Forms.TextBox();
			this.label_Workshop = new System.Windows.Forms.Label();
			this.label_SerialNum = new System.Windows.Forms.Label();
			this.label_InventoryNum = new System.Windows.Forms.Label();
			this.label_NameEquipment = new System.Windows.Forms.Label();
			this.label_GroupEquipment = new System.Windows.Forms.Label();
			this.comboBox_Workshop = new System.Windows.Forms.ComboBox();
			this.comboBox_GroupEquipment = new System.Windows.Forms.ComboBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Column_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_NameEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_InventoryNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_PK_Workshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Workshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_PK_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_GroupEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_SerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.button_AddEquipment = new System.Windows.Forms.Button();
			this.button_EditEquipment = new System.Windows.Forms.Button();
			this.button_RemoveEquipment = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button_show_act_contract = new System.Windows.Forms.Button();
			this.groupBox_Search.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_Search
			// 
			this.groupBox_Search.Controls.Add(this.tableLayoutPanel4);
			this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_Search.Location = new System.Drawing.Point(6, 6);
			this.groupBox_Search.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(972, 288);
			this.groupBox_Search.TabIndex = 0;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 5;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 25);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(966, 260);
			this.tableLayoutPanel4.TabIndex = 11;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.button_Search, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.button_ResetSearch, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 2);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(572, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 4;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(311, 254);
			this.tableLayoutPanel5.TabIndex = 12;
			// 
			// button_Search
			// 
			this.button_Search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_Search.Location = new System.Drawing.Point(6, 6);
			this.button_Search.Margin = new System.Windows.Forms.Padding(6);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(300, 29);
			this.button_Search.TabIndex = 7;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
			// 
			// button_ResetSearch
			// 
			this.button_ResetSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_ResetSearch.Location = new System.Drawing.Point(6, 47);
			this.button_ResetSearch.Margin = new System.Windows.Forms.Padding(6);
			this.button_ResetSearch.Name = "button_ResetSearch";
			this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
			this.button_ResetSearch.TabIndex = 8;
			this.button_ResetSearch.Text = "Сбросить параметры поиска";
			this.button_ResetSearch.UseVisualStyleBackColor = true;
			this.button_ResetSearch.Click += new System.EventHandler(this.button_ResetSearch_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.Location = new System.Drawing.Point(3, 85);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(300, 153);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Признак";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.radioButton_all, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.radioButton_is_leasing, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.radioButton_is_debit, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 125);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// radioButton_all
			// 
			this.radioButton_all.AutoSize = true;
			this.radioButton_all.Checked = true;
			this.radioButton_all.Location = new System.Drawing.Point(6, 6);
			this.radioButton_all.Margin = new System.Windows.Forms.Padding(6);
			this.radioButton_all.Name = "radioButton_all";
			this.radioButton_all.Size = new System.Drawing.Size(52, 25);
			this.radioButton_all.TabIndex = 0;
			this.radioButton_all.TabStop = true;
			this.radioButton_all.Text = "Все";
			this.radioButton_all.UseVisualStyleBackColor = true;
			// 
			// radioButton_is_leasing
			// 
			this.radioButton_is_leasing.AutoSize = true;
			this.radioButton_is_leasing.Location = new System.Drawing.Point(6, 80);
			this.radioButton_is_leasing.Margin = new System.Windows.Forms.Padding(6);
			this.radioButton_is_leasing.Name = "radioButton_is_leasing";
			this.radioButton_is_leasing.Size = new System.Drawing.Size(189, 25);
			this.radioButton_is_leasing.TabIndex = 2;
			this.radioButton_is_leasing.Text = "Приобретено в лизинг";
			this.radioButton_is_leasing.UseVisualStyleBackColor = true;
			// 
			// radioButton_is_debit
			// 
			this.radioButton_is_debit.AutoSize = true;
			this.radioButton_is_debit.Location = new System.Drawing.Point(6, 43);
			this.radioButton_is_debit.Margin = new System.Windows.Forms.Padding(6);
			this.radioButton_is_debit.Name = "radioButton_is_debit";
			this.radioButton_is_debit.Size = new System.Drawing.Size(89, 25);
			this.radioButton_is_debit.TabIndex = 1;
			this.radioButton_is_debit.Text = "Списано";
			this.radioButton_is_debit.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.textBox_SerialNum, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.textBox_NameEquipment, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.textBox_InventoryNum, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label_Workshop, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label_SerialNum, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.label_InventoryNum, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.label_NameEquipment, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.label_GroupEquipment, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.comboBox_Workshop, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.comboBox_GroupEquipment, 1, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(81, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 6;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(380, 254);
			this.tableLayoutPanel3.TabIndex = 10;
			// 
			// textBox_SerialNum
			// 
			this.textBox_SerialNum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_SerialNum.Location = new System.Drawing.Point(174, 170);
			this.textBox_SerialNum.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_SerialNum.Name = "textBox_SerialNum";
			this.textBox_SerialNum.Size = new System.Drawing.Size(200, 29);
			this.textBox_SerialNum.TabIndex = 5;
			// 
			// textBox_NameEquipment
			// 
			this.textBox_NameEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_NameEquipment.Location = new System.Drawing.Point(174, 129);
			this.textBox_NameEquipment.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_NameEquipment.Name = "textBox_NameEquipment";
			this.textBox_NameEquipment.Size = new System.Drawing.Size(200, 29);
			this.textBox_NameEquipment.TabIndex = 4;
			// 
			// textBox_InventoryNum
			// 
			this.textBox_InventoryNum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_InventoryNum.Location = new System.Drawing.Point(174, 88);
			this.textBox_InventoryNum.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_InventoryNum.Name = "textBox_InventoryNum";
			this.textBox_InventoryNum.Size = new System.Drawing.Size(200, 29);
			this.textBox_InventoryNum.TabIndex = 3;
			// 
			// label_Workshop
			// 
			this.label_Workshop.AutoSize = true;
			this.label_Workshop.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Workshop.Location = new System.Drawing.Point(125, 0);
			this.label_Workshop.Name = "label_Workshop";
			this.label_Workshop.Size = new System.Drawing.Size(40, 41);
			this.label_Workshop.TabIndex = 9;
			this.label_Workshop.Text = "Цех:";
			this.label_Workshop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_SerialNum
			// 
			this.label_SerialNum.AutoSize = true;
			this.label_SerialNum.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_SerialNum.Location = new System.Drawing.Point(28, 164);
			this.label_SerialNum.Name = "label_SerialNum";
			this.label_SerialNum.Size = new System.Drawing.Size(137, 41);
			this.label_SerialNum.TabIndex = 1;
			this.label_SerialNum.Text = "Серийный номер:";
			this.label_SerialNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_InventoryNum
			// 
			this.label_InventoryNum.AutoSize = true;
			this.label_InventoryNum.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_InventoryNum.Location = new System.Drawing.Point(3, 82);
			this.label_InventoryNum.Name = "label_InventoryNum";
			this.label_InventoryNum.Size = new System.Drawing.Size(162, 41);
			this.label_InventoryNum.TabIndex = 2;
			this.label_InventoryNum.Text = "Инвентарный номер:";
			this.label_InventoryNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_NameEquipment
			// 
			this.label_NameEquipment.AutoSize = true;
			this.label_NameEquipment.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_NameEquipment.Location = new System.Drawing.Point(45, 123);
			this.label_NameEquipment.Name = "label_NameEquipment";
			this.label_NameEquipment.Size = new System.Drawing.Size(120, 41);
			this.label_NameEquipment.TabIndex = 0;
			this.label_NameEquipment.Text = "Наименование:";
			this.label_NameEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_GroupEquipment
			// 
			this.label_GroupEquipment.AutoSize = true;
			this.label_GroupEquipment.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_GroupEquipment.Location = new System.Drawing.Point(102, 41);
			this.label_GroupEquipment.Name = "label_GroupEquipment";
			this.label_GroupEquipment.Size = new System.Drawing.Size(63, 41);
			this.label_GroupEquipment.TabIndex = 3;
			this.label_GroupEquipment.Text = "Группа:";
			this.label_GroupEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox_Workshop
			// 
			this.comboBox_Workshop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBox_Workshop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboBox_Workshop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_Workshop.FormattingEnabled = true;
			this.comboBox_Workshop.Location = new System.Drawing.Point(174, 6);
			this.comboBox_Workshop.Margin = new System.Windows.Forms.Padding(6);
			this.comboBox_Workshop.Name = "comboBox_Workshop";
			this.comboBox_Workshop.Size = new System.Drawing.Size(200, 29);
			this.comboBox_Workshop.TabIndex = 1;
			this.comboBox_Workshop.SelectedIndexChanged += new System.EventHandler(this.comboBox_Workshop_SelectedIndexChanged);
			// 
			// comboBox_GroupEquipment
			// 
			this.comboBox_GroupEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_GroupEquipment.FormattingEnabled = true;
			this.comboBox_GroupEquipment.Location = new System.Drawing.Point(174, 47);
			this.comboBox_GroupEquipment.Margin = new System.Windows.Forms.Padding(6);
			this.comboBox_GroupEquipment.Name = "comboBox_GroupEquipment";
			this.comboBox_GroupEquipment.Size = new System.Drawing.Size(200, 29);
			this.comboBox_GroupEquipment.TabIndex = 2;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_PK,
            this.Column_NameEquipment,
            this.Column_InventoryNum,
            this.Column_PK_Workshop,
            this.Column_Workshop,
            this.Column_PK_Group,
            this.Column_GroupEquipment,
            this.Column_SerialNum,
            this.Column_Cost,
            this.Column2,
            this.Column1});
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(6, 347);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(6);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
			this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(972, 308);
			this.dataGridView.TabIndex = 12;
			this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
			// 
			// Column_PK
			// 
			this.Column_PK.HeaderText = "Первичный ключ";
			this.Column_PK.Name = "Column_PK";
			this.Column_PK.ReadOnly = true;
			this.Column_PK.Visible = false;
			// 
			// Column_NameEquipment
			// 
			this.Column_NameEquipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_NameEquipment.HeaderText = "Наименование";
			this.Column_NameEquipment.Name = "Column_NameEquipment";
			this.Column_NameEquipment.ReadOnly = true;
			// 
			// Column_InventoryNum
			// 
			this.Column_InventoryNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_InventoryNum.HeaderText = "Инвентарный номер";
			this.Column_InventoryNum.Name = "Column_InventoryNum";
			this.Column_InventoryNum.ReadOnly = true;
			// 
			// Column_PK_Workshop
			// 
			this.Column_PK_Workshop.HeaderText = "ПК_Цех";
			this.Column_PK_Workshop.Name = "Column_PK_Workshop";
			this.Column_PK_Workshop.ReadOnly = true;
			this.Column_PK_Workshop.Visible = false;
			// 
			// Column_Workshop
			// 
			this.Column_Workshop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_Workshop.HeaderText = "Цех";
			this.Column_Workshop.Name = "Column_Workshop";
			this.Column_Workshop.ReadOnly = true;
			// 
			// Column_PK_Group
			// 
			this.Column_PK_Group.HeaderText = "ПК_Группа";
			this.Column_PK_Group.Name = "Column_PK_Group";
			this.Column_PK_Group.ReadOnly = true;
			this.Column_PK_Group.Visible = false;
			// 
			// Column_GroupEquipment
			// 
			this.Column_GroupEquipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_GroupEquipment.HeaderText = "Группа";
			this.Column_GroupEquipment.Name = "Column_GroupEquipment";
			this.Column_GroupEquipment.ReadOnly = true;
			// 
			// Column_SerialNum
			// 
			this.Column_SerialNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_SerialNum.HeaderText = "Серийный номер";
			this.Column_SerialNum.Name = "Column_SerialNum";
			this.Column_SerialNum.ReadOnly = true;
			// 
			// Column_Cost
			// 
			this.Column_Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_Cost.HeaderText = "Стоимость";
			this.Column_Cost.Name = "Column_Cost";
			this.Column_Cost.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Списано";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 80;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Лизинг";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 80;
			// 
			// button_AddEquipment
			// 
			this.button_AddEquipment.Location = new System.Drawing.Point(3, 3);
			this.button_AddEquipment.Name = "button_AddEquipment";
			this.button_AddEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_AddEquipment.TabIndex = 9;
			this.button_AddEquipment.Text = "Добавить";
			this.button_AddEquipment.UseVisualStyleBackColor = true;
			this.button_AddEquipment.Click += new System.EventHandler(this.button_AddEquipment_Click);
			// 
			// button_EditEquipment
			// 
			this.button_EditEquipment.Location = new System.Drawing.Point(209, 3);
			this.button_EditEquipment.Name = "button_EditEquipment";
			this.button_EditEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_EditEquipment.TabIndex = 10;
			this.button_EditEquipment.Text = "Редактировать";
			this.button_EditEquipment.UseVisualStyleBackColor = true;
			this.button_EditEquipment.Click += new System.EventHandler(this.button_EditEquipment_Click);
			// 
			// button_RemoveEquipment
			// 
			this.button_RemoveEquipment.Location = new System.Drawing.Point(415, 3);
			this.button_RemoveEquipment.Name = "button_RemoveEquipment";
			this.button_RemoveEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_RemoveEquipment.TabIndex = 11;
			this.button_RemoveEquipment.Text = "Удалить";
			this.button_RemoveEquipment.UseVisualStyleBackColor = true;
			this.button_RemoveEquipment.Click += new System.EventHandler(this.button_RemoveEquipment_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox_Search, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 661);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.button_AddEquipment);
			this.flowLayoutPanel1.Controls.Add(this.button_EditEquipment);
			this.flowLayoutPanel1.Controls.Add(this.button_RemoveEquipment);
			this.flowLayoutPanel1.Controls.Add(this.button_show_act_contract);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 303);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(824, 35);
			this.flowLayoutPanel1.TabIndex = 14;
			// 
			// button_show_act_contract
			// 
			this.button_show_act_contract.Location = new System.Drawing.Point(621, 3);
			this.button_show_act_contract.Name = "button_show_act_contract";
			this.button_show_act_contract.Size = new System.Drawing.Size(200, 29);
			this.button_show_act_contract.TabIndex = 12;
			this.button_show_act_contract.Text = "Перейти к договору";
			this.button_show_act_contract.UseVisualStyleBackColor = true;
			this.button_show_act_contract.Visible = false;
			this.button_show_act_contract.Click += new System.EventHandler(this.button_show_act_contract_Click);
			// 
			// EquipmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(1000, 700);
			this.Name = "EquipmentForm";
			this.ShowIcon = false;
			this.Text = "Справочник - Оборудование";
			this.Activated += new System.EventHandler(this.Equipment_Activated);
			this.groupBox_Search.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ComboBox comboBox_GroupEquipment;
        private System.Windows.Forms.TextBox textBox_InventoryNum;
        private System.Windows.Forms.TextBox textBox_SerialNum;
        private System.Windows.Forms.TextBox textBox_NameEquipment;
        private System.Windows.Forms.Label label_GroupEquipment;
        private System.Windows.Forms.Label label_InventoryNum;
        private System.Windows.Forms.Label label_SerialNum;
        private System.Windows.Forms.Label label_NameEquipment;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox_Workshop;
        private System.Windows.Forms.Label label_Workshop;
        private System.Windows.Forms.Button button_AddEquipment;
        private System.Windows.Forms.Button button_EditEquipment;
        private System.Windows.Forms.Button button_RemoveEquipment;
        private System.Windows.Forms.Button button_ResetSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_is_debit;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.RadioButton radioButton_is_leasing;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_InventoryNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PK_Workshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Workshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PK_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GroupEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button button_show_act_contract;
    }
}