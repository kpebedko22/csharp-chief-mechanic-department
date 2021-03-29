
namespace OGM
{
    partial class ReasonDebitForm
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
            this.button_RemoveReasonDebit = new System.Windows.Forms.Button();
            this.button_EditReasonDebit = new System.Windows.Forms.Button();
            this.button_AddReasonDebit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_CipherReasonDebit = new System.Windows.Forms.TextBox();
            this.textBox_NameReasonDebit = new System.Windows.Forms.TextBox();
            this.label_Cipher = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.Column_NameReasonDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CipherReasonDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_RemoveReasonDebit
            // 
            this.button_RemoveReasonDebit.Location = new System.Drawing.Point(439, 135);
            this.button_RemoveReasonDebit.Name = "button_RemoveReasonDebit";
            this.button_RemoveReasonDebit.Size = new System.Drawing.Size(206, 29);
            this.button_RemoveReasonDebit.TabIndex = 21;
            this.button_RemoveReasonDebit.Text = "Удалить";
            this.button_RemoveReasonDebit.UseVisualStyleBackColor = true;
            // 
            // button_EditReasonDebit
            // 
            this.button_EditReasonDebit.Location = new System.Drawing.Point(227, 135);
            this.button_EditReasonDebit.Name = "button_EditReasonDebit";
            this.button_EditReasonDebit.Size = new System.Drawing.Size(206, 29);
            this.button_EditReasonDebit.TabIndex = 20;
            this.button_EditReasonDebit.Text = "Редактировать";
            this.button_EditReasonDebit.UseVisualStyleBackColor = true;
            // 
            // button_AddReasonDebit
            // 
            this.button_AddReasonDebit.Location = new System.Drawing.Point(15, 135);
            this.button_AddReasonDebit.Name = "button_AddReasonDebit";
            this.button_AddReasonDebit.Size = new System.Drawing.Size(206, 29);
            this.button_AddReasonDebit.TabIndex = 19;
            this.button_AddReasonDebit.Text = "Добавить";
            this.button_AddReasonDebit.UseVisualStyleBackColor = true;
            this.button_AddReasonDebit.Click += new System.EventHandler(this.button_AddEquipment_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NameReasonDebit,
            this.Column_CipherReasonDebit});
            this.dataGridView.Location = new System.Drawing.Point(15, 170);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(675, 327);
            this.dataGridView.TabIndex = 18;
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.button_Search);
            this.groupBox_Search.Controls.Add(this.textBox_CipherReasonDebit);
            this.groupBox_Search.Controls.Add(this.textBox_NameReasonDebit);
            this.groupBox_Search.Controls.Add(this.label_Cipher);
            this.groupBox_Search.Controls.Add(this.label_Name);
            this.groupBox_Search.Location = new System.Drawing.Point(15, 12);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(683, 111);
            this.groupBox_Search.TabIndex = 17;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Параметры поиска";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(452, 64);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(206, 29);
            this.button_Search.TabIndex = 8;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // textBox_CipherReasonDebit
            // 
            this.textBox_CipherReasonDebit.Location = new System.Drawing.Point(452, 22);
            this.textBox_CipherReasonDebit.Name = "textBox_CipherReasonDebit";
            this.textBox_CipherReasonDebit.Size = new System.Drawing.Size(206, 29);
            this.textBox_CipherReasonDebit.TabIndex = 6;
            // 
            // textBox_NameReasonDebit
            // 
            this.textBox_NameReasonDebit.Location = new System.Drawing.Point(167, 22);
            this.textBox_NameReasonDebit.Name = "textBox_NameReasonDebit";
            this.textBox_NameReasonDebit.Size = new System.Drawing.Size(193, 29);
            this.textBox_NameReasonDebit.TabIndex = 4;
            // 
            // label_Cipher
            // 
            this.label_Cipher.AutoSize = true;
            this.label_Cipher.Location = new System.Drawing.Point(389, 25);
            this.label_Cipher.Name = "label_Cipher";
            this.label_Cipher.Size = new System.Drawing.Size(57, 21);
            this.label_Cipher.TabIndex = 2;
            this.label_Cipher.Text = "Шифр:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(21, 25);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(120, 21);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Наименование:";
            // 
            // Column_NameReasonDebit
            // 
            this.Column_NameReasonDebit.HeaderText = "Наименование";
            this.Column_NameReasonDebit.Name = "Column_NameReasonDebit";
            this.Column_NameReasonDebit.ReadOnly = true;
            this.Column_NameReasonDebit.Width = 430;
            // 
            // Column_CipherReasonDebit
            // 
            this.Column_CipherReasonDebit.HeaderText = "Шифр";
            this.Column_CipherReasonDebit.Name = "Column_CipherReasonDebit";
            this.Column_CipherReasonDebit.ReadOnly = true;
            this.Column_CipherReasonDebit.Width = 200;
            // 
            // ReasonDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 507);
            this.Controls.Add(this.button_RemoveReasonDebit);
            this.Controls.Add(this.button_EditReasonDebit);
            this.Controls.Add(this.button_AddReasonDebit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox_Search);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReasonDebitForm";
            this.Text = "Справочник - Причина списания";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RemoveReasonDebit;
        private System.Windows.Forms.Button button_EditReasonDebit;
        private System.Windows.Forms.Button button_AddReasonDebit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_CipherReasonDebit;
        private System.Windows.Forms.TextBox textBox_NameReasonDebit;
        private System.Windows.Forms.Label label_Cipher;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameReasonDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CipherReasonDebit;
    }
}