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
    public partial class Termin : Form
    {
        DataTable tabela;
        SqlDataAdapter frizer = null, klijent = null, usluga = null;
        SqlConnection veza = null;
        private List<string> vremena = new List<string>();
        public Termin()
        {
            popuniVremena();
            InitializeComponent();
            for (int i = 0; i < vremena.Count; i++)
            {
                cbPocetak.Items.Add(vremena[i]);
                cbZavrsetak.Items.Add(vremena[i]);
            }
            Ucitaj();
            cbKlijent.SelectedIndex = -1;
            cbFrizer.SelectedIndex = -1;
            cbUsluga.SelectedIndex = -1;

        }

        private void popuniVremena()
        {
            for (int i = 10; i < 20; i++)
            {
                vremena.Add(i.ToString("D2") + ":00");
                vremena.Add(i.ToString("D2") + ":15");
                vremena.Add(i.ToString("D2") + ":30");
                vremena.Add(i.ToString("D2") + ":45");
            }
        }

        private void cbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKlijent.SelectedIndex == -1)
                return;
        }

        private void cbFrizer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPocetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbZavrsetak.Items.Clear();
            int pocetak = cbPocetak.SelectedIndex;
            for (int i = pocetak + 1; i < vremena.Count; i++)
            {
                cbZavrsetak.Items.Add(vremena[i]);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbKlijent.SelectedIndex == -1 || cbFrizer.SelectedIndex == -1 || cbUsluga.SelectedIndex == -1
                || cbPocetak.SelectedIndex == -1 || cbZavrsetak.SelectedIndex == -1 ||
                dtDatum.Value == null)
                return;

            string klijent_id = cbKlijent.SelectedValue.ToString();
            string frizer_id = cbFrizer.SelectedValue.ToString();
            string usluga_id = cbUsluga.SelectedValue.ToString();
            string datum = dtDatum.Value.ToString();
            string vreme_pocetka = cbPocetak.Text + ":00";
            string vreme_zavrsetka = cbZavrsetak.Text + ":00";

            StringBuilder Naredba = new StringBuilder("INSERT INTO  Termin (Klijent_id, Zaposleni_id, Usluge_id , datum, vreme_pocetka,vreme_zavrsetka) VALUES (");
            Naredba.Append(klijent_id + ", ");
            Naredba.Append(frizer_id + ", ");
            Naredba.Append(usluga_id + ", '");
            Naredba.Append(datum + "', '");
            Naredba.Append(vreme_pocetka + "', '");
            Naredba.Append(vreme_zavrsetka + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();

                Close();
            }
            catch (Exception GRESKA)
            {
                MessageBox.Show(GRESKA.Message);
            }
        }

        private void tbCena_TextChanged(object sender, EventArgs e)
        {
            string cena = tbCena.Text;
            int rezultat = 0;
            if (!int.TryParse(cena, out rezultat))
                tbCena.Text = "";
        }

        private void cbZavrsetak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbUsluga_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbCena.Text = usluge.Rows[((int)cbUsluga.SelectedValue)-1]["cena"].ToString();
        }

        private void Termin_Load(object sender, EventArgs e)
        {

        }

        DataTable usluge = new DataTable();
        private void Ucitaj()
        {
            veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Termin", veza);


            klijent = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS ime_i_prezime FROM Klijent", veza);
            DataTable klijenti = new DataTable();
            klijent.Fill(klijenti);
            cbKlijent.ValueMember = "id";
            cbKlijent.DisplayMember = "ime_i_prezime";
            cbKlijent.DataSource = klijenti;

            frizer = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS ime_i_prezime FROM Zaposleni", veza);
            DataTable frizeri = new DataTable();
            frizer.Fill(frizeri);
            cbFrizer.ValueMember = "id";
            cbFrizer.DisplayMember = "ime_i_prezime";
            cbFrizer.DataSource = frizeri;

            usluga = new SqlDataAdapter("SELECT id, naziv, trajanje, cena FROM Usluge", veza);
            usluge = new DataTable();
            usluga.Fill(usluge);
            cbUsluga.ValueMember = "id";
            cbUsluga.DisplayMember = "naziv";
            cbUsluga.DataSource = usluge;

            tabela = new DataTable();
            adapter.Fill(tabela);
        }
    }
}
