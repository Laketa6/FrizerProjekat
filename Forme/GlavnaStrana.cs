using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrizerProjekat.Forme;


namespace FrizerProjekat.Forme
{
    public partial class GlavnaStrana : Form
    {
        Form trenutnaForma = null;
        public GlavnaStrana()
        {
            InitializeComponent();
        }

        private void GlavnaStrana_Load(object sender, EventArgs e)
        {

        }

        private void zameniFormu(Form novaForma)
        {
            if (trenutnaForma != null)
            {
                trenutnaForma.Close();
                Controls.Remove(trenutnaForma);
            }

            novaForma.TopLevel = false;
            novaForma.FormBorderStyle = FormBorderStyle.None;
            novaForma.Top = 50;
            novaForma.Left = 50;
            Controls.Add(novaForma);
            trenutnaForma = novaForma;
            novaForma.Show();
        }

        private void frizeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Sifarnik("Zaposleni"));
        }

        private void uslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Sifarnik("Usluge"));
        }

        private void klijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Sifarnik("Klijent"));
        }

        private void sviTerminiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Termin());
        }

        private void poFrizerimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new PregledUsluga("Zaposleni"));
        }

        private void poKlijentimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new PregledUsluga("Klijent"));
        }

        private void dodajKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new DodajKlijenta());
        }
    }
}
