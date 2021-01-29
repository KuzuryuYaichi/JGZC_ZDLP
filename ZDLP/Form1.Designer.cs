namespace ZDLP
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBandWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMidPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.PanelUserDefined = new System.Windows.Forms.Panel();
            this.RadioUserDefined = new System.Windows.Forms.RadioButton();
            this.PanelAverage = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaseBand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBandWidth = new System.Windows.Forms.ComboBox();
            this.RadioAverage = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioNB = new System.Windows.Forms.RadioButton();
            this.RadioWB = new System.Windows.Forms.RadioButton();
            this.PanelFromFile = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.GroupBandSet = new System.Windows.Forms.GroupBox();
            this.radioFromFile = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioManual = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSavePath = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.PanelManual = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.RadioSize = new System.Windows.Forms.RadioButton();
            this.RadioTime = new System.Windows.Forms.RadioButton();
            this.PanelSize = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelTime = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelUserDefined.SuspendLayout();
            this.PanelAverage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PanelFromFile.SuspendLayout();
            this.GroupBandSet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PanelManual.SuspendLayout();
            this.PanelSize.SuspendLayout();
            this.PanelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPriority,
            this.ColumnStartNum,
            this.ColumnEndNum,
            this.ColumnBandWidth,
            this.ColumnMidPoint});
            this.dataGridView1.Location = new System.Drawing.Point(10, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(531, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnPriority
            // 
            this.ColumnPriority.DataPropertyName = "Priority";
            this.ColumnPriority.HeaderText = "优先级";
            this.ColumnPriority.Name = "ColumnPriority";
            // 
            // ColumnStartNum
            // 
            this.ColumnStartNum.DataPropertyName = "StartNum";
            this.ColumnStartNum.HeaderText = "起始子带号";
            this.ColumnStartNum.Name = "ColumnStartNum";
            this.ColumnStartNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnEndNum
            // 
            this.ColumnEndNum.DataPropertyName = "EndNum";
            this.ColumnEndNum.HeaderText = "结束子带号";
            this.ColumnEndNum.Name = "ColumnEndNum";
            this.ColumnEndNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnBandWidth
            // 
            this.ColumnBandWidth.DataPropertyName = "BandWidth";
            this.ColumnBandWidth.HeaderText = "带宽";
            this.ColumnBandWidth.Name = "ColumnBandWidth";
            this.ColumnBandWidth.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnMidPoint
            // 
            this.ColumnMidPoint.DataPropertyName = "Freq";
            this.ColumnMidPoint.HeaderText = "中心频点";
            this.ColumnMidPoint.Name = "ColumnMidPoint";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加规则";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(91, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "移除规则";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "本机IP:";
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(438, 6);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(48, 22);
            this.UpBtn.TabIndex = 5;
            this.UpBtn.Text = "Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(494, 6);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(47, 23);
            this.DownBtn.TabIndex = 6;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // PanelUserDefined
            // 
            this.PanelUserDefined.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelUserDefined.Controls.Add(this.button8);
            this.PanelUserDefined.Controls.Add(this.button7);
            this.PanelUserDefined.Controls.Add(this.btnAdd);
            this.PanelUserDefined.Controls.Add(this.DownBtn);
            this.PanelUserDefined.Controls.Add(this.dataGridView1);
            this.PanelUserDefined.Controls.Add(this.UpBtn);
            this.PanelUserDefined.Controls.Add(this.btnRemove);
            this.PanelUserDefined.Location = new System.Drawing.Point(18, 41);
            this.PanelUserDefined.Name = "PanelUserDefined";
            this.PanelUserDefined.Size = new System.Drawing.Size(554, 255);
            this.PanelUserDefined.TabIndex = 7;
            // 
            // RadioUserDefined
            // 
            this.RadioUserDefined.AutoSize = true;
            this.RadioUserDefined.Location = new System.Drawing.Point(18, 20);
            this.RadioUserDefined.Name = "RadioUserDefined";
            this.RadioUserDefined.Size = new System.Drawing.Size(59, 16);
            this.RadioUserDefined.TabIndex = 1;
            this.RadioUserDefined.Text = "自定义";
            this.RadioUserDefined.UseVisualStyleBackColor = true;
            this.RadioUserDefined.CheckedChanged += new System.EventHandler(this.RadioUserDefined_CheckedChanged);
            // 
            // PanelAverage
            // 
            this.PanelAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelAverage.Controls.Add(this.label5);
            this.PanelAverage.Controls.Add(this.txtBaseBand);
            this.PanelAverage.Controls.Add(this.label8);
            this.PanelAverage.Controls.Add(this.label9);
            this.PanelAverage.Controls.Add(this.comboBandWidth);
            this.PanelAverage.Location = new System.Drawing.Point(18, 325);
            this.PanelAverage.Name = "PanelAverage";
            this.PanelAverage.Size = new System.Drawing.Size(411, 40);
            this.PanelAverage.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 112;
            this.label5.Text = "Mhz";
            // 
            // txtBaseBand
            // 
            this.txtBaseBand.Location = new System.Drawing.Point(311, 7);
            this.txtBaseBand.Name = "txtBaseBand";
            this.txtBaseBand.Size = new System.Drawing.Size(59, 21);
            this.txtBaseBand.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 12);
            this.label8.TabIndex = 110;
            this.label8.Text = "起始中心频点(0.1Mhz递增):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 108;
            this.label9.Text = "带宽:";
            // 
            // comboBandWidth
            // 
            this.comboBandWidth.FormattingEnabled = true;
            this.comboBandWidth.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2.1",
            "2.4",
            "2.7",
            "3.2",
            "4",
            "4.8",
            "6",
            "9",
            "12",
            "15",
            "30",
            "50"});
            this.comboBandWidth.Location = new System.Drawing.Point(46, 8);
            this.comboBandWidth.Margin = new System.Windows.Forms.Padding(2);
            this.comboBandWidth.Name = "comboBandWidth";
            this.comboBandWidth.Size = new System.Drawing.Size(86, 20);
            this.comboBandWidth.TabIndex = 109;
            // 
            // RadioAverage
            // 
            this.RadioAverage.AutoSize = true;
            this.RadioAverage.Location = new System.Drawing.Point(18, 303);
            this.RadioAverage.Name = "RadioAverage";
            this.RadioAverage.Size = new System.Drawing.Size(47, 16);
            this.RadioAverage.TabIndex = 7;
            this.RadioAverage.TabStop = true;
            this.RadioAverage.Text = "平均";
            this.RadioAverage.UseVisualStyleBackColor = true;
            this.RadioAverage.CheckedChanged += new System.EventHandler(this.RadioAverage_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "子带配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "开始存储";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.PanelFromFile);
            this.groupBox1.Controls.Add(this.GroupBandSet);
            this.groupBox1.Controls.Add(this.radioFromFile);
            this.groupBox1.Controls.Add(this.RadioUserDefined);
            this.groupBox1.Controls.Add(this.PanelUserDefined);
            this.groupBox1.Controls.Add(this.PanelAverage);
            this.groupBox1.Controls.Add(this.RadioAverage);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 447);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "子带配置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioNB);
            this.groupBox3.Controls.Add(this.RadioWB);
            this.groupBox3.Location = new System.Drawing.Point(443, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 51);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "子带类型";
            // 
            // RadioNB
            // 
            this.RadioNB.AutoSize = true;
            this.RadioNB.Location = new System.Drawing.Point(15, 22);
            this.RadioNB.Name = "RadioNB";
            this.RadioNB.Size = new System.Drawing.Size(47, 16);
            this.RadioNB.TabIndex = 13;
            this.RadioNB.Text = "窄带";
            this.RadioNB.UseVisualStyleBackColor = true;
            this.RadioNB.CheckedChanged += new System.EventHandler(this.RadioNB_CheckedChanged);
            // 
            // RadioWB
            // 
            this.RadioWB.AutoSize = true;
            this.RadioWB.Location = new System.Drawing.Point(71, 22);
            this.RadioWB.Name = "RadioWB";
            this.RadioWB.Size = new System.Drawing.Size(47, 16);
            this.RadioWB.TabIndex = 12;
            this.RadioWB.Text = "宽带";
            this.RadioWB.UseVisualStyleBackColor = true;
            this.RadioWB.CheckedChanged += new System.EventHandler(this.RadioWB_CheckedChanged);
            // 
            // PanelFromFile
            // 
            this.PanelFromFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelFromFile.Controls.Add(this.label6);
            this.PanelFromFile.Controls.Add(this.label7);
            this.PanelFromFile.Controls.Add(this.button6);
            this.PanelFromFile.Location = new System.Drawing.Point(18, 393);
            this.PanelFromFile.Name = "PanelFromFile";
            this.PanelFromFile.Size = new System.Drawing.Size(308, 39);
            this.PanelFromFile.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "存储位置:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Path";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(72, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "选择";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // GroupBandSet
            // 
            this.GroupBandSet.Controls.Add(this.button1);
            this.GroupBandSet.Controls.Add(this.comboBox1);
            this.GroupBandSet.Controls.Add(this.label1);
            this.GroupBandSet.Location = new System.Drawing.Point(332, 384);
            this.GroupBandSet.Name = "GroupBandSet";
            this.GroupBandSet.Size = new System.Drawing.Size(240, 48);
            this.GroupBandSet.TabIndex = 20;
            this.GroupBandSet.TabStop = false;
            this.GroupBandSet.Text = "子带设置";
            // 
            // radioFromFile
            // 
            this.radioFromFile.AutoSize = true;
            this.radioFromFile.Location = new System.Drawing.Point(18, 371);
            this.radioFromFile.Name = "radioFromFile";
            this.radioFromFile.Size = new System.Drawing.Size(71, 16);
            this.radioFromFile.TabIndex = 10;
            this.radioFromFile.TabStop = true;
            this.radioFromFile.Text = "配置文件";
            this.radioFromFile.UseVisualStyleBackColor = true;
            this.radioFromFile.CheckedChanged += new System.EventHandler(this.RadioFromFile_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioManual);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.PanelManual);
            this.groupBox2.Controls.Add(this.RadioSize);
            this.groupBox2.Controls.Add(this.RadioTime);
            this.groupBox2.Controls.Add(this.PanelSize);
            this.groupBox2.Controls.Add(this.PanelTime);
            this.groupBox2.Location = new System.Drawing.Point(16, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 157);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "存储";
            // 
            // RadioManual
            // 
            this.RadioManual.AutoSize = true;
            this.RadioManual.Location = new System.Drawing.Point(444, 23);
            this.RadioManual.Name = "RadioManual";
            this.RadioManual.Size = new System.Drawing.Size(47, 16);
            this.RadioManual.TabIndex = 11;
            this.RadioManual.TabStop = true;
            this.RadioManual.Text = "手动";
            this.RadioManual.UseVisualStyleBackColor = true;
            this.RadioManual.CheckedChanged += new System.EventHandler(this.RadioManual_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.LblSavePath);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(18, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(554, 33);
            this.panel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "存储位置:";
            // 
            // LblSavePath
            // 
            this.LblSavePath.AutoSize = true;
            this.LblSavePath.Location = new System.Drawing.Point(138, 8);
            this.LblSavePath.Name = "LblSavePath";
            this.LblSavePath.Size = new System.Drawing.Size(29, 12);
            this.LblSavePath.TabIndex = 17;
            this.LblSavePath.Text = "Path";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "选择";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PanelManual
            // 
            this.PanelManual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelManual.Controls.Add(this.button4);
            this.PanelManual.Location = new System.Drawing.Point(441, 45);
            this.PanelManual.Name = "PanelManual";
            this.PanelManual.Size = new System.Drawing.Size(131, 49);
            this.PanelManual.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "开始存储";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RadioSize
            // 
            this.RadioSize.AutoSize = true;
            this.RadioSize.Location = new System.Drawing.Point(229, 23);
            this.RadioSize.Name = "RadioSize";
            this.RadioSize.Size = new System.Drawing.Size(71, 16);
            this.RadioSize.TabIndex = 11;
            this.RadioSize.TabStop = true;
            this.RadioSize.Text = "固定长度";
            this.RadioSize.UseVisualStyleBackColor = true;
            this.RadioSize.CheckedChanged += new System.EventHandler(this.RadioSize_CheckedChanged);
            // 
            // RadioTime
            // 
            this.RadioTime.AutoSize = true;
            this.RadioTime.Location = new System.Drawing.Point(18, 23);
            this.RadioTime.Name = "RadioTime";
            this.RadioTime.Size = new System.Drawing.Size(71, 16);
            this.RadioTime.TabIndex = 11;
            this.RadioTime.Text = "固定时间";
            this.RadioTime.UseVisualStyleBackColor = true;
            this.RadioTime.CheckedChanged += new System.EventHandler(this.RadioTime_CheckedChanged);
            // 
            // PanelSize
            // 
            this.PanelSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSize.Controls.Add(this.textBox2);
            this.PanelSize.Controls.Add(this.label3);
            this.PanelSize.Controls.Add(this.button3);
            this.PanelSize.Location = new System.Drawing.Point(229, 45);
            this.PanelSize.Name = "PanelSize";
            this.PanelSize.Size = new System.Drawing.Size(186, 49);
            this.PanelSize.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 21);
            this.textBox2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "MB";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "开始存储";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PanelTime
            // 
            this.PanelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTime.Controls.Add(this.label2);
            this.PanelTime.Controls.Add(this.comboBox2);
            this.PanelTime.Controls.Add(this.button2);
            this.PanelTime.Location = new System.Drawing.Point(18, 45);
            this.PanelTime.Name = "PanelTime";
            this.PanelTime.Size = new System.Drawing.Size(186, 49);
            this.PanelTime.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "秒";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox2.Location = new System.Drawing.Point(10, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(68, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "保存规则";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(253, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "读取规则";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelUserDefined.ResumeLayout(false);
            this.PanelAverage.ResumeLayout(false);
            this.PanelAverage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PanelFromFile.ResumeLayout(false);
            this.PanelFromFile.PerformLayout();
            this.GroupBandSet.ResumeLayout(false);
            this.GroupBandSet.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.PanelManual.ResumeLayout(false);
            this.PanelSize.ResumeLayout(false);
            this.PanelSize.PerformLayout();
            this.PanelTime.ResumeLayout(false);
            this.PanelTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Panel PanelUserDefined;
        private System.Windows.Forms.RadioButton RadioUserDefined;
        private System.Windows.Forms.Panel PanelAverage;
        private System.Windows.Forms.RadioButton RadioAverage;
        private System.Windows.Forms.TextBox txtBaseBand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBandWidth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel PanelManual;
        private System.Windows.Forms.RadioButton RadioManual;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel PanelSize;
        private System.Windows.Forms.RadioButton RadioSize;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelTime;
        private System.Windows.Forms.RadioButton RadioTime;
        private System.Windows.Forms.Label LblSavePath;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelFromFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox GroupBandSet;
        private System.Windows.Forms.RadioButton radioFromFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioNB;
        private System.Windows.Forms.RadioButton RadioWB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBandWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMidPoint;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

