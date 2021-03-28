
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
			this.цехToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.организацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.причинаСписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox_Search = new System.Windows.Forms.GroupBox();
			this.pictureBox_Info = new System.Windows.Forms.PictureBox();
			this.button_Search = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label_DateCreateContract = new System.Windows.Forms.Label();
			this.textBox_ContractNumber = new System.Windows.Forms.TextBox();
			this.label_ContractNumber = new System.Windows.Forms.Label();
			this.label_Leaser = new System.Windows.Forms.Label();
			this.comboBox_Leaser = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column_RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_ContractNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Leaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_View = new System.Windows.Forms.DataGridViewLinkColumn();
			this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.groupBox_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лизингToolStripMenuItem,
            this.справочникиToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(803, 24);
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
			this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.оборудованиеToolStripMenuItem.Text = "Оборудование";
			// 
			// цехToolStripMenuItem
			// 
			this.цехToolStripMenuItem.Name = "цехToolStripMenuItem";
			this.цехToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.цехToolStripMenuItem.Text = "Цех";
			// 
			// организацияToolStripMenuItem
			// 
			this.организацияToolStripMenuItem.Name = "организацияToolStripMenuItem";
			this.организацияToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.организацияToolStripMenuItem.Text = "Организация";
			// 
			// причинаСписанияToolStripMenuItem
			// 
			this.причинаСписанияToolStripMenuItem.Name = "причинаСписанияToolStripMenuItem";
			this.причинаСписанияToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.причинаСписанияToolStripMenuItem.Text = "Причина списания";
			// 
			// groupBox_Search
			// 
			this.groupBox_Search.Controls.Add(this.pictureBox_Info);
			this.groupBox_Search.Controls.Add(this.button_Search);
			this.groupBox_Search.Controls.Add(this.dateTimePicker1);
			this.groupBox_Search.Controls.Add(this.label_DateCreateContract);
			this.groupBox_Search.Controls.Add(this.textBox_ContractNumber);
			this.groupBox_Search.Controls.Add(this.label_ContractNumber);
			this.groupBox_Search.Controls.Add(this.label_Leaser);
			this.groupBox_Search.Controls.Add(this.comboBox_Leaser);
			this.groupBox_Search.Location = new System.Drawing.Point(12, 27);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(779, 136);
			this.groupBox_Search.TabIndex = 1;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска договора (-ов)";
			// 
			// pictureBox_Info
			// 
			this.pictureBox_Info.Image = global::OGM.Properties.Resources.info;
			this.pictureBox_Info.Location = new System.Drawing.Point(757, 17);
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
			this.button_Search.Location = new System.Drawing.Point(407, 81);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(343, 29);
			this.button_Search.TabIndex = 3;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Location = new System.Drawing.Point(566, 36);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(184, 29);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// label_DateCreateContract
			// 
			this.label_DateCreateContract.AutoSize = true;
			this.label_DateCreateContract.Location = new System.Drawing.Point(403, 39);
			this.label_DateCreateContract.Name = "label_DateCreateContract";
			this.label_DateCreateContract.Size = new System.Drawing.Size(138, 21);
			this.label_DateCreateContract.TabIndex = 4;
			this.label_DateCreateContract.Text = "Дата заключения:";
			// 
			// textBox_ContractNumber
			// 
			this.textBox_ContractNumber.Location = new System.Drawing.Point(179, 36);
			this.textBox_ContractNumber.Name = "textBox_ContractNumber";
			this.textBox_ContractNumber.Size = new System.Drawing.Size(184, 29);
			this.textBox_ContractNumber.TabIndex = 0;
			// 
			// label_ContractNumber
			// 
			this.label_ContractNumber.AutoSize = true;
			this.label_ContractNumber.Location = new System.Drawing.Point(18, 39);
			this.label_ContractNumber.Name = "label_ContractNumber";
			this.label_ContractNumber.Size = new System.Drawing.Size(132, 21);
			this.label_ContractNumber.TabIndex = 2;
			this.label_ContractNumber.Text = "Номер договора:";
			// 
			// label_Leaser
			// 
			this.label_Leaser.AutoSize = true;
			this.label_Leaser.Location = new System.Drawing.Point(18, 84);
			this.label_Leaser.Name = "label_Leaser";
			this.label_Leaser.Size = new System.Drawing.Size(121, 21);
			this.label_Leaser.TabIndex = 1;
			this.label_Leaser.Text = "Лизингодатель:";
			// 
			// comboBox_Leaser
			// 
			this.comboBox_Leaser.FormattingEnabled = true;
			this.comboBox_Leaser.Location = new System.Drawing.Point(179, 81);
			this.comboBox_Leaser.Name = "comboBox_Leaser";
			this.comboBox_Leaser.Size = new System.Drawing.Size(184, 29);
			this.comboBox_Leaser.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_RowNumber,
            this.Column_ContractNum,
            this.Column_Date,
            this.Column_Leaser,
            this.Column_View});
			this.dataGridView1.Location = new System.Drawing.Point(13, 186);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(778, 349);
			this.dataGridView1.TabIndex = 4;
			// 
			// Column_RowNumber
			// 
			this.Column_RowNumber.HeaderText = "#";
			this.Column_RowNumber.Name = "Column_RowNumber";
			this.Column_RowNumber.ReadOnly = true;
			this.Column_RowNumber.Width = 50;
			// 
			// Column_ContractNum
			// 
			this.Column_ContractNum.HeaderText = "Номер договора";
			this.Column_ContractNum.Name = "Column_ContractNum";
			this.Column_ContractNum.ReadOnly = true;
			// 
			// Column_Date
			// 
			this.Column_Date.HeaderText = "Дата заключения";
			this.Column_Date.Name = "Column_Date";
			this.Column_Date.ReadOnly = true;
			this.Column_Date.Width = 200;
			// 
			// Column_Leaser
			// 
			this.Column_Leaser.HeaderText = "Лизингодатель";
			this.Column_Leaser.Name = "Column_Leaser";
			this.Column_Leaser.ReadOnly = true;
			this.Column_Leaser.Width = 360;
			// 
			// Column_View
			// 
			this.Column_View.HeaderText = "";
			this.Column_View.Name = "Column_View";
			this.Column_View.ReadOnly = true;
			// 
			// LeasingModuleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(803, 547);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox_Search);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LeasingModuleForm";
			this.Text = "Модуль лизинга";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeasingModuleForm_FormClosed);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.groupBox_Search.ResumeLayout(false);
			this.groupBox_Search.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_DateCreateContract;
        private System.Windows.Forms.TextBox textBox_ContractNumber;
        private System.Windows.Forms.Label label_ContractNumber;
        private System.Windows.Forms.Label label_Leaser;
        private System.Windows.Forms.PictureBox pictureBox_Info;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ContractNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Leaser;
        private System.Windows.Forms.DataGridViewLinkColumn Column_View;
    }
}