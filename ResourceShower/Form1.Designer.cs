namespace ResourceShower
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.顯示在最上層ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外觀ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.調整大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.無邊框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.波行疏密度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.連續ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.間斷2xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.間斷3xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顯示在最上層ToolStripMenuItem,
            this.外觀ToolStripMenuItem,
            this.toolStripSeparator2,
            this.結束ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 76);
            // 
            // 顯示在最上層ToolStripMenuItem
            // 
            this.顯示在最上層ToolStripMenuItem.Name = "顯示在最上層ToolStripMenuItem";
            this.顯示在最上層ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.顯示在最上層ToolStripMenuItem.Text = "顯示在最上層";
            this.顯示在最上層ToolStripMenuItem.Click += new System.EventHandler(this.顯示在最上層ToolStripMenuItem_Click);
            // 
            // 外觀ToolStripMenuItem
            // 
            this.外觀ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.調整大小ToolStripMenuItem,
            this.無邊框ToolStripMenuItem,
            this.toolStripSeparator1,
            this.波行疏密度ToolStripMenuItem});
            this.外觀ToolStripMenuItem.Name = "外觀ToolStripMenuItem";
            this.外觀ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.外觀ToolStripMenuItem.Text = "外觀";
            // 
            // 調整大小ToolStripMenuItem
            // 
            this.調整大小ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2});
            this.調整大小ToolStripMenuItem.Name = "調整大小ToolStripMenuItem";
            this.調整大小ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.調整大小ToolStripMenuItem.Text = "調整大小";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.xToolStripMenuItem.Text = "1x";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.xToolStripMenuItem1.Text = "1.25x";
            this.xToolStripMenuItem1.Click += new System.EventHandler(this.xToolStripMenuItem1_Click);
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(104, 22);
            this.xToolStripMenuItem2.Text = "1.5x";
            this.xToolStripMenuItem2.Click += new System.EventHandler(this.xToolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 無邊框ToolStripMenuItem
            // 
            this.無邊框ToolStripMenuItem.Name = "無邊框ToolStripMenuItem";
            this.無邊框ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.無邊框ToolStripMenuItem.Text = "無邊框";
            this.無邊框ToolStripMenuItem.Click += new System.EventHandler(this.無邊框ToolStripMenuItem_Click);
            // 
            // 波行疏密度ToolStripMenuItem
            // 
            this.波行疏密度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.連續ToolStripMenuItem,
            this.間斷2xToolStripMenuItem,
            this.間斷3xToolStripMenuItem});
            this.波行疏密度ToolStripMenuItem.Name = "波行疏密度ToolStripMenuItem";
            this.波行疏密度ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.波行疏密度ToolStripMenuItem.Text = "波型密度";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "電腦資源監視工具";
            this.notifyIcon1.Visible = true;
            // 
            // 連續ToolStripMenuItem
            // 
            this.連續ToolStripMenuItem.Name = "連續ToolStripMenuItem";
            this.連續ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.連續ToolStripMenuItem.Text = "連續";
            this.連續ToolStripMenuItem.Click += new System.EventHandler(this.連續ToolStripMenuItem_Click);
            // 
            // 間斷2xToolStripMenuItem
            // 
            this.間斷2xToolStripMenuItem.Name = "間斷2xToolStripMenuItem";
            this.間斷2xToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.間斷2xToolStripMenuItem.Text = "間斷 2x";
            this.間斷2xToolStripMenuItem.Click += new System.EventHandler(this.間斷2xToolStripMenuItem_Click);
            // 
            // 間斷3xToolStripMenuItem
            // 
            this.間斷3xToolStripMenuItem.Name = "間斷3xToolStripMenuItem";
            this.間斷3xToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.間斷3xToolStripMenuItem.Text = "間斷 3x";
            this.間斷3xToolStripMenuItem.Click += new System.EventHandler(this.間斷3xToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(206, 105);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "電腦資源監視工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.Form1_ResizeBegin);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 顯示在最上層ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外觀ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 調整大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 無邊框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 波行疏密度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 連續ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 間斷2xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 間斷3xToolStripMenuItem;
    }
}

