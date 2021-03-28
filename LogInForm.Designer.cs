
namespace OGM {
	partial class LogInForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.label_Login = new System.Windows.Forms.Label();
			this.label_Password = new System.Windows.Forms.Label();
			this.panel_Login = new System.Windows.Forms.Panel();
			this.button_LogIn = new System.Windows.Forms.Button();
			this.textBox_Login = new System.Windows.Forms.TextBox();
			this.textBox_Password = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel_ChooseModel = new System.Windows.Forms.Panel();
			this.button_Leasing = new System.Windows.Forms.Button();
			this.button_Equipment = new System.Windows.Forms.Button();
			this.button_LogOut = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button_Exit = new System.Windows.Forms.Button();
			this.panel_Login.SuspendLayout();
			this.panel_ChooseModel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Login
			// 
			this.label_Login.AutoSize = true;
			this.label_Login.Location = new System.Drawing.Point(187, 115);
			this.label_Login.Name = "label_Login";
			this.label_Login.Size = new System.Drawing.Size(54, 21);
			this.label_Login.TabIndex = 0;
			this.label_Login.Text = "Логин";
			// 
			// label_Password
			// 
			this.label_Password.AutoSize = true;
			this.label_Password.Location = new System.Drawing.Point(178, 150);
			this.label_Password.Name = "label_Password";
			this.label_Password.Size = new System.Drawing.Size(63, 21);
			this.label_Password.TabIndex = 0;
			this.label_Password.Text = "Пароль";
			// 
			// panel_Login
			// 
			this.panel_Login.Controls.Add(this.label1);
			this.panel_Login.Controls.Add(this.textBox_Password);
			this.panel_Login.Controls.Add(this.textBox_Login);
			this.panel_Login.Controls.Add(this.button_Exit);
			this.panel_Login.Controls.Add(this.button_LogIn);
			this.panel_Login.Controls.Add(this.label_Password);
			this.panel_Login.Controls.Add(this.label_Login);
			this.panel_Login.Location = new System.Drawing.Point(12, 12);
			this.panel_Login.Name = "panel_Login";
			this.panel_Login.Size = new System.Drawing.Size(660, 337);
			this.panel_Login.TabIndex = 1;
			// 
			// button_LogIn
			// 
			this.button_LogIn.Location = new System.Drawing.Point(272, 197);
			this.button_LogIn.Name = "button_LogIn";
			this.button_LogIn.Size = new System.Drawing.Size(150, 29);
			this.button_LogIn.TabIndex = 3;
			this.button_LogIn.Text = "Войти в систему";
			this.button_LogIn.UseVisualStyleBackColor = true;
			this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
			// 
			// textBox_Login
			// 
			this.textBox_Login.Location = new System.Drawing.Point(247, 112);
			this.textBox_Login.Name = "textBox_Login";
			this.textBox_Login.Size = new System.Drawing.Size(200, 29);
			this.textBox_Login.TabIndex = 1;
			// 
			// textBox_Password
			// 
			this.textBox_Password.Location = new System.Drawing.Point(247, 147);
			this.textBox_Password.Name = "textBox_Password";
			this.textBox_Password.Size = new System.Drawing.Size(200, 29);
			this.textBox_Password.TabIndex = 2;
			this.textBox_Password.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(270, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Вход в систему";
			// 
			// panel_ChooseModel
			// 
			this.panel_ChooseModel.Controls.Add(this.label2);
			this.panel_ChooseModel.Controls.Add(this.button_LogOut);
			this.panel_ChooseModel.Controls.Add(this.button_Equipment);
			this.panel_ChooseModel.Controls.Add(this.button_Leasing);
			this.panel_ChooseModel.Location = new System.Drawing.Point(12, 12);
			this.panel_ChooseModel.Name = "panel_ChooseModel";
			this.panel_ChooseModel.Size = new System.Drawing.Size(660, 337);
			this.panel_ChooseModel.TabIndex = 4;
			// 
			// button_Leasing
			// 
			this.button_Leasing.Location = new System.Drawing.Point(233, 99);
			this.button_Leasing.Name = "button_Leasing";
			this.button_Leasing.Size = new System.Drawing.Size(203, 29);
			this.button_Leasing.TabIndex = 1;
			this.button_Leasing.Text = "Договоры лизинга";
			this.button_Leasing.UseVisualStyleBackColor = true;
			this.button_Leasing.Click += new System.EventHandler(this.button_Leasing_Click);
			// 
			// button_Equipment
			// 
			this.button_Equipment.Location = new System.Drawing.Point(233, 154);
			this.button_Equipment.Name = "button_Equipment";
			this.button_Equipment.Size = new System.Drawing.Size(203, 29);
			this.button_Equipment.TabIndex = 1;
			this.button_Equipment.Text = "Списание оборудования";
			this.button_Equipment.UseVisualStyleBackColor = true;
			this.button_Equipment.Click += new System.EventHandler(this.button_Equipment_Click);
			// 
			// button_LogOut
			// 
			this.button_LogOut.Location = new System.Drawing.Point(233, 256);
			this.button_LogOut.Name = "button_LogOut";
			this.button_LogOut.Size = new System.Drawing.Size(203, 29);
			this.button_LogOut.TabIndex = 1;
			this.button_LogOut.Text = "Выйти из системы";
			this.button_LogOut.UseVisualStyleBackColor = true;
			this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(222, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(225, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Выберите модуль для работы:";
			// 
			// button_Exit
			// 
			this.button_Exit.Location = new System.Drawing.Point(272, 291);
			this.button_Exit.Name = "button_Exit";
			this.button_Exit.Size = new System.Drawing.Size(150, 29);
			this.button_Exit.TabIndex = 4;
			this.button_Exit.Text = "Выход";
			this.button_Exit.UseVisualStyleBackColor = true;
			this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
			// 
			// LogInForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 361);
			this.Controls.Add(this.panel_Login);
			this.Controls.Add(this.panel_ChooseModel);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogInForm";
			this.Text = "Авторизация";
			this.panel_Login.ResumeLayout(false);
			this.panel_Login.PerformLayout();
			this.panel_ChooseModel.ResumeLayout(false);
			this.panel_ChooseModel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_Login;
		private System.Windows.Forms.Label label_Password;
		private System.Windows.Forms.Panel panel_Login;
		private System.Windows.Forms.TextBox textBox_Password;
		private System.Windows.Forms.TextBox textBox_Login;
		private System.Windows.Forms.Button button_LogIn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel_ChooseModel;
		private System.Windows.Forms.Button button_Equipment;
		private System.Windows.Forms.Button button_Leasing;
		private System.Windows.Forms.Button button_LogOut;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button_Exit;
	}
}

