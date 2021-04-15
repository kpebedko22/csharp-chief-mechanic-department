
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label_ContractNumber = new System.Windows.Forms.Label();
			this.pictureBox_Info = new System.Windows.Forms.PictureBox();
			this.label_Leaser = new System.Windows.Forms.Label();
			this.button_ResetSearch = new System.Windows.Forms.Button();
			this.label_DateCreateContract = new System.Windows.Forms.Label();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_ContractNumber = new System.Windows.Forms.TextBox();
			this.dateTimePicker_DateContract = new System.Windows.Forms.DateTimePicker();
			this.comboBox_Leaser = new System.Windows.Forms.ComboBox();
			this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
			this.Column_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_ContractNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Leaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_View = new System.Windows.Forms.DataGridViewLinkColumn();
			this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
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
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.добавитьToolStripMenuItem.Text = "Добавить";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// найтиToolStripMenuItem
			// 
			this.найтиToolStripMenuItem.Enabled = false;
			this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
			this.найтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.groupBox_Search.Controls.Add(this.tableLayoutPanel2);
			this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_Search.Location = new System.Drawing.Point(6, 6);
			this.groupBox_Search.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(872, 158);
			this.groupBox_Search.TabIndex = 1;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска договора (-ов)";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 7;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.label_ContractNumber, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.pictureBox_Info, 6, 0);
			this.tableLayoutPanel2.Controls.Add(this.label_Leaser, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.button_ResetSearch, 4, 1);
			this.tableLayoutPanel2.Controls.Add(this.label_DateCreateContract, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.button_Search, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox_ContractNumber, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_DateContract, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.comboBox_Leaser, 2, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(866, 130);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// label_ContractNumber
			// 
			this.label_ContractNumber.AutoSize = true;
			this.label_ContractNumber.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_ContractNumber.Location = new System.Drawing.Point(61, 0);
			this.label_ContractNumber.Name = "label_ContractNumber";
			this.label_ContractNumber.Size = new System.Drawing.Size(132, 41);
			this.label_ContractNumber.TabIndex = 2;
			this.label_ContractNumber.Text = "Номер договора:";
			this.label_ContractNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox_Info
			// 
			this.pictureBox_Info.Image = global::OGM.Properties.Resources.info;
			this.pictureBox_Info.Location = new System.Drawing.Point(845, 3);
			this.pictureBox_Info.Name = "pictureBox_Info";
			this.pictureBox_Info.Size = new System.Drawing.Size(16, 16);
			this.pictureBox_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Info.TabIndex = 6;
			this.pictureBox_Info.TabStop = false;
			this.toolTip_Info.SetToolTip(this.pictureBox_Info, "Поля необязательны к заполнению.\r\nВы можете выбрать только интересующие Вас парам" +
        "етры.");
			// 
			// label_Leaser
			// 
			this.label_Leaser.AutoSize = true;
			this.label_Leaser.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Leaser.Location = new System.Drawing.Point(72, 41);
			this.label_Leaser.Name = "label_Leaser";
			this.label_Leaser.Size = new System.Drawing.Size(121, 41);
			this.label_Leaser.TabIndex = 1;
			this.label_Leaser.Text = "Лизингодатель:";
			this.label_Leaser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button_ResetSearch
			// 
			this.button_ResetSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_ResetSearch.Location = new System.Drawing.Point(484, 47);
			this.button_ResetSearch.Margin = new System.Windows.Forms.Padding(6);
			this.button_ResetSearch.Name = "button_ResetSearch";
			this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
			this.button_ResetSearch.TabIndex = 4;
			this.button_ResetSearch.Text = "Сбросить параметры поиска";
			this.button_ResetSearch.UseVisualStyleBackColor = true;
			this.button_ResetSearch.Click += new System.EventHandler(this.button_ResetSearch_Click);
			// 
			// label_DateCreateContract
			// 
			this.label_DateCreateContract.AutoSize = true;
			this.label_DateCreateContract.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_DateCreateContract.Location = new System.Drawing.Point(55, 82);
			this.label_DateCreateContract.Name = "label_DateCreateContract";
			this.label_DateCreateContract.Size = new System.Drawing.Size(138, 41);
			this.label_DateCreateContract.TabIndex = 4;
			this.label_DateCreateContract.Text = "Дата заключения:";
			this.label_DateCreateContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button_Search
			// 
			this.button_Search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_Search.Location = new System.Drawing.Point(484, 6);
			this.button_Search.Margin = new System.Windows.Forms.Padding(6);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(300, 29);
			this.button_Search.TabIndex = 3;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
			// 
			// textBox_ContractNumber
			// 
			this.textBox_ContractNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_ContractNumber.Location = new System.Drawing.Point(202, 6);
			this.textBox_ContractNumber.Margin = new System.Windows.Forms.Padding(6);
			this.textBox_ContractNumber.Name = "textBox_ContractNumber";
			this.textBox_ContractNumber.Size = new System.Drawing.Size(200, 29);
			this.textBox_ContractNumber.TabIndex = 0;
			// 
			// dateTimePicker_DateContract
			// 
			this.dateTimePicker_DateContract.CalendarFont = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_DateContract.Checked = false;
			this.dateTimePicker_DateContract.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePicker_DateContract.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_DateContract.Location = new System.Drawing.Point(202, 88);
			this.dateTimePicker_DateContract.Margin = new System.Windows.Forms.Padding(6);
			this.dateTimePicker_DateContract.Name = "dateTimePicker_DateContract";
			this.dateTimePicker_DateContract.ShowCheckBox = true;
			this.dateTimePicker_DateContract.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker_DateContract.TabIndex = 2;
			// 
			// comboBox_Leaser
			// 
			this.comboBox_Leaser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_Leaser.FormattingEnabled = true;
			this.comboBox_Leaser.Location = new System.Drawing.Point(202, 47);
			this.comboBox_Leaser.Margin = new System.Windows.Forms.Padding(6);
			this.comboBox_Leaser.Name = "comboBox_Leaser";
			this.comboBox_Leaser.Size = new System.Drawing.Size(200, 29);
			this.comboBox_Leaser.TabIndex = 1;
			// 
			// dataGridView_DataSearch
			// 
			this.dataGridView_DataSearch.AllowUserToAddRows = false;
			this.dataGridView_DataSearch.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView_DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_PK,
            this.Column_ContractNum,
            this.Column_Date,
            this.Column_Leaser,
            this.Column_View});
			this.dataGridView_DataSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_DataSearch.Location = new System.Drawing.Point(6, 176);
			this.dataGridView_DataSearch.Margin = new System.Windows.Forms.Padding(6);
			this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
			this.dataGridView_DataSearch.ReadOnly = true;
			this.dataGridView_DataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_DataSearch.Size = new System.Drawing.Size(872, 355);
			this.dataGridView_DataSearch.TabIndex = 5;
			this.dataGridView_DataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DataSearch_CellClick);
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
			this.Column_ContractNum.HeaderText = "Номер договора";
			this.Column_ContractNum.Name = "Column_ContractNum";
			this.Column_ContractNum.ReadOnly = true;
			// 
			// Column_Date
			// 
			this.Column_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_Date.HeaderText = "Дата заключения";
			this.Column_Date.Name = "Column_Date";
			this.Column_Date.ReadOnly = true;
			// 
			// Column_Leaser
			// 
			this.Column_Leaser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_Leaser.HeaderText = "Лизингодатель";
			this.Column_Leaser.Name = "Column_Leaser";
			this.Column_Leaser.ReadOnly = true;
			// 
			// Column_View
			// 
			this.Column_View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_View.HeaderText = "";
			this.Column_View.Name = "Column_View";
			this.Column_View.ReadOnly = true;
			this.Column_View.Text = "Просмотреть";
			this.Column_View.VisitedLinkColor = System.Drawing.Color.Blue;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox_Search, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView_DataSearch, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 537);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// LeasingModuleForm
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
			this.Name = "LeasingModuleForm";
			this.ShowIcon = false;
			this.Text = "Поиск договоров лизинга";
			this.Activated += new System.EventHandler(this.LeasingModuleForm_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeasingModuleForm_FormClosed);
			this.Load += new System.EventHandler(this.LeasingModuleForm_Load);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateContract;
        private System.Windows.Forms.Label label_DateCreateContract;
        private System.Windows.Forms.TextBox textBox_ContractNumber;
        private System.Windows.Forms.Label label_ContractNumber;
        private System.Windows.Forms.Label label_Leaser;
        private System.Windows.Forms.PictureBox pictureBox_Info;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridView dataGridView_DataSearch;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.ToolStripMenuItem группаОборудованияToolStripMenuItem;
		private System.Windows.Forms.Button button_ResetSearch;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ContractNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Leaser;
        private System.Windows.Forms.DataGridViewLinkColumn Column_View;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_ExitModule;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File_ExitProg;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}