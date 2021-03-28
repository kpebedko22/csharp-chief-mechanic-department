
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLeasingForm));
            this.label_LeasingNum = new System.Windows.Forms.Label();
            this.textBox_LeasingNum = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_MainInfo = new System.Windows.Forms.TabPage();
            this.tabPage_Equipment = new System.Windows.Forms.TabPage();
            this.label_Seller = new System.Windows.Forms.Label();
            this.comboBox_Seller = new System.Windows.Forms.ComboBox();
            this.comboBox_Leaser = new System.Windows.Forms.ComboBox();
            this.label_Leaser = new System.Windows.Forms.Label();
            this.label_LeaserFIO = new System.Windows.Forms.Label();
            this.label_SellerFIO = new System.Windows.Forms.Label();
            this.textBox_SellerFIO = new System.Windows.Forms.TextBox();
            this.textBox_LeaserFIO = new System.Windows.Forms.TextBox();
            this.groupBox_Seller = new System.Windows.Forms.GroupBox();
            this.groupBox_Leaser = new System.Windows.Forms.GroupBox();
            this.label_CustomerFIO = new System.Windows.Forms.Label();
            this.textBox_CustomerFIO = new System.Windows.Forms.TextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Deadlines = new System.Windows.Forms.GroupBox();
            this.label_DaysForFirstPayment = new System.Windows.Forms.Label();
            this.label_DaysForReport = new System.Windows.Forms.Label();
            this.numericUpDown_DaysForFirstPayment = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_DaysForReport = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown_DaysForForceMajeure = new System.Windows.Forms.NumericUpDown();
            this.label_DaysForForceMajeure = new System.Windows.Forms.Label();
            this.groupBox_Responsibility = new System.Windows.Forms.GroupBox();
            this.textBox_PenaltyFee = new System.Windows.Forms.TextBox();
            this.pictureBox_PenaltyFee = new System.Windows.Forms.PictureBox();
            this.label_PenaltyFee = new System.Windows.Forms.Label();
            this.pictureBox_MaxPenalty = new System.Windows.Forms.PictureBox();
            this.pictureBox_Penalty = new System.Windows.Forms.PictureBox();
            this.numericUpDown_MaxPenalty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Penalty = new System.Windows.Forms.NumericUpDown();
            this.label_MaxPenalty = new System.Windows.Forms.Label();
            this.label_Penalty = new System.Windows.Forms.Label();
            this.dateTimePicker_DateDelivery = new System.Windows.Forms.DateTimePicker();
            this.label_DateDelivery = new System.Windows.Forms.Label();
            this.numericUpDown_PeriodOfUse = new System.Windows.Forms.NumericUpDown();
            this.label_PeriodOfUse = new System.Windows.Forms.Label();
            this.button_AddRowEquipment = new System.Windows.Forms.Button();
            this.button_RemoveEquipment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_NameEquipment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Mesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GroupEquipment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button_AddAndClose = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage_MainInfo.SuspendLayout();
            this.tabPage_Equipment.SuspendLayout();
            this.groupBox_Seller.SuspendLayout();
            this.groupBox_Leaser.SuspendLayout();
            this.groupBox_Deadlines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DaysForFirstPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DaysForReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DaysForForceMajeure)).BeginInit();
            this.groupBox_Responsibility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PenaltyFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MaxPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Penalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Penalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PeriodOfUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_LeasingNum
            // 
            this.label_LeasingNum.AutoSize = true;
            this.label_LeasingNum.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_LeasingNum.Location = new System.Drawing.Point(243, 24);
            this.label_LeasingNum.Name = "label_LeasingNum";
            this.label_LeasingNum.Size = new System.Drawing.Size(126, 26);
            this.label_LeasingNum.TabIndex = 0;
            this.label_LeasingNum.Text = "Договор №:";
            // 
            // textBox_LeasingNum
            // 
            this.textBox_LeasingNum.Location = new System.Drawing.Point(375, 25);
            this.textBox_LeasingNum.Name = "textBox_LeasingNum";
            this.textBox_LeasingNum.Size = new System.Drawing.Size(212, 29);
            this.textBox_LeasingNum.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_MainInfo);
            this.tabControl.Controls.Add(this.tabPage_Equipment);
            this.tabControl.Location = new System.Drawing.Point(12, 124);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 439);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage_MainInfo
            // 
            this.tabPage_MainInfo.Controls.Add(this.groupBox_Responsibility);
            this.tabPage_MainInfo.Controls.Add(this.groupBox_Deadlines);
            this.tabPage_MainInfo.Controls.Add(this.dateTimePicker1);
            this.tabPage_MainInfo.Controls.Add(this.label_Date);
            this.tabPage_MainInfo.Controls.Add(this.textBox_CustomerFIO);
            this.tabPage_MainInfo.Controls.Add(this.label_CustomerFIO);
            this.tabPage_MainInfo.Controls.Add(this.groupBox_Leaser);
            this.tabPage_MainInfo.Controls.Add(this.groupBox_Seller);
            this.tabPage_MainInfo.Location = new System.Drawing.Point(4, 30);
            this.tabPage_MainInfo.Name = "tabPage_MainInfo";
            this.tabPage_MainInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MainInfo.Size = new System.Drawing.Size(794, 405);
            this.tabPage_MainInfo.TabIndex = 0;
            this.tabPage_MainInfo.Text = "Основная информация";
            this.tabPage_MainInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage_Equipment
            // 
            this.tabPage_Equipment.Controls.Add(this.dataGridView1);
            this.tabPage_Equipment.Controls.Add(this.button_RemoveEquipment);
            this.tabPage_Equipment.Controls.Add(this.button_AddRowEquipment);
            this.tabPage_Equipment.Controls.Add(this.numericUpDown_PeriodOfUse);
            this.tabPage_Equipment.Controls.Add(this.label_PeriodOfUse);
            this.tabPage_Equipment.Controls.Add(this.dateTimePicker_DateDelivery);
            this.tabPage_Equipment.Controls.Add(this.label_DateDelivery);
            this.tabPage_Equipment.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Equipment.Name = "tabPage_Equipment";
            this.tabPage_Equipment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Equipment.Size = new System.Drawing.Size(794, 405);
            this.tabPage_Equipment.TabIndex = 1;
            this.tabPage_Equipment.Text = "Оборудование";
            this.tabPage_Equipment.UseVisualStyleBackColor = true;
            // 
            // label_Seller
            // 
            this.label_Seller.AutoSize = true;
            this.label_Seller.Location = new System.Drawing.Point(15, 41);
            this.label_Seller.Name = "label_Seller";
            this.label_Seller.Size = new System.Drawing.Size(112, 21);
            this.label_Seller.TabIndex = 0;
            this.label_Seller.Text = "Организация: ";
            // 
            // comboBox_Seller
            // 
            this.comboBox_Seller.FormattingEnabled = true;
            this.comboBox_Seller.Location = new System.Drawing.Point(139, 38);
            this.comboBox_Seller.Name = "comboBox_Seller";
            this.comboBox_Seller.Size = new System.Drawing.Size(214, 29);
            this.comboBox_Seller.TabIndex = 1;
            // 
            // comboBox_Leaser
            // 
            this.comboBox_Leaser.FormattingEnabled = true;
            this.comboBox_Leaser.Location = new System.Drawing.Point(136, 38);
            this.comboBox_Leaser.Name = "comboBox_Leaser";
            this.comboBox_Leaser.Size = new System.Drawing.Size(214, 29);
            this.comboBox_Leaser.TabIndex = 3;
            // 
            // label_Leaser
            // 
            this.label_Leaser.AutoSize = true;
            this.label_Leaser.Location = new System.Drawing.Point(18, 41);
            this.label_Leaser.Name = "label_Leaser";
            this.label_Leaser.Size = new System.Drawing.Size(112, 21);
            this.label_Leaser.TabIndex = 2;
            this.label_Leaser.Text = "Организация: ";
            // 
            // label_LeaserFIO
            // 
            this.label_LeaserFIO.AutoSize = true;
            this.label_LeaserFIO.Location = new System.Drawing.Point(18, 81);
            this.label_LeaserFIO.Name = "label_LeaserFIO";
            this.label_LeaserFIO.Size = new System.Drawing.Size(53, 21);
            this.label_LeaserFIO.TabIndex = 5;
            this.label_LeaserFIO.Text = "ФИО: ";
            // 
            // label_SellerFIO
            // 
            this.label_SellerFIO.AutoSize = true;
            this.label_SellerFIO.Location = new System.Drawing.Point(16, 81);
            this.label_SellerFIO.Name = "label_SellerFIO";
            this.label_SellerFIO.Size = new System.Drawing.Size(53, 21);
            this.label_SellerFIO.TabIndex = 4;
            this.label_SellerFIO.Text = "ФИО: ";
            // 
            // textBox_SellerFIO
            // 
            this.textBox_SellerFIO.Location = new System.Drawing.Point(139, 81);
            this.textBox_SellerFIO.Name = "textBox_SellerFIO";
            this.textBox_SellerFIO.Size = new System.Drawing.Size(214, 29);
            this.textBox_SellerFIO.TabIndex = 6;
            // 
            // textBox_LeaserFIO
            // 
            this.textBox_LeaserFIO.Location = new System.Drawing.Point(136, 81);
            this.textBox_LeaserFIO.Name = "textBox_LeaserFIO";
            this.textBox_LeaserFIO.Size = new System.Drawing.Size(214, 29);
            this.textBox_LeaserFIO.TabIndex = 7;
            // 
            // groupBox_Seller
            // 
            this.groupBox_Seller.Controls.Add(this.label_Seller);
            this.groupBox_Seller.Controls.Add(this.comboBox_Seller);
            this.groupBox_Seller.Controls.Add(this.textBox_SellerFIO);
            this.groupBox_Seller.Controls.Add(this.label_SellerFIO);
            this.groupBox_Seller.Location = new System.Drawing.Point(18, 75);
            this.groupBox_Seller.Name = "groupBox_Seller";
            this.groupBox_Seller.Size = new System.Drawing.Size(372, 125);
            this.groupBox_Seller.TabIndex = 8;
            this.groupBox_Seller.TabStop = false;
            this.groupBox_Seller.Text = "Продавец";
            // 
            // groupBox_Leaser
            // 
            this.groupBox_Leaser.Controls.Add(this.label_Leaser);
            this.groupBox_Leaser.Controls.Add(this.comboBox_Leaser);
            this.groupBox_Leaser.Controls.Add(this.textBox_LeaserFIO);
            this.groupBox_Leaser.Controls.Add(this.label_LeaserFIO);
            this.groupBox_Leaser.Location = new System.Drawing.Point(404, 75);
            this.groupBox_Leaser.Name = "groupBox_Leaser";
            this.groupBox_Leaser.Size = new System.Drawing.Size(372, 125);
            this.groupBox_Leaser.TabIndex = 9;
            this.groupBox_Leaser.TabStop = false;
            this.groupBox_Leaser.Text = "Лизингодатель";
            // 
            // label_CustomerFIO
            // 
            this.label_CustomerFIO.AutoSize = true;
            this.label_CustomerFIO.Location = new System.Drawing.Point(14, 26);
            this.label_CustomerFIO.Name = "label_CustomerFIO";
            this.label_CustomerFIO.Size = new System.Drawing.Size(125, 21);
            this.label_CustomerFIO.TabIndex = 10;
            this.label_CustomerFIO.Text = "ФИО заказчика:";
            // 
            // textBox_CustomerFIO
            // 
            this.textBox_CustomerFIO.Location = new System.Drawing.Point(157, 20);
            this.textBox_CustomerFIO.Name = "textBox_CustomerFIO";
            this.textBox_CustomerFIO.Size = new System.Drawing.Size(214, 29);
            this.textBox_CustomerFIO.TabIndex = 11;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(411, 23);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(138, 21);
            this.label_Date.TabIndex = 12;
            this.label_Date.Text = "Дата заключения:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(554, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // groupBox_Deadlines
            // 
            this.groupBox_Deadlines.Controls.Add(this.numericUpDown_DaysForForceMajeure);
            this.groupBox_Deadlines.Controls.Add(this.label_DaysForForceMajeure);
            this.groupBox_Deadlines.Controls.Add(this.numericUpDown_DaysForReport);
            this.groupBox_Deadlines.Controls.Add(this.numericUpDown_DaysForFirstPayment);
            this.groupBox_Deadlines.Controls.Add(this.label_DaysForReport);
            this.groupBox_Deadlines.Controls.Add(this.label_DaysForFirstPayment);
            this.groupBox_Deadlines.Location = new System.Drawing.Point(18, 221);
            this.groupBox_Deadlines.Name = "groupBox_Deadlines";
            this.groupBox_Deadlines.Size = new System.Drawing.Size(372, 174);
            this.groupBox_Deadlines.TabIndex = 14;
            this.groupBox_Deadlines.TabStop = false;
            this.groupBox_Deadlines.Text = "Сроки";
            // 
            // label_DaysForFirstPayment
            // 
            this.label_DaysForFirstPayment.AutoSize = true;
            this.label_DaysForFirstPayment.Location = new System.Drawing.Point(16, 31);
            this.label_DaysForFirstPayment.Name = "label_DaysForFirstPayment";
            this.label_DaysForFirstPayment.Size = new System.Drawing.Size(178, 21);
            this.label_DaysForFirstPayment.TabIndex = 7;
            this.label_DaysForFirstPayment.Text = "Дней для 1-го платежа: ";
            // 
            // label_DaysForReport
            // 
            this.label_DaysForReport.AutoSize = true;
            this.label_DaysForReport.Location = new System.Drawing.Point(16, 85);
            this.label_DaysForReport.Name = "label_DaysForReport";
            this.label_DaysForReport.Size = new System.Drawing.Size(234, 21);
            this.label_DaysForReport.TabIndex = 8;
            this.label_DaysForReport.Text = "Дней для принятия претензий: ";
            // 
            // numericUpDown_DaysForFirstPayment
            // 
            this.numericUpDown_DaysForFirstPayment.Location = new System.Drawing.Point(262, 31);
            this.numericUpDown_DaysForFirstPayment.Name = "numericUpDown_DaysForFirstPayment";
            this.numericUpDown_DaysForFirstPayment.Size = new System.Drawing.Size(91, 29);
            this.numericUpDown_DaysForFirstPayment.TabIndex = 9;
            this.numericUpDown_DaysForFirstPayment.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_DaysForReport
            // 
            this.numericUpDown_DaysForReport.Location = new System.Drawing.Point(262, 83);
            this.numericUpDown_DaysForReport.Name = "numericUpDown_DaysForReport";
            this.numericUpDown_DaysForReport.Size = new System.Drawing.Size(91, 29);
            this.numericUpDown_DaysForReport.TabIndex = 10;
            this.numericUpDown_DaysForReport.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_DaysForForceMajeure
            // 
            this.numericUpDown_DaysForForceMajeure.Location = new System.Drawing.Point(262, 136);
            this.numericUpDown_DaysForForceMajeure.Name = "numericUpDown_DaysForForceMajeure";
            this.numericUpDown_DaysForForceMajeure.Size = new System.Drawing.Size(91, 29);
            this.numericUpDown_DaysForForceMajeure.TabIndex = 21;
            this.numericUpDown_DaysForForceMajeure.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label_DaysForForceMajeure
            // 
            this.label_DaysForForceMajeure.AutoSize = true;
            this.label_DaysForForceMajeure.Location = new System.Drawing.Point(16, 138);
            this.label_DaysForForceMajeure.Name = "label_DaysForForceMajeure";
            this.label_DaysForForceMajeure.Size = new System.Drawing.Size(166, 21);
            this.label_DaysForForceMajeure.TabIndex = 20;
            this.label_DaysForForceMajeure.Text = "Дней на форс-мажор:";
            // 
            // groupBox_Responsibility
            // 
            this.groupBox_Responsibility.Controls.Add(this.textBox_PenaltyFee);
            this.groupBox_Responsibility.Controls.Add(this.pictureBox_PenaltyFee);
            this.groupBox_Responsibility.Controls.Add(this.label_PenaltyFee);
            this.groupBox_Responsibility.Controls.Add(this.pictureBox_MaxPenalty);
            this.groupBox_Responsibility.Controls.Add(this.pictureBox_Penalty);
            this.groupBox_Responsibility.Controls.Add(this.numericUpDown_MaxPenalty);
            this.groupBox_Responsibility.Controls.Add(this.numericUpDown_Penalty);
            this.groupBox_Responsibility.Controls.Add(this.label_MaxPenalty);
            this.groupBox_Responsibility.Controls.Add(this.label_Penalty);
            this.groupBox_Responsibility.Location = new System.Drawing.Point(404, 221);
            this.groupBox_Responsibility.Name = "groupBox_Responsibility";
            this.groupBox_Responsibility.Size = new System.Drawing.Size(372, 174);
            this.groupBox_Responsibility.TabIndex = 15;
            this.groupBox_Responsibility.TabStop = false;
            this.groupBox_Responsibility.Text = "Ответственность";
            // 
            // textBox_PenaltyFee
            // 
            this.textBox_PenaltyFee.Location = new System.Drawing.Point(208, 131);
            this.textBox_PenaltyFee.Name = "textBox_PenaltyFee";
            this.textBox_PenaltyFee.Size = new System.Drawing.Size(142, 29);
            this.textBox_PenaltyFee.TabIndex = 28;
            // 
            // pictureBox_PenaltyFee
            // 
            this.pictureBox_PenaltyFee.Image = global::OGM.Properties.Resources.info;
            this.pictureBox_PenaltyFee.Location = new System.Drawing.Point(23, 137);
            this.pictureBox_PenaltyFee.Name = "pictureBox_PenaltyFee";
            this.pictureBox_PenaltyFee.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_PenaltyFee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PenaltyFee.TabIndex = 27;
            this.pictureBox_PenaltyFee.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox_PenaltyFee, resources.GetString("pictureBox_PenaltyFee.ToolTip"));
            // 
            // label_PenaltyFee
            // 
            this.label_PenaltyFee.AutoSize = true;
            this.label_PenaltyFee.Location = new System.Drawing.Point(45, 134);
            this.label_PenaltyFee.Name = "label_PenaltyFee";
            this.label_PenaltyFee.Size = new System.Drawing.Size(136, 21);
            this.label_PenaltyFee.TabIndex = 26;
            this.label_PenaltyFee.Text = "Неустойка, в руб.:";
            // 
            // pictureBox_MaxPenalty
            // 
            this.pictureBox_MaxPenalty.Image = global::OGM.Properties.Resources.info;
            this.pictureBox_MaxPenalty.Location = new System.Drawing.Point(23, 84);
            this.pictureBox_MaxPenalty.Name = "pictureBox_MaxPenalty";
            this.pictureBox_MaxPenalty.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_MaxPenalty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MaxPenalty.TabIndex = 25;
            this.pictureBox_MaxPenalty.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox_MaxPenalty, "Заказчик уплачивает пеню от суммы невнесенного платежа, но не более указанного пр" +
        "оцента.");
            // 
            // pictureBox_Penalty
            // 
            this.pictureBox_Penalty.Image = global::OGM.Properties.Resources.info;
            this.pictureBox_Penalty.Location = new System.Drawing.Point(23, 32);
            this.pictureBox_Penalty.Name = "pictureBox_Penalty";
            this.pictureBox_Penalty.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Penalty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Penalty.TabIndex = 24;
            this.pictureBox_Penalty.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox_Penalty, "В случае невнесения платы за пользование оборудованием в установленные сроки,\r\nЗа" +
        "казчик уплачивает пеню в указанном % от суммы невнесенного платежа.");
            // 
            // numericUpDown_MaxPenalty
            // 
            this.numericUpDown_MaxPenalty.Location = new System.Drawing.Point(253, 79);
            this.numericUpDown_MaxPenalty.Name = "numericUpDown_MaxPenalty";
            this.numericUpDown_MaxPenalty.Size = new System.Drawing.Size(91, 29);
            this.numericUpDown_MaxPenalty.TabIndex = 23;
            this.numericUpDown_MaxPenalty.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_Penalty
            // 
            this.numericUpDown_Penalty.DecimalPlaces = 2;
            this.numericUpDown_Penalty.Location = new System.Drawing.Point(253, 27);
            this.numericUpDown_Penalty.Name = "numericUpDown_Penalty";
            this.numericUpDown_Penalty.Size = new System.Drawing.Size(91, 29);
            this.numericUpDown_Penalty.TabIndex = 22;
            this.numericUpDown_Penalty.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label_MaxPenalty
            // 
            this.label_MaxPenalty.AutoSize = true;
            this.label_MaxPenalty.Location = new System.Drawing.Point(45, 81);
            this.label_MaxPenalty.Name = "label_MaxPenalty";
            this.label_MaxPenalty.Size = new System.Drawing.Size(189, 21);
            this.label_MaxPenalty.TabIndex = 21;
            this.label_MaxPenalty.Text = "Максимальная пеня, в %:";
            // 
            // label_Penalty
            // 
            this.label_Penalty.AutoSize = true;
            this.label_Penalty.Location = new System.Drawing.Point(45, 29);
            this.label_Penalty.Name = "label_Penalty";
            this.label_Penalty.Size = new System.Drawing.Size(85, 21);
            this.label_Penalty.TabIndex = 20;
            this.label_Penalty.Text = "Пеня, в %: ";
            // 
            // dateTimePicker_DateDelivery
            // 
            this.dateTimePicker_DateDelivery.Location = new System.Drawing.Point(554, 20);
            this.dateTimePicker_DateDelivery.Name = "dateTimePicker_DateDelivery";
            this.dateTimePicker_DateDelivery.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_DateDelivery.TabIndex = 15;
            // 
            // label_DateDelivery
            // 
            this.label_DateDelivery.AutoSize = true;
            this.label_DateDelivery.Location = new System.Drawing.Point(411, 23);
            this.label_DateDelivery.Name = "label_DateDelivery";
            this.label_DateDelivery.Size = new System.Drawing.Size(116, 21);
            this.label_DateDelivery.TabIndex = 14;
            this.label_DateDelivery.Text = "Дата поставки:";
            // 
            // numericUpDown_PeriodOfUse
            // 
            this.numericUpDown_PeriodOfUse.Location = new System.Drawing.Point(262, 21);
            this.numericUpDown_PeriodOfUse.Name = "numericUpDown_PeriodOfUse";
            this.numericUpDown_PeriodOfUse.Size = new System.Drawing.Size(63, 29);
            this.numericUpDown_PeriodOfUse.TabIndex = 17;
            this.numericUpDown_PeriodOfUse.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_PeriodOfUse
            // 
            this.label_PeriodOfUse.AutoSize = true;
            this.label_PeriodOfUse.Location = new System.Drawing.Point(30, 23);
            this.label_PeriodOfUse.Name = "label_PeriodOfUse";
            this.label_PeriodOfUse.Size = new System.Drawing.Size(223, 21);
            this.label_PeriodOfUse.TabIndex = 16;
            this.label_PeriodOfUse.Text = "Срок использования, в годах: ";
            // 
            // button_AddRowEquipment
            // 
            this.button_AddRowEquipment.Location = new System.Drawing.Point(34, 74);
            this.button_AddRowEquipment.Name = "button_AddRowEquipment";
            this.button_AddRowEquipment.Size = new System.Drawing.Size(101, 32);
            this.button_AddRowEquipment.TabIndex = 18;
            this.button_AddRowEquipment.Text = "Добавить";
            this.button_AddRowEquipment.UseVisualStyleBackColor = true;
            // 
            // button_RemoveEquipment
            // 
            this.button_RemoveEquipment.Location = new System.Drawing.Point(152, 74);
            this.button_RemoveEquipment.Name = "button_RemoveEquipment";
            this.button_RemoveEquipment.Size = new System.Drawing.Size(101, 32);
            this.button_RemoveEquipment.TabIndex = 19;
            this.button_RemoveEquipment.Text = "Удалить";
            this.button_RemoveEquipment.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NameEquipment,
            this.Column_Amount,
            this.Column_Mesure,
            this.Column_GroupEquipment});
            this.dataGridView1.Location = new System.Drawing.Point(34, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 263);
            this.dataGridView1.TabIndex = 20;
            // 
            // Column_NameEquipment
            // 
            this.Column_NameEquipment.HeaderText = "Наименование";
            this.Column_NameEquipment.MaxDropDownItems = 50;
            this.Column_NameEquipment.Name = "Column_NameEquipment";
            this.Column_NameEquipment.Width = 270;
            // 
            // Column_Amount
            // 
            this.Column_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Amount.HeaderText = "Количество";
            this.Column_Amount.Name = "Column_Amount";
            this.Column_Amount.ReadOnly = true;
            this.Column_Amount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Amount.Width = 99;
            // 
            // Column_Mesure
            // 
            this.Column_Mesure.HeaderText = "Ед. измерения";
            this.Column_Mesure.Name = "Column_Mesure";
            this.Column_Mesure.ReadOnly = true;
            // 
            // Column_GroupEquipment
            // 
            this.Column_GroupEquipment.HeaderText = "Группа оборудования";
            this.Column_GroupEquipment.MaxDropDownItems = 50;
            this.Column_GroupEquipment.Name = "Column_GroupEquipment";
            this.Column_GroupEquipment.ReadOnly = true;
            this.Column_GroupEquipment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_GroupEquipment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_GroupEquipment.Width = 208;
            // 
            // button_AddAndClose
            // 
            this.button_AddAndClose.Location = new System.Drawing.Point(200, 64);
            this.button_AddAndClose.Name = "button_AddAndClose";
            this.button_AddAndClose.Size = new System.Drawing.Size(178, 39);
            this.button_AddAndClose.TabIndex = 21;
            this.button_AddAndClose.Text = "Добавить и закрыть";
            this.button_AddAndClose.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Image = ((System.Drawing.Image)(resources.GetObject("button_Add.Image")));
            this.button_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add.Location = new System.Drawing.Point(16, 64);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(178, 39);
            this.button_Add.TabIndex = 22;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(384, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddLeasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_AddAndClose);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.textBox_LeasingNum);
            this.Controls.Add(this.label_LeasingNum);
            this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddLeasingForm";
            this.Text = "Добавить новый договор лизинга";
            this.tabControl.ResumeLayout(false);
            this.tabPage_MainInfo.ResumeLayout(false);
            this.tabPage_MainInfo.PerformLayout();
            this.tabPage_Equipment.ResumeLayout(false);
            this.tabPage_Equipment.PerformLayout();
            this.groupBox_Seller.ResumeLayout(false);
            this.groupBox_Seller.PerformLayout();
            this.groupBox_Leaser.ResumeLayout(false);
            this.groupBox_Leaser.PerformLayout();
            this.groupBox_Deadlines.ResumeLayout(false);
            this.groupBox_Deadlines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DaysForFirstPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DaysForReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DaysForForceMajeure)).EndInit();
            this.groupBox_Responsibility.ResumeLayout(false);
            this.groupBox_Responsibility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PenaltyFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MaxPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Penalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Penalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PeriodOfUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LeasingNum;
        private System.Windows.Forms.TextBox textBox_LeasingNum;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_MainInfo;
        private System.Windows.Forms.GroupBox groupBox_Leaser;
        private System.Windows.Forms.GroupBox groupBox_Seller;
        private System.Windows.Forms.Label label_Seller;
        private System.Windows.Forms.ComboBox comboBox_Seller;
        private System.Windows.Forms.TextBox textBox_SellerFIO;
        private System.Windows.Forms.Label label_SellerFIO;
        private System.Windows.Forms.TextBox textBox_LeaserFIO;
        private System.Windows.Forms.Label label_LeaserFIO;
        private System.Windows.Forms.ComboBox comboBox_Leaser;
        private System.Windows.Forms.Label label_Leaser;
        private System.Windows.Forms.TabPage tabPage_Equipment;
        private System.Windows.Forms.TextBox textBox_CustomerFIO;
        private System.Windows.Forms.Label label_CustomerFIO;
        private System.Windows.Forms.GroupBox groupBox_Deadlines;
        private System.Windows.Forms.NumericUpDown numericUpDown_DaysForReport;
        private System.Windows.Forms.NumericUpDown numericUpDown_DaysForFirstPayment;
        private System.Windows.Forms.Label label_DaysForReport;
        private System.Windows.Forms.Label label_DaysForFirstPayment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox_Responsibility;
        private System.Windows.Forms.TextBox textBox_PenaltyFee;
        private System.Windows.Forms.PictureBox pictureBox_PenaltyFee;
        private System.Windows.Forms.Label label_PenaltyFee;
        private System.Windows.Forms.PictureBox pictureBox_MaxPenalty;
        private System.Windows.Forms.PictureBox pictureBox_Penalty;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxPenalty;
        private System.Windows.Forms.NumericUpDown numericUpDown_Penalty;
        private System.Windows.Forms.Label label_MaxPenalty;
        private System.Windows.Forms.Label label_Penalty;
        private System.Windows.Forms.NumericUpDown numericUpDown_DaysForForceMajeure;
        private System.Windows.Forms.Label label_DaysForForceMajeure;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_NameEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Mesure;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_GroupEquipment;
        private System.Windows.Forms.Button button_RemoveEquipment;
        private System.Windows.Forms.Button button_AddRowEquipment;
        private System.Windows.Forms.NumericUpDown numericUpDown_PeriodOfUse;
        private System.Windows.Forms.Label label_PeriodOfUse;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateDelivery;
        private System.Windows.Forms.Label label_DateDelivery;
        private System.Windows.Forms.Button button_AddAndClose;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button1;
    }
}
