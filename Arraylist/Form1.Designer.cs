namespace Arraylistone
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picleft = new System.Windows.Forms.PictureBox();
            this.picright = new System.Windows.Forms.PictureBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblcount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblright = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lblwrong = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.progressbar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rtbword = new System.Windows.Forms.RichTextBox();
            this.rtbtyping = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picright)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picleft
            // 
            this.picleft.Location = new System.Drawing.Point(39, 114);
            this.picleft.Name = "picleft";
            this.picleft.Size = new System.Drawing.Size(181, 125);
            this.picleft.TabIndex = 1;
            this.picleft.TabStop = false;
            // 
            // picright
            // 
            this.picright.Location = new System.Drawing.Point(404, 114);
            this.picright.Name = "picright";
            this.picright.Size = new System.Drawing.Size(179, 125);
            this.picright.TabIndex = 1;
            this.picright.TabStop = false;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(281, 152);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(62, 20);
            this.lblHelp.TabIndex = 2;
            this.lblHelp.Text = "Press h";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "Count:";
            // 
            // lblcount
            // 
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(13, 22);
            this.lblcount.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel3.Text = "Right:";
            // 
            // lblright
            // 
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(13, 22);
            this.lblright.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel5.Text = "Wrong:";
            // 
            // lblwrong
            // 
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(13, 22);
            this.lblwrong.Text = "0";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel7.Text = "Progress:";
            // 
            // progressbar1
            // 
            this.progressbar1.Name = "progressbar1";
            this.progressbar1.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblcount,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.lblright,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.lblwrong,
            this.toolStripLabel7,
            this.progressbar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 426);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rtbword
            // 
            this.rtbword.Location = new System.Drawing.Point(12, 8);
            this.rtbword.Name = "rtbword";
            this.rtbword.Size = new System.Drawing.Size(645, 96);
            this.rtbword.TabIndex = 4;
            this.rtbword.Text = "hello everyone and other";
            // 
            // rtbtyping
            // 
            this.rtbtyping.Location = new System.Drawing.Point(12, 258);
            this.rtbtyping.Name = "rtbtyping";
            this.rtbtyping.Size = new System.Drawing.Size(645, 96);
            this.rtbtyping.TabIndex = 4;
            this.rtbtyping.Text = "";
            this.rtbtyping.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbtyping_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fig0.png");
            this.imageList1.Images.SetKeyName(1, "fig1.png");
            this.imageList1.Images.SetKeyName(2, "fig2.png");
            this.imageList1.Images.SetKeyName(3, "fig3.png");
            this.imageList1.Images.SetKeyName(4, "fig4.png");
            this.imageList1.Images.SetKeyName(5, "fig5.png");
            this.imageList1.Images.SetKeyName(6, "fig6.png");
            this.imageList1.Images.SetKeyName(7, "fig7.png");
            this.imageList1.Images.SetKeyName(8, "fig8.png");
            this.imageList1.Images.SetKeyName(9, "fig9.png");
            this.imageList1.Images.SetKeyName(10, "had10.png");
            this.imageList1.Images.SetKeyName(11, "had11.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 451);
            this.Controls.Add(this.rtbtyping);
            this.Controls.Add(this.rtbword);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.picright);
            this.Controls.Add(this.picleft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
          //  this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picright)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picleft;
        private System.Windows.Forms.PictureBox picright;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblcount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblright;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lblwrong;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripProgressBar progressbar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox rtbword;
        private System.Windows.Forms.RichTextBox rtbtyping;
        private System.Windows.Forms.ImageList imageList1;
    }
}

