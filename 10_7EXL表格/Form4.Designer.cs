namespace _10_7EXL表格
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(283, 293);
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete (1).png");
            this.imageList1.Images.SetKeyName(1, "employee.png");
            this.imageList1.Images.SetKeyName(2, "home.png");
            this.imageList1.Images.SetKeyName(3, "hours.png");
            this.imageList1.Images.SetKeyName(4, "laptop.png");
            this.imageList1.Images.SetKeyName(5, "law_book.png");
            this.imageList1.Images.SetKeyName(6, "Library (1).png");
            this.imageList1.Images.SetKeyName(7, "library.png");
            this.imageList1.Images.SetKeyName(8, "library_80.857142857143px_1193309_easyicon.net.png");
            this.imageList1.Images.SetKeyName(9, "list (1).png");
            this.imageList1.Images.SetKeyName(10, "list.png");
            this.imageList1.Images.SetKeyName(11, "money (1).png");
            this.imageList1.Images.SetKeyName(12, "money (2).png");
            this.imageList1.Images.SetKeyName(13, "money.png");
            this.imageList1.Images.SetKeyName(14, "notepad_ok.png");
            this.imageList1.Images.SetKeyName(15, "Ok.png");
            this.imageList1.Images.SetKeyName(16, "sale_button (1).png");
            this.imageList1.Images.SetKeyName(17, "sale_button.png");
            this.imageList1.Images.SetKeyName(18, "script.png");
            this.imageList1.Images.SetKeyName(19, "show_sidebar_vert (1).png");
            this.imageList1.Images.SetKeyName(20, "show_sidebar_vert.png");
            this.imageList1.Images.SetKeyName(21, "superman_158.51313131313px_1190175_easyicon.net.png");
            this.imageList1.Images.SetKeyName(22, "weibo.png");
            this.imageList1.Images.SetKeyName(23, "weixindenglu_Wechat_Pay.png");
            this.imageList1.Images.SetKeyName(24, "www.png");
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}