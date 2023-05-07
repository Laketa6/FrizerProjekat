
namespace FrizerProjekat.Forme
{
    partial class Sifarnik
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
            this.dgSifarnik = new System.Windows.Forms.DataGridView();
            this.Izmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSifarnik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSifarnik
            // 
            this.dgSifarnik.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgSifarnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSifarnik.Location = new System.Drawing.Point(12, 35);
            this.dgSifarnik.Name = "dgSifarnik";
            this.dgSifarnik.Size = new System.Drawing.Size(698, 236);
            this.dgSifarnik.TabIndex = 0;
            this.dgSifarnik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Izmeni
            // 
            this.Izmeni.BackColor = System.Drawing.Color.AliceBlue;
            this.Izmeni.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izmeni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Izmeni.Location = new System.Drawing.Point(319, 277);
            this.Izmeni.Name = "Izmeni";
            this.Izmeni.Size = new System.Drawing.Size(107, 35);
            this.Izmeni.TabIndex = 1;
            this.Izmeni.Text = "Izmeni";
            this.Izmeni.UseVisualStyleBackColor = false;
            this.Izmeni.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // Sifarnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Izmeni);
            this.Controls.Add(this.dgSifarnik);
            this.Name = "Sifarnik";
            this.Text = "Sifarnik";
            this.Load += new System.EventHandler(this.Sifarnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSifarnik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSifarnik;
        private System.Windows.Forms.Button Izmeni;
    }
}