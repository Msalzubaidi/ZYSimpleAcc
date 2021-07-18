namespace ZYSimpleAcc.Forms
{
    partial class frmSendSMSEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendSMSEmail));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnemailview = new DevExpress.XtraEditors.SimpleButton();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSmsiew = new DevExpress.XtraEditors.SimpleButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arlang = new System.Windows.Forms.RadioButton();
            this.englang = new System.Windows.Forms.RadioButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCusNameSMS = new System.Windows.Forms.TextBox();
            this.txtCusIDSMS = new System.Windows.Forms.TextBox();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMessageSMS = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.txtMsgIDSMS = new System.Windows.Forms.TextBox();
            this.txtMsgEmailID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(621, 288);
            this.xtraTabControl1.TabIndex = 59;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtMsgEmailID);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.dateEdit1);
            this.xtraTabPage1.Controls.Add(this.simpleButton5);
            this.xtraTabPage1.Controls.Add(this.btnemailview);
            this.xtraTabPage1.Controls.Add(this.txtCustId);
            this.xtraTabPage1.Controls.Add(this.checkBox2);
            this.xtraTabPage1.Controls.Add(this.groupBox2);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtCustName);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.simpleButton4);
            this.xtraTabPage1.Controls.Add(this.txtMessage);
            this.xtraTabPage1.Controls.Add(this.txtCustEmail);
            this.xtraTabPage1.Controls.Add(this.label8);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(615, 260);
            this.xtraTabPage1.Text = "ارسال بريد الكتروني";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(27, 215);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(91, 23);
            this.simpleButton5.TabIndex = 90;
            this.simpleButton5.Text = "مساعدة ؟ \r\n";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btnemailview
            // 
            this.btnemailview.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemailview.Appearance.Options.UseFont = true;
            this.btnemailview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnemailview.ImageOptions.Image")));
            this.btnemailview.Location = new System.Drawing.Point(371, 22);
            this.btnemailview.Name = "btnemailview";
            this.btnemailview.Size = new System.Drawing.Size(129, 23);
            this.btnemailview.TabIndex = 89;
            this.btnemailview.Text = "اختيار عميل";
            this.btnemailview.Click += new System.EventHandler(this.btnemailview_Click);
            // 
            // txtCustId
            // 
            this.txtCustId.Enabled = false;
            this.txtCustId.Location = new System.Drawing.Point(202, 24);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(163, 20);
            this.txtCustId.TabIndex = 88;
            this.txtCustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(58, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 17);
            this.checkBox2.TabIndex = 87;
            this.checkBox2.Text = "إخفاء البريد الالكتروني";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(30, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 48);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اللغة";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(78, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 43;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "العربية";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "English";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(172, 215);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(129, 23);
            this.simpleButton2.TabIndex = 85;
            this.simpleButton2.Text = "إغـــــــــــــــــــــلاق";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "اختر العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "الرسالة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "الاسم";
            // 
            // txtCustName
            // 
            this.txtCustName.Enabled = false;
            this.txtCustName.Location = new System.Drawing.Point(202, 55);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(298, 20);
            this.txtCustName.TabIndex = 80;
            this.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(307, 215);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(63, 23);
            this.simpleButton3.TabIndex = 77;
            this.simpleButton3.Text = "مسح";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(376, 215);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(63, 23);
            this.simpleButton4.TabIndex = 76;
            this.simpleButton4.Text = "ارسال";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click_1);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(11, 119);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(489, 79);
            this.txtMessage.TabIndex = 75;
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(202, 91);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(298, 20);
            this.txtCustEmail.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "البريد الالكتروني";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtMsgIDSMS);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.dateEdit2);
            this.xtraTabPage2.Controls.Add(this.btnSmsiew);
            this.xtraTabPage2.Controls.Add(this.checkBox1);
            this.xtraTabPage2.Controls.Add(this.groupBox1);
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Controls.Add(this.label11);
            this.xtraTabPage2.Controls.Add(this.label12);
            this.xtraTabPage2.Controls.Add(this.label13);
            this.xtraTabPage2.Controls.Add(this.label14);
            this.xtraTabPage2.Controls.Add(this.txtCusNameSMS);
            this.xtraTabPage2.Controls.Add(this.txtCusIDSMS);
            this.xtraTabPage2.Controls.Add(this.simpleButton6);
            this.xtraTabPage2.Controls.Add(this.simpleButton7);
            this.xtraTabPage2.Controls.Add(this.txtMessageSMS);
            this.xtraTabPage2.Controls.Add(this.txtMobile);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(615, 260);
            this.xtraTabPage2.Text = "ارسال SMS";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // btnSmsiew
            // 
            this.btnSmsiew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmsiew.Appearance.Options.UseFont = true;
            this.btnSmsiew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSmsiew.ImageOptions.Image")));
            this.btnSmsiew.Location = new System.Drawing.Point(357, 26);
            this.btnSmsiew.Name = "btnSmsiew";
            this.btnSmsiew.Size = new System.Drawing.Size(129, 23);
            this.btnSmsiew.TabIndex = 74;
            this.btnSmsiew.Text = "اختيار عميل";
            this.btnSmsiew.Click += new System.EventHandler(this.btnSmsiew_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 73;
            this.checkBox1.Text = "إخفاء رقم الهاتف";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arlang);
            this.groupBox1.Controls.Add(this.englang);
            this.groupBox1.Location = new System.Drawing.Point(16, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 48);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اللغة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // arlang
            // 
            this.arlang.AutoSize = true;
            this.arlang.Location = new System.Drawing.Point(78, 19);
            this.arlang.Name = "arlang";
            this.arlang.Size = new System.Drawing.Size(55, 17);
            this.arlang.TabIndex = 43;
            this.arlang.TabStop = true;
            this.arlang.Text = "العربية";
            this.arlang.UseVisualStyleBackColor = true;
            // 
            // englang
            // 
            this.englang.AutoSize = true;
            this.englang.Location = new System.Drawing.Point(14, 18);
            this.englang.Name = "englang";
            this.englang.Size = new System.Drawing.Size(58, 17);
            this.englang.TabIndex = 42;
            this.englang.TabStop = true;
            this.englang.Text = "English";
            this.englang.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(142, 217);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(129, 23);
            this.simpleButton1.TabIndex = 71;
            this.simpleButton1.Text = "إغـــــــــــــــــــــلاق";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(492, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 70;
            this.label11.Text = "اختر العميل";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(506, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 69;
            this.label12.Text = "الرسالة";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(496, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 68;
            this.label13.Text = "رقم الهاتف";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(515, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 67;
            this.label14.Text = "الاسم";
            // 
            // txtCusNameSMS
            // 
            this.txtCusNameSMS.Enabled = false;
            this.txtCusNameSMS.Location = new System.Drawing.Point(188, 57);
            this.txtCusNameSMS.Name = "txtCusNameSMS";
            this.txtCusNameSMS.Size = new System.Drawing.Size(298, 20);
            this.txtCusNameSMS.TabIndex = 66;
            this.txtCusNameSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCusIDSMS
            // 
            this.txtCusIDSMS.Enabled = false;
            this.txtCusIDSMS.Location = new System.Drawing.Point(188, 28);
            this.txtCusIDSMS.Name = "txtCusIDSMS";
            this.txtCusIDSMS.Size = new System.Drawing.Size(163, 20);
            this.txtCusIDSMS.TabIndex = 65;
            this.txtCusIDSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(277, 217);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(63, 23);
            this.simpleButton6.TabIndex = 63;
            this.simpleButton6.Text = "مسح";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(346, 217);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(63, 23);
            this.simpleButton7.TabIndex = 62;
            this.simpleButton7.Text = "ارسال";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // txtMessageSMS
            // 
            this.txtMessageSMS.Location = new System.Drawing.Point(11, 121);
            this.txtMessageSMS.Multiline = true;
            this.txtMessageSMS.Name = "txtMessageSMS";
            this.txtMessageSMS.Size = new System.Drawing.Size(475, 79);
            this.txtMessageSMS.TabIndex = 61;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(188, 93);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(298, 20);
            this.txtMobile.TabIndex = 60;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(30, 24);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(98, 20);
            this.dateEdit1.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 92;
            this.label3.Text = "التاريخ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "التاريخ";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(16, 26);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(98, 20);
            this.dateEdit2.TabIndex = 93;
            // 
            // txtMsgIDSMS
            // 
            this.txtMsgIDSMS.Location = new System.Drawing.Point(11, 99);
            this.txtMsgIDSMS.Name = "txtMsgIDSMS";
            this.txtMsgIDSMS.Size = new System.Drawing.Size(47, 20);
            this.txtMsgIDSMS.TabIndex = 95;
            this.txtMsgIDSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMsgEmailID
            // 
            this.txtMsgEmailID.Location = new System.Drawing.Point(11, 97);
            this.txtMsgEmailID.Name = "txtMsgEmailID";
            this.txtMsgEmailID.Size = new System.Drawing.Size(47, 20);
            this.txtMsgEmailID.TabIndex = 96;
            this.txtMsgEmailID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSendSMSEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(621, 288);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSendSMSEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ارسال رسالة أو بريد";
            this.Load += new System.EventHandler(this.frmSendSMSEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCusNameSMS;
        private System.Windows.Forms.TextBox txtCusIDSMS;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.TextBox txtMessageSMS;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton arlang;
        private System.Windows.Forms.RadioButton englang;
        private DevExpress.XtraEditors.SimpleButton btnemailview;
        private System.Windows.Forms.TextBox txtCustId;
        private DevExpress.XtraEditors.SimpleButton btnSmsiew;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.TextBox txtMsgIDSMS;
        private System.Windows.Forms.TextBox txtMsgEmailID;
    }
}