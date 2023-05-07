
namespace FrizerProjekat.Forme
{
    partial class GlavnaStrana
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
            this.uslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frizeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviTerminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poFrizerimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poKlijentimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uslugeToolStripMenuItem,
            this.osobeToolStripMenuItem,
            this.terminiToolStripMenuItem,
            this.dodajKlijentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uslugeToolStripMenuItem
            // 
            this.uslugeToolStripMenuItem.Name = "uslugeToolStripMenuItem";
            this.uslugeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.uslugeToolStripMenuItem.Text = "Usluge";
            this.uslugeToolStripMenuItem.Click += new System.EventHandler(this.uslugeToolStripMenuItem_Click);
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frizeriToolStripMenuItem,
            this.klijentiToolStripMenuItem});
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.osobeToolStripMenuItem.Text = "Osobe";
            // 
            // frizeriToolStripMenuItem
            // 
            this.frizeriToolStripMenuItem.Name = "frizeriToolStripMenuItem";
            this.frizeriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frizeriToolStripMenuItem.Text = "Frizeri";
            this.frizeriToolStripMenuItem.Click += new System.EventHandler(this.frizeriToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            this.klijentiToolStripMenuItem.Click += new System.EventHandler(this.klijentiToolStripMenuItem_Click);
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviTerminiToolStripMenuItem,
            this.poFrizerimaToolStripMenuItem,
            this.poKlijentimaToolStripMenuItem});
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.terminiToolStripMenuItem.Text = "Termini";
            // 
            // sviTerminiToolStripMenuItem
            // 
            this.sviTerminiToolStripMenuItem.Name = "sviTerminiToolStripMenuItem";
            this.sviTerminiToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.sviTerminiToolStripMenuItem.Text = "DodajTermin";
            this.sviTerminiToolStripMenuItem.Click += new System.EventHandler(this.sviTerminiToolStripMenuItem_Click);
            // 
            // poFrizerimaToolStripMenuItem
            // 
            this.poFrizerimaToolStripMenuItem.Name = "poFrizerimaToolStripMenuItem";
            this.poFrizerimaToolStripMenuItem.Size = new System.Drawing.Size(212, 32);
            this.poFrizerimaToolStripMenuItem.Text = "PoFrizerima";
            this.poFrizerimaToolStripMenuItem.Click += new System.EventHandler(this.poFrizerimaToolStripMenuItem_Click);
            // 
            // poKlijentimaToolStripMenuItem
            // 
            this.poKlijentimaToolStripMenuItem.Name = "poKlijentimaToolStripMenuItem";
            this.poKlijentimaToolStripMenuItem.Size = new System.Drawing.Size(212, 32);
            this.poKlijentimaToolStripMenuItem.Text = "PoKlijentima";
            this.poKlijentimaToolStripMenuItem.Click += new System.EventHandler(this.poKlijentimaToolStripMenuItem_Click);
            // 
            // dodajKlijentaToolStripMenuItem
            // 
            this.dodajKlijentaToolStripMenuItem.Name = "dodajKlijentaToolStripMenuItem";
            this.dodajKlijentaToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.dodajKlijentaToolStripMenuItem.Text = "DodajKlijenta";
            this.dodajKlijentaToolStripMenuItem.Click += new System.EventHandler(this.dodajKlijentaToolStripMenuItem_Click);
            // 
            // GlavnaStrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaStrana";
            this.Text = "GlavnaStrana";
            this.Load += new System.EventHandler(this.GlavnaStrana_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frizeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviTerminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poFrizerimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poKlijentimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKlijentaToolStripMenuItem;
    }
}