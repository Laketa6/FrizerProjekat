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
    public partial class DodajKlijenta : Form
    {
        public DodajKlijenta()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO Klijent VALUES('";
            naredba = naredba + tbIme.Text + "','";
            naredba = naredba + tbPrezime.Text + "','";
            naredba = naredba + tbTelefon.Text + "','";
            naredba = naredba + tbPol.Text + "','";
            naredba = naredba + tbDR.Text + "')";
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception graska) { MessageBox.Show(graska.GetType().ToString()); }
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Klijent", veza);
            DataTable tabela = new DataTable();
            da.Fill(tabela);
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbTelefon.Text = "";
            tbPol.Text = "";
            tbDR.Text = "";
        }
    }
}
