
namespace OGM
{
    partial class LeasingModuleForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_File_ExitModule = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_File_ExitProg = new System.Windows.Forms.ToolStripMenuItem();
            this.лизингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цехToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.причинаСписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_before_end = new System.Windows.Forms.ComboBox();
            this.radioButton_after_end = new System.Windows.Forms.RadioButton();
            this.radioButton_before_end = new System.Windows.Forms.RadioButton();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.textBox_ContractNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateContract_Start = new System.Windows.Forms.DateTimePicker();
            this.label_ContractNumber = new System.Windows.Forms.Label();
            this.comboBox_Leaser = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DateContract_End = new System.Windows.Forms.DateTimePicker();
            this.label_Leaser = new System.Windows.Forms.Label();
            this.label_DateCreateContract = new System.Windows.Forms.Label();
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Column_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ContractNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Leaser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_View = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button_ResetSearch = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.лизингToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
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
            // лизингToolStripMenuItem
            // 
            this.лизингToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.найтиToolStripMenuItem});
            this.лизингToolStripMenuItem.Name = "лизингToolStripMenuItem";
            this.лизингToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.лизингToolStripMenuItem.Text = "Лизинг";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Enabled = false;
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оборудованиеToolStripMenuItem,
            this.группаОборудованияToolStripMenuItem,
            this.цехToolStripMenuItem,
            this.организацияToolStripMenuItem,
            this.причинаСписанияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование";
            this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
            // 
            // группаОборудованияToolStripMenuItem
            // 
            this.группаОборудованияToolStripMenuItem.Name = "группаОборудованияToolStripMenuItem";
            this.группаОборудованияToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.группаОборудованияToolStripMenuItem.Text = "Группа оборудования";
            this.группаОборудованияToolStripMenuItem.Click += new System.EventHandler(this.группаОборудованияToolStripMenuItem_Click);
            // 
            // цехToolStripMenuItem
            // 
            this.цехToolStripMenuItem.Name = "цехToolStripMenuItem";
            this.цехToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.цехToolStripMenuItem.Text = "Цех";
            this.цехToolStripMenuItem.Click += new System.EventHandler(this.цехToolStripMenuItem_Click);
            // 
            // организацияToolStripMenuItem
            // 
            this.организацияToolStripMenuItem.Name = "организацияToolStripMenuItem";
            this.организацияToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.организацияToolStripMenuItem.Text = "Организация";
            this.организацияToolStripMenuItem.Click += new System.EventHandler(this.организацияToolStripMenuItem_Click);
            // 
            // причинаСписанияToolStripMenuItem
            // 
            this.причинаСписанияToolStripMenuItem.Name = "причинаСписанияToolStripMenuItem";
            this.причинаСписанияToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.причинаСписанияToolStripMenuItem.Text = "Причина списания";
            this.причинаСписанияToolStripMenuItem.Click += new System.EventHandler(this.причинаСписанияToolStripMenuItem_Click);
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.button_ResetSearch);
            this.groupBox_Search.Controls.Add(this.button_Search);
            this.groupBox_Search.Controls.Add(this.groupBox1);
            this.groupBox_Search.Controls.Add(this.textBox_ContractNumber);
            this.groupBox_Search.Controls.Add(this.dateTimePicker_DateContract_Start);
            this.groupBox_Search.Controls.Add(this.label_ContractNumber);
            this.groupBox_Search.Controls.Add(this.comboBox_Leaser);
            this.groupBox_Search.Controls.Add(this.dateTimePicker_DateContract_End);
            this.groupBox_Search.Controls.Add(this.label_Leaser);
            this.groupBox_Search.Controls.Add(this.label_DateCreateContract);
            this.groupBox_Search.Controls.Add(this.pictureBox_Info);
            this.groupBox_Search.Controls.Add(this.label1);
            this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Search.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Search.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(872, 258);
            this.groupBox_Search.TabIndex = 1;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Параметры поиска договора (-ов)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_before_end);
            this.groupBox1.Controls.Add(this.radioButton_after_end);
            this.groupBox1.Controls.Add(this.radioButton_before_end);
            this.groupBox1.Controls.Add(this.radioButton_all);
            this.groupBox1.Location = new System.Drawing.Point(445, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Срок";
            // 
            // comboBox_before_end
            // 
            this.comboBox_before_end.Enabled = false;
            this.comboBox_before_end.FormattingEnabled = true;
            this.comboBox_before_end.Items.AddRange(new object[] {
            "Не истекает",
            "1 недели",
            "1 месяца",
            "3 месяцев",
            "6 месяцев",
            "1 года"});
            this.comboBox_before_end.Location = new System.Drawing.Point(191, 52);
            this.comboBox_before_end.Name = "comboBox_before_end";
            this.comboBox_before_end.Size = new System.Drawing.Size(195, 29);
            this.comboBox_before_end.TabIndex = 3;
            // 
            // radioButton_after_end
            // 
            this.radioButton_after_end.AutoSize = true;
            this.radioButton_after_end.Location = new System.Drawing.Point(18, 86);
            this.radioButton_after_end.Name = "radioButton_after_end";
            this.radioButton_after_end.Size = new System.Drawing.Size(70, 25);
            this.radioButton_after_end.TabIndex = 2;
            this.radioButton_after_end.Text = "Истек";
            this.radioButton_after_end.UseVisualStyleBackColor = true;
            // 
            // radioButton_before_end
            // 
            this.radioButton_before_end.AutoSize = true;
            this.radioButton_before_end.Location = new System.Drawing.Point(18, 54);
            this.radioButton_before_end.Name = "radioButton_before_end";
            this.radioButton_before_end.Size = new System.Drawing.Size(167, 25);
            this.radioButton_before_end.TabIndex = 1;
            this.radioButton_before_end.Text = "Истекает в течение";
            this.radioButton_before_end.UseVisualStyleBackColor = true;
            this.radioButton_before_end.CheckedChanged += new System.EventHandler(this.radioButton_before_end_CheckedChanged);
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Checked = true;
            this.radioButton_all.Location = new System.Drawing.Point(18, 23);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(52, 25);
            this.radioButton_all.TabIndex = 0;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "Все";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // textBox_ContractNumber
            // 
            this.textBox_ContractNumber.Location = new System.Drawing.Point(194, 44);
            this.textBox_ContractNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_ContractNumber.Name = "textBox_ContractNumber";
            this.textBox_ContractNumber.Size = new System.Drawing.Size(200, 29);
            this.textBox_ContractNumber.TabIndex = 0;
            // 
            // dateTimePicker_DateContract_Start
            // 
            this.dateTimePicker_DateContract_Start.CalendarFont = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_DateContract_Start.Checked = false;
            this.dateTimePicker_DateContract_Start.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_DateContract_Start.Location = new System.Drawing.Point(194, 143);
            this.dateTimePicker_DateContract_Start.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker_DateContract_Start.Name = "dateTimePicker_DateContract_Start";
            this.dateTimePicker_DateContract_Start.ShowCheckBox = true;
            this.dateTimePicker_DateContract_Start.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_DateContract_Start.TabIndex = 2;
            // 
            // label_ContractNumber
            // 
            this.label_ContractNumber.AutoSize = true;
            this.label_ContractNumber.Location = new System.Drawing.Point(46, 48);
            this.label_ContractNumber.Name = "label_ContractNumber";
            this.label_ContractNumber.Size = new System.Drawing.Size(129, 21);
            this.label_ContractNumber.TabIndex = 2;
            this.label_ContractNumber.Text = "Номер договора";
            this.label_ContractNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_Leaser
            // 
            this.comboBox_Leaser.FormattingEnabled = true;
            this.comboBox_Leaser.Location = new System.Drawing.Point(194, 92);
            this.comboBox_Leaser.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Leaser.Name = "comboBox_Leaser";
            this.comboBox_Leaser.Size = new System.Drawing.Size(200, 29);
            this.comboBox_Leaser.TabIndex = 1;
            // 
            // dateTimePicker_DateContract_End
            // 
            this.dateTimePicker_DateContract_End.Checked = false;
            this.dateTimePicker_DateContract_End.Location = new System.Drawing.Point(194, 193);
            this.dateTimePicker_DateContract_End.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker_DateContract_End.Name = "dateTimePicker_DateContract_End";
            this.dateTimePicker_DateContract_End.ShowCheckBox = true;
            this.dateTimePicker_DateContract_End.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_DateContract_End.TabIndex = 7;
            // 
            // label_Leaser
            // 
            this.label_Leaser.AutoSize = true;
            this.label_Leaser.Location = new System.Drawing.Point(57, 96);
            this.label_Leaser.Name = "label_Leaser";
            this.label_Leaser.Size = new System.Drawing.Size(118, 21);
            this.label_Leaser.TabIndex = 1;
            this.label_Leaser.Text = "Лизингодатель";
            this.label_Leaser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_DateCreateContract
            // 
            this.label_DateCreateContract.AutoSize = true;
            this.label_DateCreateContract.Location = new System.Drawing.Point(20, 146);
            this.label_DateCreateContract.Name = "label_DateCreateContract";
            this.label_DateCreateContract.Size = new System.Drawing.Size(155, 21);
            this.label_DateCreateContract.TabIndex = 4;
            this.label_DateCreateContract.Text = "Дата заключения от";
            this.label_DateCreateContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.Image = global::OGM.Properties.Resources.info;
            this.pictureBox_Info.Location = new System.Drawing.Point(850, 25);
            this.pictureBox_Info.Name = "pictureBox_Info";
            this.pictureBox_Info.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Info.TabIndex = 6;
            this.pictureBox_Info.TabStop = false;
            this.toolTip_Info.SetToolTip(this.pictureBox_Info, "Поля необязательны к заполнению.\r\nВы можете выбрать только интересующие Вас парам" +
        "етры.");
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(500, 44);
            this.button_Search.Margin = new System.Windows.Forms.Padding(6);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(300, 29);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата заключения до";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView_DataSearch
            // 
            this.dataGridView_DataSearch.AllowUserToAddRows = false;
            this.dataGridView_DataSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_DataSearch.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView_DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_PK,
            this.Column_ContractNum,
            this.Column_Date,
            this.Column1,
            this.Column_Leaser,
            this.Column_View});
            this.dataGridView_DataSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DataSearch.Location = new System.Drawing.Point(6, 276);
            this.dataGridView_DataSearch.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
            this.dataGridView_DataSearch.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridView_DataSearch.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_DataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DataSearch.Size = new System.Drawing.Size(872, 355);
            this.dataGridView_DataSearch.TabIndex = 5;
            this.dataGridView_DataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DataSearch_CellClick);
            this.dataGridView_DataSearch.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_DataSearch_RowPostPaint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Search, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_DataSearch, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 637);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Column_PK
            // 
            this.Column_PK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_PK.HeaderText = "Первичный ключ";
            this.Column_PK.Name = "Column_PK";
            this.Column_PK.ReadOnly = true;
            this.Column_PK.Visible = false;
            // 
            // Column_ContractNum
            // 
            this.Column_ContractNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ContractNum.FillWeight = 3.826431F;
            this.Column_ContractNum.HeaderText = "Номер договора";
            this.Column_ContractNum.Name = "Column_ContractNum";
            this.Column_ContractNum.ReadOnly = true;
            // 
            // Column_Date
            // 
            this.Column_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Date.FillWeight = 3.826431F;
            this.Column_Date.HeaderText = "Дата заключения";
            this.Column_Date.Name = "Column_Date";
            this.Column_Date.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата окончания";
            this.Column1.MinimumWidth = 60;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column_Leaser
            // 
            this.Column_Leaser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column_Leaser.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_Leaser.FillWeight = 3.826431F;
            this.Column_Leaser.HeaderText = "Лизингодатель";
            this.Column_Leaser.Name = "Column_Leaser";
            this.Column_Leaser.ReadOnly = true;
            this.Column_Leaser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Leaser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Leaser.ToolTipText = "Щелкни, чтобы просмотреть организацию";
            // 
            // Column_View
            // 
            this.Column_View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_View.FillWeight = 3.826431F;
            this.Column_View.HeaderText = "";
            this.Column_View.Name = "Column_View";
            this.Column_View.ReadOnly = true;
            this.Column_View.Text = "Просмотреть";
            this.Column_View.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // button_ResetSearch
            // 
            this.button_ResetSearch.Location = new System.Drawing.Point(500, 92);
            this.button_ResetSearch.Margin = new System.Windows.Forms.Padding(6);
            this.button_ResetSearch.Name = "button_ResetSearch";
            this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
            this.button_ResetSearch.TabIndex = 10;
            this.button_ResetSearch.Text = "Сбросить параметры поиска";
            this.button_ResetSearch.UseVisualStyleBackColor = true;
            // 
            // LeasingModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "LeasingModuleForm";
            this.ShowIcon = false;
            this.Text = "Поиск договоров лизинга";
            this.Activated += new System.EventHandler(this.LeasingModuleForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeasingModuleForm_FormClosed);
            this.Load += new System.EventHandler(this.LeasingModuleForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem лизингToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цехToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem организацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem причинаСписанияToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.ComboBox comboBox_Leaser;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateContract_Start;
        private System.Windows.Forms.Label label_DateCreateContract;
        private System.Windows.Forms.TextBox textBox_ContractNumber;
        private System.Windows.Forms.Label label_ContractNumber;
        private System.Windows.Forms.Label label_Leaser;
        private System.Windows.Forms.PictureBox pictureBox_Info;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridView dataGridView_DataSearch;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.ToolStripMenuItem группаОборудованияToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_ExitModule;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_ExitProg;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateContract_End;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox_before_end;
		private System.Windows.Forms.RadioButton radioButton_after_end;
		private System.Windows.Forms.RadioButton radioButton_before_end;
		private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ContractNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Leaser;
        private System.Windows.Forms.DataGridViewLinkColumn Column_View;
        private System.Windows.Forms.Button button_ResetSearch;
    }
}