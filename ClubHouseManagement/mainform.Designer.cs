namespace ClubHouseManagement
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.tabhouseinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydataDataSet = new ClubHouseManagement.mydataDataSet();
            this.tab_house_inTableAdapter = new ClubHouseManagement.mydataDataSetTableAdapters.tab_house_inTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.r_count = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.r_name = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.r_number = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.r_data = new System.Windows.Forms.TextBox();
            this.r_label = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.r_money = new System.Windows.Forms.TextBox();
            this.replenish = new System.Windows.Forms.Button();
            this.read_info = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Read_infoby = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.c_money = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.consume = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.r_telephone = new System.Windows.Forms.TextBox();
            this.Out_show = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.In_name = new System.Windows.Forms.TextBox();
            this.tb_label = new System.Windows.Forms.TextBox();
            this.b_read = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.In_number = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.In_data = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.label_show = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.In_house = new System.Windows.Forms.Button();
            this.Reset_house_in = new System.Windows.Forms.Button();
            this.Canel_house_in = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.In_telephone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Connect = new System.Windows.Forms.GroupBox();
            this.Port = new System.Windows.Forms.Label();
            this.Baud = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_canel = new System.Windows.Forms.Button();
            this.port_show = new System.Windows.Forms.Label();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.cmb_baud = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.l_user = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.l_start_time = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabhouseinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydataDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.Connect.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabhouseinBindingSource
            // 
            this.tabhouseinBindingSource.DataMember = "tab_house_in";
            this.tabhouseinBindingSource.DataSource = this.mydataDataSet;
            // 
            // mydataDataSet
            // 
            this.mydataDataSet.DataSetName = "mydataDataSet";
            this.mydataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_house_inTableAdapter
            // 
            this.tab_house_inTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::ClubHouseManagement.Properties.Resources.主背景;
            this.tabPage2.Controls.Add(this.Out_show);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(853, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "读取会员卡";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.r_telephone);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.consume);
            this.groupBox6.Controls.Add(this.delete);
            this.groupBox6.Controls.Add(this.c_money);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.Read_infoby);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.read_info);
            this.groupBox6.Controls.Add(this.replenish);
            this.groupBox6.Controls.Add(this.r_money);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.r_label);
            this.groupBox6.Controls.Add(this.r_data);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.r_number);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.r_name);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.r_count);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Location = new System.Drawing.Point(9, 9);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(480, 551);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "会员卡信息";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 104);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 18);
            this.label21.TabIndex = 30;
            this.label21.Text = "会员卡编号";
            // 
            // r_count
            // 
            this.r_count.Location = new System.Drawing.Point(124, 101);
            this.r_count.Margin = new System.Windows.Forms.Padding(4);
            this.r_count.Name = "r_count";
            this.r_count.Size = new System.Drawing.Size(188, 28);
            this.r_count.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 154);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 18);
            this.label20.TabIndex = 32;
            this.label20.Text = "会员姓名";
            // 
            // r_name
            // 
            this.r_name.Location = new System.Drawing.Point(124, 151);
            this.r_name.Margin = new System.Windows.Forms.Padding(4);
            this.r_name.Name = "r_name";
            this.r_name.Size = new System.Drawing.Size(190, 28);
            this.r_name.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 202);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 18);
            this.label18.TabIndex = 38;
            this.label18.Text = "积分金额";
            // 
            // r_number
            // 
            this.r_number.Location = new System.Drawing.Point(124, 202);
            this.r_number.Margin = new System.Windows.Forms.Padding(4);
            this.r_number.Name = "r_number";
            this.r_number.Size = new System.Drawing.Size(190, 28);
            this.r_number.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 255);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 18);
            this.label17.TabIndex = 40;
            this.label17.Text = "操作日期";
            // 
            // r_data
            // 
            this.r_data.Location = new System.Drawing.Point(124, 252);
            this.r_data.Margin = new System.Windows.Forms.Padding(4);
            this.r_data.Name = "r_data";
            this.r_data.Size = new System.Drawing.Size(190, 28);
            this.r_data.TabIndex = 41;
            // 
            // r_label
            // 
            this.r_label.Location = new System.Drawing.Point(124, 49);
            this.r_label.Margin = new System.Windows.Forms.Padding(4);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(190, 28);
            this.r_label.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "序列号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "充值金额";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // r_money
            // 
            this.r_money.Location = new System.Drawing.Point(124, 443);
            this.r_money.Margin = new System.Windows.Forms.Padding(4);
            this.r_money.Name = "r_money";
            this.r_money.Size = new System.Drawing.Size(172, 28);
            this.r_money.TabIndex = 48;
            // 
            // replenish
            // 
            this.replenish.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.replenish.Location = new System.Drawing.Point(346, 438);
            this.replenish.Margin = new System.Windows.Forms.Padding(4);
            this.replenish.Name = "replenish";
            this.replenish.Size = new System.Drawing.Size(96, 34);
            this.replenish.TabIndex = 49;
            this.replenish.Text = "充值";
            this.replenish.UseVisualStyleBackColor = true;
            this.replenish.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // read_info
            // 
            this.read_info.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.read_info.Location = new System.Drawing.Point(346, 49);
            this.read_info.Margin = new System.Windows.Forms.Padding(4);
            this.read_info.Name = "read_info";
            this.read_info.Size = new System.Drawing.Size(98, 34);
            this.read_info.TabIndex = 0;
            this.read_info.Text = "读取";
            this.read_info.UseVisualStyleBackColor = true;
            this.read_info.Click += new System.EventHandler(this.Out_house_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 498);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "必须为整数";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Read_infoby
            // 
            this.Read_infoby.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.Read_infoby.Location = new System.Drawing.Point(346, 96);
            this.Read_infoby.Margin = new System.Windows.Forms.Padding(4);
            this.Read_infoby.Name = "Read_infoby";
            this.Read_infoby.Size = new System.Drawing.Size(96, 34);
            this.Read_infoby.TabIndex = 2;
            this.Read_infoby.Text = "查询";
            this.Read_infoby.UseVisualStyleBackColor = true;
            this.Read_infoby.Click += new System.EventHandler(this.Canel_house_out_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "消费金额";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // c_money
            // 
            this.c_money.Location = new System.Drawing.Point(124, 393);
            this.c_money.Margin = new System.Windows.Forms.Padding(4);
            this.c_money.Name = "c_money";
            this.c_money.Size = new System.Drawing.Size(172, 28);
            this.c_money.TabIndex = 51;
            this.c_money.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // delete
            // 
            this.delete.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.delete.Location = new System.Drawing.Point(346, 490);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(96, 34);
            this.delete.TabIndex = 1;
            this.delete.Text = "注销";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Reset_house_out_Click);
            // 
            // consume
            // 
            this.consume.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.consume.Location = new System.Drawing.Point(346, 388);
            this.consume.Margin = new System.Windows.Forms.Padding(4);
            this.consume.Name = "consume";
            this.consume.Size = new System.Drawing.Size(96, 34);
            this.consume.TabIndex = 52;
            this.consume.Text = "消费";
            this.consume.UseVisualStyleBackColor = true;
            this.consume.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 306);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 53;
            this.label14.Text = "联系方式";
            // 
            // r_telephone
            // 
            this.r_telephone.Location = new System.Drawing.Point(124, 303);
            this.r_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.r_telephone.Name = "r_telephone";
            this.r_telephone.Size = new System.Drawing.Size(190, 28);
            this.r_telephone.TabIndex = 54;
            // 
            // Out_show
            // 
            this.Out_show.AutoSize = true;
            this.Out_show.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Out_show.Location = new System.Drawing.Point(547, 248);
            this.Out_show.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Out_show.Name = "Out_show";
            this.Out_show.Size = new System.Drawing.Size(162, 39);
            this.Out_show.TabIndex = 5;
            this.Out_show.Text = "等待操作！";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ClubHouseManagement.Properties.Resources.主背景;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(853, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新增会员卡";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.In_telephone);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.label_show);
            this.groupBox7.Controls.Add(this.tb_count);
            this.groupBox7.Controls.Add(this.In_data);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.In_number);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.b_read);
            this.groupBox7.Controls.Add(this.tb_label);
            this.groupBox7.Controls.Add(this.In_name);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Location = new System.Drawing.Point(298, 9);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(542, 601);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "添加会员卡";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "会员姓名";
            // 
            // In_name
            // 
            this.In_name.Location = new System.Drawing.Point(127, 165);
            this.In_name.Margin = new System.Windows.Forms.Padding(4);
            this.In_name.Name = "In_name";
            this.In_name.Size = new System.Drawing.Size(172, 28);
            this.In_name.TabIndex = 19;
            // 
            // tb_label
            // 
            this.tb_label.Location = new System.Drawing.Point(127, 29);
            this.tb_label.Margin = new System.Windows.Forms.Padding(4);
            this.tb_label.Name = "tb_label";
            this.tb_label.Size = new System.Drawing.Size(172, 28);
            this.tb_label.TabIndex = 31;
            // 
            // b_read
            // 
            this.b_read.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.b_read.Location = new System.Drawing.Point(323, 26);
            this.b_read.Margin = new System.Windows.Forms.Padding(4);
            this.b_read.Name = "b_read";
            this.b_read.Size = new System.Drawing.Size(81, 34);
            this.b_read.TabIndex = 32;
            this.b_read.Text = "读取";
            this.b_read.UseVisualStyleBackColor = true;
            this.b_read.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(39, 34);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 18);
            this.label22.TabIndex = 30;
            this.label22.Text = "序列号";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "积分金额";
            // 
            // In_number
            // 
            this.In_number.Location = new System.Drawing.Point(127, 227);
            this.In_number.Margin = new System.Windows.Forms.Padding(4);
            this.In_number.Name = "In_number";
            this.In_number.Size = new System.Drawing.Size(172, 28);
            this.In_number.TabIndex = 25;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(39, 99);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 18);
            this.label23.TabIndex = 33;
            this.label23.Text = "会员编号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "入籍日期";
            // 
            // In_data
            // 
            this.In_data.Location = new System.Drawing.Point(127, 300);
            this.In_data.Margin = new System.Windows.Forms.Padding(4);
            this.In_data.Name = "In_data";
            this.In_data.Size = new System.Drawing.Size(172, 28);
            this.In_data.TabIndex = 27;
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(127, 96);
            this.tb_count.Margin = new System.Windows.Forms.Padding(4);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(172, 28);
            this.tb_count.TabIndex = 34;
            this.tb_count.TextChanged += new System.EventHandler(this.tb_count_TextChanged);
            // 
            // label_show
            // 
            this.label_show.AutoSize = true;
            this.label_show.Location = new System.Drawing.Point(373, 168);
            this.label_show.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(80, 18);
            this.label_show.TabIndex = 37;
            this.label_show.Text = "请读卡！";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Canel_house_in);
            this.groupBox2.Controls.Add(this.Reset_house_in);
            this.groupBox2.Controls.Add(this.In_house);
            this.groupBox2.Location = new System.Drawing.Point(42, 406);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(463, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "管理";
            // 
            // In_house
            // 
            this.In_house.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.In_house.Location = new System.Drawing.Point(40, 94);
            this.In_house.Margin = new System.Windows.Forms.Padding(4);
            this.In_house.Name = "In_house";
            this.In_house.Size = new System.Drawing.Size(87, 34);
            this.In_house.TabIndex = 0;
            this.In_house.Text = "添加";
            this.In_house.UseVisualStyleBackColor = true;
            this.In_house.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset_house_in
            // 
            this.Reset_house_in.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.Reset_house_in.Location = new System.Drawing.Point(192, 94);
            this.Reset_house_in.Margin = new System.Windows.Forms.Padding(4);
            this.Reset_house_in.Name = "Reset_house_in";
            this.Reset_house_in.Size = new System.Drawing.Size(87, 34);
            this.Reset_house_in.TabIndex = 1;
            this.Reset_house_in.Text = "重置";
            this.Reset_house_in.UseVisualStyleBackColor = true;
            this.Reset_house_in.Click += new System.EventHandler(this.button2_Click);
            // 
            // Canel_house_in
            // 
            this.Canel_house_in.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.Canel_house_in.Location = new System.Drawing.Point(334, 94);
            this.Canel_house_in.Margin = new System.Windows.Forms.Padding(4);
            this.Canel_house_in.Name = "Canel_house_in";
            this.Canel_house_in.Size = new System.Drawing.Size(87, 34);
            this.Canel_house_in.TabIndex = 2;
            this.Canel_house_in.Text = "取消";
            this.Canel_house_in.UseVisualStyleBackColor = true;
            this.Canel_house_in.Click += new System.EventHandler(this.Canel_house_in_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 303);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "日期格式：2018/1/1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 364);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "联系方式";
            // 
            // In_telephone
            // 
            this.In_telephone.Location = new System.Drawing.Point(127, 361);
            this.In_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.In_telephone.Name = "In_telephone";
            this.In_telephone.Size = new System.Drawing.Size(172, 28);
            this.In_telephone.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClubHouseManagement.Properties.Resources.图片一;
            this.pictureBox1.Location = new System.Drawing.Point(25, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 443);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.BackgroundImage = global::ClubHouseManagement.Properties.Resources.阿狸;
            this.tabPage4.Controls.Add(this.l_start_time);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.l_user);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.Connect);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(853, 630);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "基本信息";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // Connect
            // 
            this.Connect.AutoSize = true;
            this.Connect.BackColor = System.Drawing.Color.Transparent;
            this.Connect.Controls.Add(this.cmb_baud);
            this.Connect.Controls.Add(this.cmb_port);
            this.Connect.Controls.Add(this.port_show);
            this.Connect.Controls.Add(this.b_canel);
            this.Connect.Controls.Add(this.b_ok);
            this.Connect.Controls.Add(this.Baud);
            this.Connect.Controls.Add(this.Port);
            this.Connect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Connect.Location = new System.Drawing.Point(400, 18);
            this.Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Connect.Name = "Connect";
            this.Connect.Padding = new System.Windows.Forms.Padding(4);
            this.Connect.Size = new System.Drawing.Size(402, 290);
            this.Connect.TabIndex = 2;
            this.Connect.TabStop = false;
            this.Connect.Text = "设备连接";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(46, 74);
            this.Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(80, 18);
            this.Port.TabIndex = 0;
            this.Port.Text = "串口号：";
            // 
            // Baud
            // 
            this.Baud.AutoSize = true;
            this.Baud.Location = new System.Drawing.Point(46, 132);
            this.Baud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(80, 18);
            this.Baud.TabIndex = 1;
            this.Baud.Text = "波特率：";
            // 
            // b_ok
            // 
            this.b_ok.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.b_ok.Location = new System.Drawing.Point(75, 218);
            this.b_ok.Margin = new System.Windows.Forms.Padding(4);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(84, 32);
            this.b_ok.TabIndex = 4;
            this.b_ok.Text = "确定";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_canel
            // 
            this.b_canel.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.b_canel.Location = new System.Drawing.Point(238, 218);
            this.b_canel.Margin = new System.Windows.Forms.Padding(4);
            this.b_canel.Name = "b_canel";
            this.b_canel.Size = new System.Drawing.Size(84, 32);
            this.b_canel.TabIndex = 5;
            this.b_canel.Text = "取消";
            this.b_canel.UseVisualStyleBackColor = true;
            this.b_canel.Click += new System.EventHandler(this.b_canel_Click);
            // 
            // port_show
            // 
            this.port_show.AutoSize = true;
            this.port_show.Location = new System.Drawing.Point(50, 178);
            this.port_show.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.port_show.Name = "port_show";
            this.port_show.Size = new System.Drawing.Size(98, 18);
            this.port_show.TabIndex = 6;
            this.port_show.Text = "尚未连接！";
            // 
            // cmb_port
            // 
            this.cmb_port.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmb_port.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14"});
            this.cmb_port.Location = new System.Drawing.Point(146, 69);
            this.cmb_port.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(216, 26);
            this.cmb_port.TabIndex = 7;
            this.cmb_port.Text = "请选择串口号";
            // 
            // cmb_baud
            // 
            this.cmb_baud.FormattingEnabled = true;
            this.cmb_baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmb_baud.Location = new System.Drawing.Point(142, 120);
            this.cmb_baud.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_baud.Name = "cmb_baud";
            this.cmb_baud.Size = new System.Drawing.Size(216, 26);
            this.cmb_baud.TabIndex = 8;
            this.cmb_baud.Text = "请选择波特率";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(540, 356);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "程序正在被使用：";
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Location = new System.Drawing.Point(706, 356);
            this.l_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(53, 18);
            this.l_user.TabIndex = 4;
            this.l_user.Text = "admin";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(540, 435);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "使用起始时间：";
            // 
            // l_start_time
            // 
            this.l_start_time.AutoSize = true;
            this.l_start_time.Location = new System.Drawing.Point(702, 435);
            this.l_start_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_start_time.Name = "l_start_time";
            this.l_start_time.Size = new System.Drawing.Size(26, 18);
            this.l_start_time.TabIndex = 6;
            this.l_start_time.Text = "空";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 662);
            this.tabControl1.TabIndex = 0;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClubHouseManagement.Properties.Resources.主背景;
            this.ClientSize = new System.Drawing.Size(903, 682);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阿狸会所管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabhouseinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydataDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.Connect.ResumeLayout(false);
            this.Connect.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private mydataDataSet mydataDataSet;
        private System.Windows.Forms.BindingSource tabhouseinBindingSource;
        private mydataDataSetTableAdapters.tab_house_inTableAdapter tab_house_inTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Out_show;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox r_telephone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button consume;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox c_money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Read_infoby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button read_info;
        private System.Windows.Forms.Button replenish;
        private System.Windows.Forms.TextBox r_money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox r_label;
        private System.Windows.Forms.TextBox r_data;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox r_number;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox r_name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox r_count;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox In_telephone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Canel_house_in;
        private System.Windows.Forms.Button Reset_house_in;
        private System.Windows.Forms.Button In_house;
        private System.Windows.Forms.Label label_show;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.TextBox In_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox In_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button b_read;
        private System.Windows.Forms.TextBox tb_label;
        private System.Windows.Forms.TextBox In_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label l_start_time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Connect;
        private System.Windows.Forms.ComboBox cmb_baud;
        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.Label port_show;
        private System.Windows.Forms.Button b_canel;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Label Baud;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TabControl tabControl1;
    }
}