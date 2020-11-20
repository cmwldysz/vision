namespace study10_16串口通信
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBauRaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPoint = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.cmbStopBit);
            this.groupBox1.Controls.Add(this.cmbDataBits);
            this.groupBox1.Controls.Add(this.cmbBauRaudRate);
            this.groupBox1.Controls.Add(this.cmbPoint);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "NULL",
            "EVEN",
            "ODD"});
            this.cmbParity.Location = new System.Drawing.Point(121, 319);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(205, 34);
            this.cmbParity.TabIndex = 3;
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBit.Location = new System.Drawing.Point(121, 250);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(205, 34);
            this.cmbStopBit.TabIndex = 3;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits.Location = new System.Drawing.Point(121, 181);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(205, 34);
            this.cmbDataBits.TabIndex = 3;
            // 
            // cmbBauRaudRate
            // 
            this.cmbBauRaudRate.FormattingEnabled = true;
            this.cmbBauRaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000"});
            this.cmbBauRaudRate.Location = new System.Drawing.Point(121, 112);
            this.cmbBauRaudRate.Name = "cmbBauRaudRate";
            this.cmbBauRaudRate.Size = new System.Drawing.Size(205, 34);
            this.cmbBauRaudRate.TabIndex = 3;
            // 
            // cmbPoint
            // 
            this.cmbPoint.FormattingEnabled = true;
            this.cmbPoint.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.cmbPoint.Location = new System.Drawing.Point(121, 43);
            this.cmbPoint.Name = "cmbPoint";
            this.cmbPoint.Size = new System.Drawing.Size(205, 34);
            this.cmbPoint.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "校验位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(427, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送模式";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(158, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 30);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "字符串";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "16进制";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(427, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 329);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "方向控制面板";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::study10_16串口通信.Properties.Resources.arrow_forward_navigation_next_right_128px_1225491_easyicon_net;
            this.button6.Location = new System.Drawing.Point(241, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 116);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopRun);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::study10_16串口通信.Properties.Resources.arrow_back_left_navigation_previous_128px_1225467_easyicon_net;
            this.button5.Location = new System.Drawing.Point(30, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 116);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopRun);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::study10_16串口通信.Properties.Resources.arrow_bottom_down_downward_navigation_128px_1225446_easyicon_net;
            this.button4.Location = new System.Drawing.Point(117, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 66);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopRun);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::study10_16串口通信.Properties.Resources.above_arrow_navigation_top_up_128px_1225504_easyicon_net;
            this.button3.Location = new System.Drawing.Point(117, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 66);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopRun);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::study10_16串口通信.Properties.Resources.stop_128px_1226781_easyicon_net;
            this.button2.Location = new System.Drawing.Point(112, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 116);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopRun);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(813, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 459);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收/发送-数据";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(230, 386);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 45);
            this.button8.TabIndex = 2;
            this.button8.Text = "清空";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 386);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 45);
            this.button7.TabIndex = 2;
            this.button7.Text = "发送";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 253);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(324, 103);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "FF 01 00 04 20 00 25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "发送数据";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 103);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "接收数据";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 570);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBauRaudRate;
        private System.Windows.Forms.ComboBox cmbPoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

