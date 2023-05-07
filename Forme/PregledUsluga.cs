using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrizerProjekat.Forme
{
    public partial class PregledUsluga : Form
    {
        public PregledUsluga()
        {
            InitializeComponent();
        }

        private void PregledUsluga_Load(object sender, EventArgs e)
        {

        }

        SqlConnection veza = null;
        string imeKljuca;
        public PregledUsluga(string kljuc)
        {
            imeKljuca = kljuc;
            InitializeComponent();
            lbIme.Text = kljuc + ":";
            Ucitaj();
        }

        private void Ucitaj()
        {
            veza = Konekcija.Connect();
            SqlDataAdapter kljuc = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS ime_i_prezime FROM " + imeKljuca, veza);

            DataTable kljucevi = new DataTable();
            kljuc.Fill(kljucevi);
            cbKljuc.ValueMember = "id";
            cbKljuc.DisplayMember = "ime_i_prezime";
            cbKljuc.DataSource = kljucevi;
            cbKljuc.SelectedIndex = -1;
        }

        private void cbKljuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbKljuc.SelectedIndex == -1)
            {
                dgSifarnik.DataSource = null;
                return;
            }

            int id = (int)cbKljuc.SelectedValue;
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Termin.id, Termin.datum, Termin.vreme_pocetka,Termin.vreme_zavrsetka, Klijent.ime + ' ' + Klijent.prezime AS Klijent, Zaposleni.ime + ' ' + Zaposleni.prezime AS Zaposleni, Usluge.naziv as Usluge FROM Termin  JOIN Klijent ON Termin.Klijent_id=Klijent.id JOIN Zaposleni ON Termin.Zaposleni_id=Zaposleni.id JOIN Usluge ON Termin.Usluge_id = Usluge.id WHERE " + imeKljuca + "_id=" + id.ToString(), Konekcija.Connect());
            DataTable tabela = new DataTable();
            Adapter.Fill(tabela);
            dgSifarnik.DataSource = tabela;
        }

        private void lblme_Click(object sender, EventArgs e)
        {

        }

        private void dgSifarnik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
