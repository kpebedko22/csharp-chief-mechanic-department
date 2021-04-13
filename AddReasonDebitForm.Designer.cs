
namespace OGM
{
    partial class AddReasonDebitForm
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
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddAndClose = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_CipherReasonDebit = new System.Windows.Forms.TextBox();
            this.textBox_NameReasonDebit = new System.Windows.Forms.TextBox();
            this.label_CipherReasonDebit = new System.Windows.Forms.Label();
            this.label_NameReasonDebit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(391, 118);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(180, 29);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Отмена";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddAndClose
            // 
            this.button_AddAndClose.Location = new System.Drawing.Point(202, 118);
            this.button_AddAndClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddAndClose.Name = "button_AddAndClose";
            this.button_AddAndClose.Size = new System.Drawing.Size(180, 29);
            this.button_AddAndClose.TabIndex = 4;
            this.button_AddAndClose.Text = "Добавить и закрыть";
            this.button_AddAndClose.UseVisualStyleBackColor = true;
            this.button_AddAndClose.Click += new System.EventHandler(this.button_AddAndClose_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(13, 118);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 29);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_CipherReasonDebit
            // 
            this.textBox_CipherReasonDebit.Location = new System.Drawing.Point(201, 14);
            this.textBox_CipherReasonDebit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CipherReasonDebit.MaxLength = 19;
            this.textBox_CipherReasonDebit.Name = "textBox_CipherReasonDebit";
            this.textBox_CipherReasonDebit.Size = new System.Drawing.Size(370, 29);
            this.textBox_CipherReasonDebit.TabIndex = 1;
            // 
            // textBox_NameReasonDebit
            // 
            this.textBox_NameReasonDebit.Location = new System.Drawing.Point(202, 62);
            this.textBox_NameReasonDebit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_NameReasonDebit.MaxLength = 149;
            this.textBox_NameReasonDebit.Name = "textBox_NameReasonDebit";
            this.textBox_NameReasonDebit.Size = new System.Drawing.Size(370, 29);
            this.textBox_NameReasonDebit.TabIndex = 2;
            // 
            // label_CipherReasonDebit
            // 
            this.label_CipherReasonDebit.AutoSize = true;
            this.label_CipherReasonDebit.Location = new System.Drawing.Point(136, 18);
            this.label_CipherReasonDebit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CipherReasonDebit.Name = "label_CipherReasonDebit";
            this.label_CipherReasonDebit.Size = new System.Drawing.Size(57, 21);
            this.label_CipherReasonDebit.TabIndex = 32;
            this.label_CipherReasonDebit.Text = "Шифр:";
            // 
            // label_NameReasonDebit
            // 
            this.label_NameReasonDebit.AutoSize = true;
            this.label_NameReasonDebit.Location = new System.Drawing.Point(74, 66);
            this.label_NameReasonDebit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NameReasonDebit.Name = "label_NameReasonDebit";
            this.label_NameReasonDebit.Size = new System.Drawing.Size(120, 21);
            this.label_NameReasonDebit.TabIndex = 31;
            this.label_NameReasonDebit.Text = "Наименование:";
            // 
            // AddReasonDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_AddAndClose);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_CipherReasonDebit);
            this.Controls.Add(this.textBox_NameReasonDebit);
            this.Controls.Add(this.label_CipherReasonDebit);
            this.Controls.Add(this.label_NameReasonDebit);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReasonDebitForm";
            this.Text = "Справочник - Добавить причину списания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddAndClose;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_CipherReasonDebit;
        private System.Windows.Forms.TextBox textBox_NameReasonDebit;
        private System.Windows.Forms.Label label_CipherReasonDebit;
        private System.Windows.Forms.Label label_NameReasonDebit;
    }
}