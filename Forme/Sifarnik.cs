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
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter Adapter;
        string imeTABELE;
        public Sifarnik(string tabela)
        {
            imeTABELE = tabela;
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("SELECT * FROM " + imeTABELE, Konekcija.Connect());
            tabela = new DataTable();
            Adapter.Fill(tabela);
            dgSifarnik.DataSource = tabela;
            dgSifarnik.Columns["id"].ReadOnly = true;
        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
            DataTable promena = tabela.GetChanges();
            Adapter.UpdateCommand = new SqlCommandBuilder(Adapter).GetUpdateCommand();
            if (promena != null)
            {
                Adapter.Update(promena);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
