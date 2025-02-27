namespace Perpustakaan_Input
{
    partial class ManagemenPerpustakaan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managemenPerpusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managemenPerpusToolStripMenuItem,
            this.peminjamanBukuToolStripMenuItem,
            this.pengembalianBukuToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // managemenPerpusToolStripMenuItem
            // 
            this.managemenPerpusToolStripMenuItem.Name = "managemenPerpusToolStripMenuItem";
            this.managemenPerpusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.managemenPerpusToolStripMenuItem.Text = "Manajemen Buku";
            this.managemenPerpusToolStripMenuItem.Click += new System.EventHandler(this.managemenPerpusToolStripMenuItem_Click);
            // 
            // peminjamanBukuToolStripMenuItem
            // 
            this.peminjamanBukuToolStripMenuItem.Name = "peminjamanBukuToolStripMenuItem";
            this.peminjamanBukuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peminjamanBukuToolStripMenuItem.Text = "Peminjaman Buku";
            this.peminjamanBukuToolStripMenuItem.Click += new System.EventHandler(this.peminjamanBukuToolStripMenuItem_Click);
            // 
            // pengembalianBukuToolStripMenuItem
            // 
            this.pengembalianBukuToolStripMenuItem.Name = "pengembalianBukuToolStripMenuItem";
            this.pengembalianBukuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pengembalianBukuToolStripMenuItem.Text = "Pengembalian Buku";
            this.pengembalianBukuToolStripMenuItem.Click += new System.EventHandler(this.pengembalianBukuToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangAplikasiToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tentangAplikasiToolStripMenuItem
            // 
            this.tentangAplikasiToolStripMenuItem.Name = "tentangAplikasiToolStripMenuItem";
            this.tentangAplikasiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi";
            this.tentangAplikasiToolStripMenuItem.Click += new System.EventHandler(this.tentangAplikasiToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ManagemenPerpustakaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perpustakaan_Input.Properties.Resources.Cuplikan_layar_2024_10_27_073503;
            this.ClientSize = new System.Drawing.Size(721, 511);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "ManagemenPerpustakaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagemenPerpustakaan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managemenPerpusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangAplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}