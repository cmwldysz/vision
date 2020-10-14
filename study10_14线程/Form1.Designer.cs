namespace study10_14线程
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.Therad_lable_1 = new System.Windows.Forms.Label();
            this.Therad_lable_2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.Therad_lable_3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.Therad_lable_4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.Therad_lable_5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 19F);
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "线程一：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(138, 44);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(612, 26);
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 19F);
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "线程二：";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(138, 94);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(612, 26);
            this.progressBar2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 19F);
            this.button1.Location = new System.Drawing.Point(12, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "启动线程";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Therad_lable_1
            // 
            this.Therad_lable_1.AutoSize = true;
            this.Therad_lable_1.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_lable_1.Location = new System.Drawing.Point(795, 44);
            this.Therad_lable_1.Name = "Therad_lable_1";
            this.Therad_lable_1.Size = new System.Drawing.Size(38, 26);
            this.Therad_lable_1.TabIndex = 3;
            this.Therad_lable_1.Text = "0%";
            // 
            // Therad_lable_2
            // 
            this.Therad_lable_2.AutoSize = true;
            this.Therad_lable_2.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_lable_2.Location = new System.Drawing.Point(795, 90);
            this.Therad_lable_2.Name = "Therad_lable_2";
            this.Therad_lable_2.Size = new System.Drawing.Size(38, 26);
            this.Therad_lable_2.TabIndex = 3;
            this.Therad_lable_2.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 19F);
            this.label5.Location = new System.Drawing.Point(29, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "线程三：";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(138, 144);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(612, 26);
            this.progressBar3.TabIndex = 1;
            // 
            // Therad_lable_3
            // 
            this.Therad_lable_3.AutoSize = true;
            this.Therad_lable_3.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_lable_3.Location = new System.Drawing.Point(795, 145);
            this.Therad_lable_3.Name = "Therad_lable_3";
            this.Therad_lable_3.Size = new System.Drawing.Size(38, 26);
            this.Therad_lable_3.TabIndex = 3;
            this.Therad_lable_3.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 19F);
            this.label7.Location = new System.Drawing.Point(29, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "线程四：";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(138, 194);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(612, 26);
            this.progressBar4.TabIndex = 1;
            // 
            // Therad_lable_4
            // 
            this.Therad_lable_4.AutoSize = true;
            this.Therad_lable_4.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_lable_4.Location = new System.Drawing.Point(795, 200);
            this.Therad_lable_4.Name = "Therad_lable_4";
            this.Therad_lable_4.Size = new System.Drawing.Size(38, 26);
            this.Therad_lable_4.TabIndex = 3;
            this.Therad_lable_4.Text = "0%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 19F);
            this.label9.Location = new System.Drawing.Point(29, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "线程五：";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(138, 244);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(612, 26);
            this.progressBar5.TabIndex = 1;
            // 
            // Therad_lable_5
            // 
            this.Therad_lable_5.AutoSize = true;
            this.Therad_lable_5.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_lable_5.Location = new System.Drawing.Point(795, 244);
            this.Therad_lable_5.Name = "Therad_lable_5";
            this.Therad_lable_5.Size = new System.Drawing.Size(38, 26);
            this.Therad_lable_5.TabIndex = 3;
            this.Therad_lable_5.Text = "0%";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 19F);
            this.button2.Location = new System.Drawing.Point(236, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "线程挂起";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 19F);
            this.button3.Location = new System.Drawing.Point(460, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "线程终止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 19F);
            this.button4.Location = new System.Drawing.Point(684, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 43);
            this.button4.TabIndex = 2;
            this.button4.Text = "清空进度条";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 442);
            this.Controls.Add(this.Therad_lable_5);
            this.Controls.Add(this.Therad_lable_4);
            this.Controls.Add(this.Therad_lable_3);
            this.Controls.Add(this.Therad_lable_2);
            this.Controls.Add(this.Therad_lable_1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Therad_lable_1;
        private System.Windows.Forms.Label Therad_lable_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label Therad_lable_3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label Therad_lable_4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label Therad_lable_5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

