
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
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.button_ResetSearch = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.dateTimePicker_DateContract = new System.Windows.Forms.DateTimePicker();
            this.label_DateCreateContract = new System.Windows.Forms.Label();
            this.textBox_ContractNumber = new System.Windows.Forms.TextBox();
            this.label_ContractNumber = new System.Windows.Forms.Label();
            this.label_Leaser = new System.Windows.Forms.Label();
            this.comboBox_Leaser = new System.Windows.Forms.ComboBox();
            this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ContractNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Leaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_View = new System.Windows.Forms.DataGridViewLinkColumn();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лизингToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
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
            this.groupBox_Search.Controls.Add(this.pictureBox_Info);
            this.groupBox_Search.Controls.Add(this.button_ResetSearch);
            this.groupBox_Search.Controls.Add(this.button_Search);
            this.groupBox_Search.Controls.Add(this.dateTimePicker_DateContract);
            this.groupBox_Search.Controls.Add(this.label_DateCreateContract);
            this.groupBox_Search.Controls.Add(this.textBox_ContractNumber);
            this.groupBox_Search.Controls.Add(this.label_ContractNumber);
            this.groupBox_Search.Controls.Add(this.label_Leaser);
            this.groupBox_Search.Controls.Add(this.comboBox_Leaser);
            this.groupBox_Search.Location = new System.Drawing.Point(12, 27);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(860, 167);
            this.groupBox_Search.TabIndex = 1;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Параметры поиска договора (-ов)";
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.Image = global::OGM.Properties.Resources.info;
            this.pictureBox_Info.Location = new System.Drawing.Point(838, 18);
            this.pictureBox_Info.Name = "pictureBox_Info";
            this.pictureBox_Info.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Info.TabIndex = 6;
            this.pictureBox_Info.TabStop = false;
            this.toolTip_Info.SetToolTip(this.pictureBox_Info, "Поля необязательны к заполнению.\r\nВы можете выбрать только интересующие Вас парам" +
        "етры.");
            // 
            // button_ResetSearch
            // 
            this.button_ResetSearch.Location = new System.Drawing.Point(520, 76);
            this.button_ResetSearch.Name = "button_ResetSearch";
            this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
            this.button_ResetSearch.TabIndex = 4;
            this.button_ResetSearch.Text = "Сбросить параметры поиска";
            this.button_ResetSearch.UseVisualStyleBackColor = true;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(520, 36);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(300, 29);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_DateContract
            // 
            this.dateTimePicker_DateContract.CalendarFont = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_DateContract.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_DateContract.Location = new System.Drawing.Point(179, 116);
            this.dateTimePicker_DateContract.Name = "dateTimePicker_DateContract";
            this.dateTimePicker_DateContract.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_DateContract.TabIndex = 2;
            // 
            // label_DateCreateContract
            // 
            this.label_DateCreateContract.AutoSize = true;
            this.label_DateCreateContract.Location = new System.Drawing.Point(35, 120);
            this.label_DateCreateContract.Name = "label_DateCreateContract";
            this.label_DateCreateContract.Size = new System.Drawing.Size(138, 21);
            this.label_DateCreateContract.TabIndex = 4;
            this.label_DateCreateContract.Text = "Дата заключения:";
            // 
            // textBox_ContractNumber
            // 
            this.textBox_ContractNumber.Location = new System.Drawing.Point(179, 36);
            this.textBox_ContractNumber.Name = "textBox_ContractNumber";
            this.textBox_ContractNumber.Size = new System.Drawing.Size(200, 29);
            this.textBox_ContractNumber.TabIndex = 0;
            // 
            // label_ContractNumber
            // 
            this.label_ContractNumber.AutoSize = true;
            this.label_ContractNumber.Location = new System.Drawing.Point(41, 40);
            this.label_ContractNumber.Name = "label_ContractNumber";
            this.label_ContractNumber.Size = new System.Drawing.Size(132, 21);
            this.label_ContractNumber.TabIndex = 2;
            this.label_ContractNumber.Text = "Номер договора:";
            // 
            // label_Leaser
            // 
            this.label_Leaser.AutoSize = true;
            this.label_Leaser.Location = new System.Drawing.Point(52, 80);
            this.label_Leaser.Name = "label_Leaser";
            this.label_Leaser.Size = new System.Drawing.Size(121, 21);
            this.label_Leaser.TabIndex = 1;
            this.label_Leaser.Text = "Лизингодатель:";
            // 
            // comboBox_Leaser
            // 
            this.comboBox_Leaser.FormattingEnabled = true;
            this.comboBox_Leaser.Location = new System.Drawing.Point(179, 76);
            this.comboBox_Leaser.Name = "comboBox_Leaser";
            this.comboBox_Leaser.Size = new System.Drawing.Size(200, 29);
            this.comboBox_Leaser.TabIndex = 1;
            // 
            // dataGridView_DataSearch
            // 
            this.dataGridView_DataSearch.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView_DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column_PK,
            this.Column_ContractNum,
            this.Column_Date,
            this.Column_Leaser,
            this.Column_View});
            this.dataGridView_DataSearch.Location = new System.Drawing.Point(12, 200);
            this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
            this.dataGridView_DataSearch.ReadOnly = true;
            this.dataGridView_DataSearch.Size = new System.Drawing.Size(860, 349);
            this.dataGridView_DataSearch.TabIndex = 5;
            this.dataGridView_DataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DataSearch_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.Column_View.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // LeasingModuleForm
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
            this.Name = "LeasingModuleForm";
            this.Text = "Поиск договоров лизинга";
            this.Activated += new System.EventHandler(this.LeasingModuleForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeasingModuleForm_FormClosed);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ContractNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Leaser;
        private System.Windows.Forms.DataGridViewLinkColumn Column_View;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}