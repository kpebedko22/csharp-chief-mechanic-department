﻿
namespace OGM
{
    partial class AddEquipment
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
            this.comboBox_Workshop = new System.Windows.Forms.ComboBox();
            this.label_Workshop = new System.Windows.Forms.Label();
            this.button_AddEquipment = new System.Windows.Forms.Button();
            this.comboBox_GroupEquipment = new System.Windows.Forms.ComboBox();
            this.textBox_InventoryNum = new System.Windows.Forms.TextBox();
            this.textBox_SerialNum = new System.Windows.Forms.TextBox();
            this.textBox_NameEquipment = new System.Windows.Forms.TextBox();
            this.label_GroupEquipment = new System.Windows.Forms.Label();
            this.label_InventoryNum = new System.Windows.Forms.Label();
            this.label_SerialNum = new System.Windows.Forms.Label();
            this.label_NameEquipment = new System.Windows.Forms.Label();
            this.button_AddEquipmentAndClose = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Workshop
            // 
            this.comboBox_Workshop.FormattingEnabled = true;
            this.comboBox_Workshop.Location = new System.Drawing.Point(202, 18);
            this.comboBox_Workshop.Name = "comboBox_Workshop";
            this.comboBox_Workshop.Size = new System.Drawing.Size(370, 29);
            this.comboBox_Workshop.TabIndex = 1;
            this.comboBox_Workshop.SelectedIndexChanged += new System.EventHandler(this.comboBox_Workshop_SelectedIndexChanged);
            // 
            // label_Workshop
            // 
            this.label_Workshop.AutoSize = true;
            this.label_Workshop.Location = new System.Drawing.Point(152, 21);
            this.label_Workshop.Name = "label_Workshop";
            this.label_Workshop.Size = new System.Drawing.Size(40, 21);
            this.label_Workshop.TabIndex = 20;
            this.label_Workshop.Text = "Цех:";
            // 
            // button_AddEquipment
            // 
            this.button_AddEquipment.Location = new System.Drawing.Point(12, 270);
            this.button_AddEquipment.Name = "button_AddEquipment";
            this.button_AddEquipment.Size = new System.Drawing.Size(180, 29);
            this.button_AddEquipment.TabIndex = 6;
            this.button_AddEquipment.Text = "Добавить";
            this.button_AddEquipment.UseVisualStyleBackColor = true;
            this.button_AddEquipment.Click += new System.EventHandler(this.button_AddEquipment_Click);
            // 
            // comboBox_GroupEquipment
            // 
            this.comboBox_GroupEquipment.FormattingEnabled = true;
            this.comboBox_GroupEquipment.Location = new System.Drawing.Point(202, 62);
            this.comboBox_GroupEquipment.Name = "comboBox_GroupEquipment";
            this.comboBox_GroupEquipment.Size = new System.Drawing.Size(370, 29);
            this.comboBox_GroupEquipment.TabIndex = 2;
            // 
            // textBox_InventoryNum
            // 
            this.textBox_InventoryNum.Location = new System.Drawing.Point(202, 197);
            this.textBox_InventoryNum.MaxLength = 99;
            this.textBox_InventoryNum.Name = "textBox_InventoryNum";
            this.textBox_InventoryNum.Size = new System.Drawing.Size(370, 29);
            this.textBox_InventoryNum.TabIndex = 5;
            // 
            // textBox_SerialNum
            // 
            this.textBox_SerialNum.Location = new System.Drawing.Point(202, 153);
            this.textBox_SerialNum.MaxLength = 99;
            this.textBox_SerialNum.Name = "textBox_SerialNum";
            this.textBox_SerialNum.Size = new System.Drawing.Size(370, 29);
            this.textBox_SerialNum.TabIndex = 4;
            // 
            // textBox_NameEquipment
            // 
            this.textBox_NameEquipment.Location = new System.Drawing.Point(202, 108);
            this.textBox_NameEquipment.MaxLength = 249;
            this.textBox_NameEquipment.Name = "textBox_NameEquipment";
            this.textBox_NameEquipment.Size = new System.Drawing.Size(370, 29);
            this.textBox_NameEquipment.TabIndex = 3;
            // 
            // label_GroupEquipment
            // 
            this.label_GroupEquipment.AutoSize = true;
            this.label_GroupEquipment.Location = new System.Drawing.Point(133, 66);
            this.label_GroupEquipment.Name = "label_GroupEquipment";
            this.label_GroupEquipment.Size = new System.Drawing.Size(64, 21);
            this.label_GroupEquipment.TabIndex = 14;
            this.label_GroupEquipment.Text = "Группа:";
            // 
            // label_InventoryNum
            // 
            this.label_InventoryNum.AutoSize = true;
            this.label_InventoryNum.Location = new System.Drawing.Point(34, 201);
            this.label_InventoryNum.Name = "label_InventoryNum";
            this.label_InventoryNum.Size = new System.Drawing.Size(162, 21);
            this.label_InventoryNum.TabIndex = 13;
            this.label_InventoryNum.Text = "Инвентарный номер:";
            // 
            // label_SerialNum
            // 
            this.label_SerialNum.AutoSize = true;
            this.label_SerialNum.Location = new System.Drawing.Point(59, 157);
            this.label_SerialNum.Name = "label_SerialNum";
            this.label_SerialNum.Size = new System.Drawing.Size(137, 21);
            this.label_SerialNum.TabIndex = 12;
            this.label_SerialNum.Text = "Серийный номер:";
            // 
            // label_NameEquipment
            // 
            this.label_NameEquipment.AutoSize = true;
            this.label_NameEquipment.Location = new System.Drawing.Point(76, 112);
            this.label_NameEquipment.Name = "label_NameEquipment";
            this.label_NameEquipment.Size = new System.Drawing.Size(120, 21);
            this.label_NameEquipment.TabIndex = 11;
            this.label_NameEquipment.Text = "Наименование:";
            // 
            // button_AddEquipmentAndClose
            // 
            this.button_AddEquipmentAndClose.Location = new System.Drawing.Point(202, 270);
            this.button_AddEquipmentAndClose.Name = "button_AddEquipmentAndClose";
            this.button_AddEquipmentAndClose.Size = new System.Drawing.Size(180, 29);
            this.button_AddEquipmentAndClose.TabIndex = 7;
            this.button_AddEquipmentAndClose.Text = "Добавить и закрыть";
            this.button_AddEquipmentAndClose.UseVisualStyleBackColor = true;
            this.button_AddEquipmentAndClose.Click += new System.EventHandler(this.button_AddEquipmentAndClose_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(392, 270);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(180, 29);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // AddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddEquipmentAndClose);
            this.Controls.Add(this.comboBox_Workshop);
            this.Controls.Add(this.label_Workshop);
            this.Controls.Add(this.button_AddEquipment);
            this.Controls.Add(this.comboBox_GroupEquipment);
            this.Controls.Add(this.textBox_InventoryNum);
            this.Controls.Add(this.textBox_SerialNum);
            this.Controls.Add(this.textBox_NameEquipment);
            this.Controls.Add(this.label_GroupEquipment);
            this.Controls.Add(this.label_InventoryNum);
            this.Controls.Add(this.label_SerialNum);
            this.Controls.Add(this.label_NameEquipment);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEquipment";
            this.Text = "Справочник - Добавить оборудование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Workshop;
        private System.Windows.Forms.Label label_Workshop;
        private System.Windows.Forms.Button button_AddEquipment;
        private System.Windows.Forms.ComboBox comboBox_GroupEquipment;
        private System.Windows.Forms.TextBox textBox_InventoryNum;
        private System.Windows.Forms.TextBox textBox_SerialNum;
        private System.Windows.Forms.TextBox textBox_NameEquipment;
        private System.Windows.Forms.Label label_GroupEquipment;
        private System.Windows.Forms.Label label_InventoryNum;
        private System.Windows.Forms.Label label_SerialNum;
        private System.Windows.Forms.Label label_NameEquipment;
        private System.Windows.Forms.Button button_AddEquipmentAndClose;
        private System.Windows.Forms.Button button_Cancel;
    }
}