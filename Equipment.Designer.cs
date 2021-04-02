
namespace OGM
{
    partial class Equipment
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
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.button_ResetSearch = new System.Windows.Forms.Button();
            this.comboBox_Workshop = new System.Windows.Forms.ComboBox();
            this.label_Workshop = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.comboBox_GroupEquipment = new System.Windows.Forms.ComboBox();
            this.textBox_InventoryNum = new System.Windows.Forms.TextBox();
            this.textBox_SerialNum = new System.Windows.Forms.TextBox();
            this.textBox_NameEquipment = new System.Windows.Forms.TextBox();
            this.label_GroupEquipment = new System.Windows.Forms.Label();
            this.label_InventoryNum = new System.Windows.Forms.Label();
            this.label_SerialNum = new System.Windows.Forms.Label();
            this.label_NameEquipment = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_AddEquipment = new System.Windows.Forms.Button();
            this.button_EditEquipment = new System.Windows.Forms.Button();
            this.button_RemoveEquipment = new System.Windows.Forms.Button();
            this.Column_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NameEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_InventoryNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Workshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GroupEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.button_ResetSearch);
            this.groupBox_Search.Controls.Add(this.comboBox_Workshop);
            this.groupBox_Search.Controls.Add(this.label_Workshop);
            this.groupBox_Search.Controls.Add(this.button_Search);
            this.groupBox_Search.Controls.Add(this.comboBox_GroupEquipment);
            this.groupBox_Search.Controls.Add(this.textBox_InventoryNum);
            this.groupBox_Search.Controls.Add(this.textBox_SerialNum);
            this.groupBox_Search.Controls.Add(this.textBox_NameEquipment);
            this.groupBox_Search.Controls.Add(this.label_GroupEquipment);
            this.groupBox_Search.Controls.Add(this.label_InventoryNum);
            this.groupBox_Search.Controls.Add(this.label_SerialNum);
            this.groupBox_Search.Controls.Add(this.label_NameEquipment);
            this.groupBox_Search.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(860, 258);
            this.groupBox_Search.TabIndex = 0;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Параметры поиска";
            // 
            // button_ResetSearch
            // 
            this.button_ResetSearch.Location = new System.Drawing.Point(520, 76);
            this.button_ResetSearch.Name = "button_ResetSearch";
            this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
            this.button_ResetSearch.TabIndex = 7;
            this.button_ResetSearch.Text = "Сбросить параметры поиска";
            this.button_ResetSearch.UseVisualStyleBackColor = true;
            // 
            // comboBox_Workshop
            // 
            this.comboBox_Workshop.FormattingEnabled = true;
            this.comboBox_Workshop.Location = new System.Drawing.Point(175, 40);
            this.comboBox_Workshop.Name = "comboBox_Workshop";
            this.comboBox_Workshop.Size = new System.Drawing.Size(200, 29);
            this.comboBox_Workshop.TabIndex = 1;
            // 
            // label_Workshop
            // 
            this.label_Workshop.AutoSize = true;
            this.label_Workshop.Location = new System.Drawing.Point(129, 43);
            this.label_Workshop.Name = "label_Workshop";
            this.label_Workshop.Size = new System.Drawing.Size(40, 21);
            this.label_Workshop.TabIndex = 9;
            this.label_Workshop.Text = "Цех:";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(520, 36);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(300, 29);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // comboBox_GroupEquipment
            // 
            this.comboBox_GroupEquipment.FormattingEnabled = true;
            this.comboBox_GroupEquipment.Location = new System.Drawing.Point(175, 80);
            this.comboBox_GroupEquipment.Name = "comboBox_GroupEquipment";
            this.comboBox_GroupEquipment.Size = new System.Drawing.Size(200, 29);
            this.comboBox_GroupEquipment.TabIndex = 2;
            // 
            // textBox_InventoryNum
            // 
            this.textBox_InventoryNum.Location = new System.Drawing.Point(175, 120);
            this.textBox_InventoryNum.Name = "textBox_InventoryNum";
            this.textBox_InventoryNum.Size = new System.Drawing.Size(200, 29);
            this.textBox_InventoryNum.TabIndex = 3;
            // 
            // textBox_SerialNum
            // 
            this.textBox_SerialNum.Location = new System.Drawing.Point(175, 200);
            this.textBox_SerialNum.Name = "textBox_SerialNum";
            this.textBox_SerialNum.Size = new System.Drawing.Size(200, 29);
            this.textBox_SerialNum.TabIndex = 5;
            // 
            // textBox_NameEquipment
            // 
            this.textBox_NameEquipment.Location = new System.Drawing.Point(175, 160);
            this.textBox_NameEquipment.Name = "textBox_NameEquipment";
            this.textBox_NameEquipment.Size = new System.Drawing.Size(200, 29);
            this.textBox_NameEquipment.TabIndex = 4;
            // 
            // label_GroupEquipment
            // 
            this.label_GroupEquipment.AutoSize = true;
            this.label_GroupEquipment.Location = new System.Drawing.Point(105, 83);
            this.label_GroupEquipment.Name = "label_GroupEquipment";
            this.label_GroupEquipment.Size = new System.Drawing.Size(64, 21);
            this.label_GroupEquipment.TabIndex = 3;
            this.label_GroupEquipment.Text = "Группа:";
            // 
            // label_InventoryNum
            // 
            this.label_InventoryNum.AutoSize = true;
            this.label_InventoryNum.Location = new System.Drawing.Point(7, 123);
            this.label_InventoryNum.Name = "label_InventoryNum";
            this.label_InventoryNum.Size = new System.Drawing.Size(162, 21);
            this.label_InventoryNum.TabIndex = 2;
            this.label_InventoryNum.Text = "Инвентарный номер:";
            // 
            // label_SerialNum
            // 
            this.label_SerialNum.AutoSize = true;
            this.label_SerialNum.Location = new System.Drawing.Point(32, 203);
            this.label_SerialNum.Name = "label_SerialNum";
            this.label_SerialNum.Size = new System.Drawing.Size(137, 21);
            this.label_SerialNum.TabIndex = 1;
            this.label_SerialNum.Text = "Серийный номер:";
            // 
            // label_NameEquipment
            // 
            this.label_NameEquipment.AutoSize = true;
            this.label_NameEquipment.Location = new System.Drawing.Point(49, 163);
            this.label_NameEquipment.Name = "label_NameEquipment";
            this.label_NameEquipment.Size = new System.Drawing.Size(120, 21);
            this.label_NameEquipment.TabIndex = 0;
            this.label_NameEquipment.Text = "Наименование:";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_PK,
            this.Column_NameEquipment,
            this.Column_InventoryNum,
            this.Column_Workshop,
            this.Column_GroupEquipment,
            this.Column_SerialNum});
            this.dataGridView.Location = new System.Drawing.Point(12, 339);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(860, 310);
            this.dataGridView.TabIndex = 11;
            // 
            // button_AddEquipment
            // 
            this.button_AddEquipment.Location = new System.Drawing.Point(12, 290);
            this.button_AddEquipment.Name = "button_AddEquipment";
            this.button_AddEquipment.Size = new System.Drawing.Size(200, 29);
            this.button_AddEquipment.TabIndex = 8;
            this.button_AddEquipment.Text = "Добавить";
            this.button_AddEquipment.UseVisualStyleBackColor = true;
            this.button_AddEquipment.Click += new System.EventHandler(this.button_AddEquipment_Click);
            // 
            // button_EditEquipment
            // 
            this.button_EditEquipment.Location = new System.Drawing.Point(218, 290);
            this.button_EditEquipment.Name = "button_EditEquipment";
            this.button_EditEquipment.Size = new System.Drawing.Size(200, 29);
            this.button_EditEquipment.TabIndex = 9;
            this.button_EditEquipment.Text = "Редактировать";
            this.button_EditEquipment.UseVisualStyleBackColor = true;
            // 
            // button_RemoveEquipment
            // 
            this.button_RemoveEquipment.Location = new System.Drawing.Point(424, 290);
            this.button_RemoveEquipment.Name = "button_RemoveEquipment";
            this.button_RemoveEquipment.Size = new System.Drawing.Size(200, 29);
            this.button_RemoveEquipment.TabIndex = 10;
            this.button_RemoveEquipment.Text = "Удалить";
            this.button_RemoveEquipment.UseVisualStyleBackColor = true;
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
            // Column_Workshop
            // 
            this.Column_Workshop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Workshop.HeaderText = "Цех";
            this.Column_Workshop.Name = "Column_Workshop";
            this.Column_Workshop.ReadOnly = true;
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
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button_RemoveEquipment);
            this.Controls.Add(this.button_EditEquipment);
            this.Controls.Add(this.button_AddEquipment);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox_Search);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Equipment";
            this.Text = "Справочник - Оборудование";
            this.Activated += new System.EventHandler(this.Equipment_Activated);
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_InventoryNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Workshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GroupEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SerialNum;
    }
}