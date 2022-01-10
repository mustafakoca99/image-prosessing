
namespace WindowsFormsApp1
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
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurEfektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orjinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifiniAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taşımaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grileştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taşıma1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.döndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyDöndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayDöndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.blurEfektToolStripMenuItem,
            this.orjinalToolStripMenuItem,
            this.efektToolStripMenuItem,
            this.taşımaToolStripMenuItem,
            this.döndürToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.programıKapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "kaydet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 322);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // programıKapatToolStripMenuItem
            // 
            this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
            this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programıKapatToolStripMenuItem.Text = "programı kapat";
            this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
            // 
            // blurEfektToolStripMenuItem
            // 
            this.blurEfektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianBlurToolStripMenuItem});
            this.blurEfektToolStripMenuItem.Name = "blurEfektToolStripMenuItem";
            this.blurEfektToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.blurEfektToolStripMenuItem.Text = "blur efekt";
            // 
            // medianBlurToolStripMenuItem
            // 
            this.medianBlurToolStripMenuItem.Name = "medianBlurToolStripMenuItem";
            this.medianBlurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianBlurToolStripMenuItem.Text = "median blur";
            this.medianBlurToolStripMenuItem.Click += new System.EventHandler(this.medianBlurToolStripMenuItem_Click);
            // 
            // orjinalToolStripMenuItem
            // 
            this.orjinalToolStripMenuItem.Name = "orjinalToolStripMenuItem";
            this.orjinalToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.orjinalToolStripMenuItem.Text = "orjinal";
            this.orjinalToolStripMenuItem.Click += new System.EventHandler(this.orjinalToolStripMenuItem_Click);
            // 
            // efektToolStripMenuItem
            // 
            this.efektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negatifiniAlmaToolStripMenuItem,
            this.grileştirmeToolStripMenuItem});
            this.efektToolStripMenuItem.Name = "efektToolStripMenuItem";
            this.efektToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.efektToolStripMenuItem.Text = "efekt";
            // 
            // negatifiniAlmaToolStripMenuItem
            // 
            this.negatifiniAlmaToolStripMenuItem.Name = "negatifiniAlmaToolStripMenuItem";
            this.negatifiniAlmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negatifiniAlmaToolStripMenuItem.Text = "negatifini alma";
            this.negatifiniAlmaToolStripMenuItem.Click += new System.EventHandler(this.negatifiniAlmaToolStripMenuItem_Click);
            // 
            // taşımaToolStripMenuItem
            // 
            this.taşımaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taşıma1ToolStripMenuItem,
            this.eğmeToolStripMenuItem});
            this.taşımaToolStripMenuItem.Name = "taşımaToolStripMenuItem";
            this.taşımaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.taşımaToolStripMenuItem.Text = "taşıma ve eğme";
            // 
            // grileştirmeToolStripMenuItem
            // 
            this.grileştirmeToolStripMenuItem.Name = "grileştirmeToolStripMenuItem";
            this.grileştirmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grileştirmeToolStripMenuItem.Text = "grileştirme";
            this.grileştirmeToolStripMenuItem.Click += new System.EventHandler(this.grileştirmeToolStripMenuItem_Click);
            // 
            // taşıma1ToolStripMenuItem
            // 
            this.taşıma1ToolStripMenuItem.Name = "taşıma1ToolStripMenuItem";
            this.taşıma1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taşıma1ToolStripMenuItem.Text = "taşıma 1";
            this.taşıma1ToolStripMenuItem.Click += new System.EventHandler(this.taşıma1ToolStripMenuItem_Click);
            // 
            // eğmeToolStripMenuItem
            // 
            this.eğmeToolStripMenuItem.Name = "eğmeToolStripMenuItem";
            this.eğmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğmeToolStripMenuItem.Text = "eğme";
            this.eğmeToolStripMenuItem.Click += new System.EventHandler(this.eğmeToolStripMenuItem_Click);
            // 
            // döndürToolStripMenuItem
            // 
            this.döndürToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dikeyDöndürToolStripMenuItem,
            this.yatayDöndürToolStripMenuItem});
            this.döndürToolStripMenuItem.Name = "döndürToolStripMenuItem";
            this.döndürToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.döndürToolStripMenuItem.Text = "döndür";
            // 
            // dikeyDöndürToolStripMenuItem
            // 
            this.dikeyDöndürToolStripMenuItem.Name = "dikeyDöndürToolStripMenuItem";
            this.dikeyDöndürToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dikeyDöndürToolStripMenuItem.Text = "dikey döndür";
            this.dikeyDöndürToolStripMenuItem.Click += new System.EventHandler(this.dikeyDöndürToolStripMenuItem_Click);
            // 
            // yatayDöndürToolStripMenuItem
            // 
            this.yatayDöndürToolStripMenuItem.Name = "yatayDöndürToolStripMenuItem";
            this.yatayDöndürToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yatayDöndürToolStripMenuItem.Text = "yatay döndür";
            this.yatayDöndürToolStripMenuItem.Click += new System.EventHandler(this.yatayDöndürToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurEfektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orjinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifiniAlmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taşımaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grileştirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taşıma1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem döndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyDöndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayDöndürToolStripMenuItem;
    }
}

