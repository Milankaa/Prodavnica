using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class PromjenaCijene : Form
    {
        public PromjenaCijene()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float c;
            if (Sifra.Text == "")
            {
                MessageBox.Show("Niste unijeli šifru artikla!");
                Sifra.Focus();
                return;
            }
            else if (Cijena.Text == "")
            {
                MessageBox.Show("Niste unijeli cijenu artikla!");
                Cijena.Focus();
                return;
            }
            else if (!float.TryParse(Cijena.Text, out c))
            {
                MessageBox.Show("Cijena mora biti broj!");
                Cijena.Focus();
                return;
            }
            else
            {
                float cijena = float.Parse(Cijena.Text);
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();

                comand.CommandText = "UPDATE Artikli SET Cijena = " + cijena.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) +" WHERE Šifra =" + Sifra.Text + ";";
                try
                {
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Uspješno ste promjenili cijenu!");
                }
                catch (Exception )
                {
                    MessageBox.Show("Nije moguće promjeniti cijenu!");
                }
                Cijena.Clear();
                Sifra.SelectedIndex = -1;
                textBox1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
            if (Sifra.SelectedIndex != -1)
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
