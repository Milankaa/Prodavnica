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
    public partial class UnosArtikla : Form
    {
        public UnosArtikla()
        {
            InitializeComponent();
        }

       
        private void UnosArtikla_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float c;
            if (NazivArtikla.Text == "")
            {
                MessageBox.Show("Niste unijeli naziv artikla!");
                NazivArtikla.Focus();
                return;
            }
            else if (Cijena.Text == "")
            {
                MessageBox.Show("Niste unijeli cijenu!");
                Cijena.Focus();
                return;


            }
            else if (!float.TryParse(Cijena.Text, out c))
            {
                MessageBox.Show("Cijena mora biti broj!");
                Cijena.Focus();
                return;
            }

            else if (JedinicaMjere.Text == "")
            {
                MessageBox.Show("Niste izbrali jedinicu mjere!");
                JedinicaMjere.Focus();
                return;
            }
            else if (Kolicina.Text == "")
            {
                MessageBox.Show("Niste unijeli količinu!");
                Kolicina.Focus();
                return;
            }

            else if (!float.TryParse(Kolicina.Text, out c))
            {
                MessageBox.Show("Količina mora biti broj!");
                Kolicina.Focus();
                return;
            }
            else
            {          
                if (JedinicaMjere.Text == "KOM")
                {
                    int i;
                    if (!Int32.TryParse(Kolicina.Text, out i))
                    {
                        MessageBox.Show("Količina mora biti cijeli broj!");
                        Kolicina.Clear();
                        Kolicina.Focus();
                        return;
                    }
                }
                float cijena = float.Parse(Cijena.Text);
                float kol = float.Parse(Kolicina.Text);
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();
                comand.CommandText = "INSERT INTO Artikli (NazivArtikla,JedinicaMjere, Cijena,  Stanje) VALUES ('" + NazivArtikla.Text + "','" + JedinicaMjere.Text + "'," + cijena.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + "," + kol.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + ");";
                try
                {
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Usješan unos!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Neuspješan unos!");
                }
                NazivArtikla.Clear();
                JedinicaMjere.SelectedIndex = -1;
                Cijena.Clear();
                Kolicina.Clear();
                NazivArtikla.Focus();
            }
        }
        private void Cijena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}

