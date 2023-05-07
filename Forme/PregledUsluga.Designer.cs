
namespace FrizerProjekat.Forme
{
    partial class PregledUsluga
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
            this.lbIme = new System.Windows.Forms.Label();
            this.cbKljuc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSifarnik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSifarnik
            // 
            this.dgSifarnik.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgSifarnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSifarnik.Location = new System.Drawing.Point(12, 91);
            this.dgSifarnik.Name = "dgSifarnik";
            this.dgSifarnik.Size = new System.Drawing.Size(702, 203);
            this.dgSifarnik.TabIndex = 0;
            this.dgSifarnik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSifarnik_CellContentClick);
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIme.Location = new System.Drawing.Point(205, 48);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(61, 22);
            this.lbIme.TabIndex = 3;
            this.lbIme.Text = "Opcija";
            this.lbIme.Click += new System.EventHandler(this.lblme_Click);
            // 
            // cbKljuc
            // 
            this.cbKljuc.BackColor = System.Drawing.Color.AliceBlue;
            this.cbKljuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKljuc.FormattingEnabled = true;
            this.cbKljuc.Location = new System.Drawing.Point(361, 48);
            this.cbKljuc.Margin = new System.Windows.Forms.Padding(2);
            this.cbKljuc.Name = "cbKljuc";
            this.cbKljuc.Size = new System.Drawing.Size(150, 21);
            this.cbKljuc.TabIndex = 5;
            this.cbKljuc.SelectedIndexChanged += new System.EventHandler(this.cbKljuc_SelectedIndexChanged_1);
            // 
            // PregledUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(899, 457);
            this.Controls.Add(this.cbKljuc);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.dgSifarnik);
            this.Name = "PregledUsluga";
            this.Text = "PregledUsluga";
            this.Load += new System.EventHandler(this.PregledUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSifarnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSifarnik;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.ComboBox cbKljuc;
    }
}