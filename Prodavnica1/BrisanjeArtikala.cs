using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace WindowsFormsApplication1
{
    public partial class BrisanjeArtikala : Form
    {
        public BrisanjeArtikala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sifra.Text == "")
            {
                MessageBox.Show("Niste unijeli šifru artikla!");
                Sifra.Focus();
                return;
            }
            DialogResult result = MessageBox.Show(null, "Da li ste sigurni da želite obrisati račun?", "Upozorenje", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();

                comand.CommandText = "DELETE FROM Artikli WHERE Šifra =" + Sifra.Text + ";";
                try
                {
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Obrisano!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nije moguće obrisati artikal!" );
                }
                Sifra.SelectedIndex = -1;
                textBox1.Clear();
            }
        }
        private void BrisanjeArtikala_Load(object sender, EventArgs e)
        {
            Sifra.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();
            comand.CommandText = "SELECT * FROM Artikli; ";
            SqlCeDataReader myReader = comand.ExecuteReader();
            while (myReader.Read())
            {
                Sifra.Items.Add(myReader[0].ToString());
            }          
        }

        private void Sifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sifra.SelectedIndex !=-1)
            {
                textBox1.Clear();

                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();

                comand.CommandText = "SELECT * FROM Artikli WHERE Šifra =" + Sifra.Text + ";";
                SqlCeDataReader myReader = comand.ExecuteReader();
                while (myReader.Read())
                {
                    textBox1.Text = myReader.GetString(1);
                }
            }
        }
    }
}
