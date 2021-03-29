
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_AddReasonDebitAndClose = new System.Windows.Forms.Button();
            this.button_AddReasonDebit = new System.Windows.Forms.Button();
            this.textBox_CipherReasonDebit = new System.Windows.Forms.TextBox();
            this.textBox_NameReasonDebit = new System.Windows.Forms.TextBox();
            this.label_CipherReasonDebit = new System.Windows.Forms.Label();
            this.label_NameReasonDebit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(17, 116);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(128, 29);
            this.button_Cancel.TabIndex = 37;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_AddReasonDebitAndClose
            // 
            this.button_AddReasonDebitAndClose.Location = new System.Drawing.Point(153, 116);
            this.button_AddReasonDebitAndClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddReasonDebitAndClose.Name = "button_AddReasonDebitAndClose";
            this.button_AddReasonDebitAndClose.Size = new System.Drawing.Size(166, 29);
            this.button_AddReasonDebitAndClose.TabIndex = 36;
            this.button_AddReasonDebitAndClose.Text = "Добавить и закрыть";
            this.button_AddReasonDebitAndClose.UseVisualStyleBackColor = true;
            // 
            // button_AddReasonDebit
            // 
            this.button_AddReasonDebit.Location = new System.Drawing.Point(327, 116);
            this.button_AddReasonDebit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddReasonDebit.Name = "button_AddReasonDebit";
            this.button_AddReasonDebit.Size = new System.Drawing.Size(164, 29);
            this.button_AddReasonDebit.TabIndex = 35;
            this.button_AddReasonDebit.Text = "Добавить";
            this.button_AddReasonDebit.UseVisualStyleBackColor = true;
            // 
            // textBox_CipherReasonDebit
            // 
            this.textBox_CipherReasonDebit.Location = new System.Drawing.Point(159, 63);
            this.textBox_CipherReasonDebit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CipherReasonDebit.Name = "textBox_CipherReasonDebit";
            this.textBox_CipherReasonDebit.Size = new System.Drawing.Size(332, 29);
            this.textBox_CipherReasonDebit.TabIndex = 34;
            // 
            // textBox_NameReasonDebit
            // 
            this.textBox_NameReasonDebit.Location = new System.Drawing.Point(159, 19);
            this.textBox_NameReasonDebit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_NameReasonDebit.Name = "textBox_NameReasonDebit";
            this.textBox_NameReasonDebit.Size = new System.Drawing.Size(332, 29);
            this.textBox_NameReasonDebit.TabIndex = 33;
            // 
            // label_CipherReasonDebit
            // 
            this.label_CipherReasonDebit.AutoSize = true;
            this.label_CipherReasonDebit.Location = new System.Drawing.Point(13, 66);
            this.label_CipherReasonDebit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CipherReasonDebit.Name = "label_CipherReasonDebit";
            this.label_CipherReasonDebit.Size = new System.Drawing.Size(57, 21);
            this.label_CipherReasonDebit.TabIndex = 32;
            this.label_CipherReasonDebit.Text = "Шифр:";
            // 
            // label_NameReasonDebit
            // 
            this.label_NameReasonDebit.AutoSize = true;
            this.label_NameReasonDebit.Location = new System.Drawing.Point(13, 27);
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
            this.ClientSize = new System.Drawing.Size(501, 159);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddReasonDebitAndClose);
            this.Controls.Add(this.button_AddReasonDebit);
            this.Controls.Add(this.textBox_CipherReasonDebit);
            this.Controls.Add(this.textBox_NameReasonDebit);
            this.Controls.Add(this.label_CipherReasonDebit);
            this.Controls.Add(this.label_NameReasonDebit);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddReasonDebitForm";
            this.Text = "Справочник - Добавить причину списания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_AddReasonDebitAndClose;
        private System.Windows.Forms.Button button_AddReasonDebit;
        private System.Windows.Forms.TextBox textBox_CipherReasonDebit;
        private System.Windows.Forms.TextBox textBox_NameReasonDebit;
        private System.Windows.Forms.Label label_CipherReasonDebit;
        private System.Windows.Forms.Label label_NameReasonDebit;
    }
}