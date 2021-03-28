
namespace OGM
{
    partial class AddLeasingForm
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
            this.label_LeasingNum = new System.Windows.Forms.Label();
            this.textBox_LeasingNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_LeasingNum
            // 
            this.label_LeasingNum.AutoSize = true;
            this.label_LeasingNum.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_LeasingNum.Location = new System.Drawing.Point(194, 28);
            this.label_LeasingNum.Name = "label_LeasingNum";
            this.label_LeasingNum.Size = new System.Drawing.Size(175, 26);
            this.label_LeasingNum.TabIndex = 0;
            this.label_LeasingNum.Text = "Номер договора:";
            // 
            // textBox_LeasingNum
            // 
            this.textBox_LeasingNum.Location = new System.Drawing.Point(396, 25);
            this.textBox_LeasingNum.Name = "textBox_LeasingNum";
            this.textBox_LeasingNum.Size = new System.Drawing.Size(212, 29);
            this.textBox_LeasingNum.TabIndex = 1;
            // 
            // AddLeasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 410);
            this.Controls.Add(this.textBox_LeasingNum);
            this.Controls.Add(this.label_LeasingNum);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddLeasingForm";
            this.Text = "Добавить новый договор лизинга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LeasingNum;
        private System.Windows.Forms.TextBox textBox_LeasingNum;
    }
}
