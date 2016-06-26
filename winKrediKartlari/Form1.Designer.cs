namespace winKrediKartlari
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bankamatikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartıPlatinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartıGoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartıSilverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartToolStripMenuItem,
            this.toolStripMenuItem1,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kartToolStripMenuItem
            // 
            this.kartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartToolStripMenuItem1});
            this.kartToolStripMenuItem.Name = "kartToolStripMenuItem";
            this.kartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kartToolStripMenuItem.Text = "Yeni";
            // 
            // kartToolStripMenuItem1
            // 
            this.kartToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankamatikToolStripMenuItem,
            this.krediKartıPlatinToolStripMenuItem,
            this.krediKartıGoldToolStripMenuItem,
            this.krediKartıSilverToolStripMenuItem});
            this.kartToolStripMenuItem1.Name = "kartToolStripMenuItem1";
            this.kartToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.kartToolStripMenuItem1.Text = "Kart";
            // 
            // bankamatikToolStripMenuItem
            // 
            this.bankamatikToolStripMenuItem.Name = "bankamatikToolStripMenuItem";
            this.bankamatikToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.bankamatikToolStripMenuItem.Text = "Bankamatik";
            this.bankamatikToolStripMenuItem.Click += new System.EventHandler(this.bankamatikToolStripMenuItem_Click);
            // 
            // krediKartıPlatinToolStripMenuItem
            // 
            this.krediKartıPlatinToolStripMenuItem.Name = "krediKartıPlatinToolStripMenuItem";
            this.krediKartıPlatinToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.krediKartıPlatinToolStripMenuItem.Text = "Kredi Kartı(Platinium)";
            // 
            // krediKartıGoldToolStripMenuItem
            // 
            this.krediKartıGoldToolStripMenuItem.Name = "krediKartıGoldToolStripMenuItem";
            this.krediKartıGoldToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.krediKartıGoldToolStripMenuItem.Text = "Kredi Kartı(Gold)";
            // 
            // krediKartıSilverToolStripMenuItem
            // 
            this.krediKartıSilverToolStripMenuItem.Name = "krediKartıSilverToolStripMenuItem";
            this.krediKartıSilverToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.krediKartıSilverToolStripMenuItem.Text = "Kredi Kartı(Silver)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bankamatikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediKartıPlatinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediKartıGoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediKartıSilverToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

