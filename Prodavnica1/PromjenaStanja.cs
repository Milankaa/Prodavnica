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
    public partial class PromjenaStanja : Form
    {
        public PromjenaStanja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f;
            if (sifra.Text == "")
            {
                MessageBox.Show("Niste unijeli šifru artikla!");
                sifra.Focus();
            }
            else if (kolicina.Text == "")
            {
                MessageBox.Show("Niste unijeli količinu!");
                kolicina.Focus();
            }
            else if (!float.TryParse(kolicina.Text, out f))
            {
                MessageBox.Show("Količina mora biti broj!");
            }
            else{
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
              
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();
            comand.CommandText = "SELECT * FROM Artikli WHERE Šifra = " +sifra.Text + "; ";
            
            SqlCeDataReader myReader = comand.ExecuteReader();
            myReader.Read();
            string jm = myReader.GetString(2);
            if (jm == "KOM")
            {
                int i;
                if (!Int32.TryParse(kolicina.Text, out i))
                {
                    MessageBox.Show("Količina mora biti cijeli broj!");
                    kolicina.Clear();
                    kolicina.Focus();
                    return;
                }
            }
            float kol = float.Parse(kolicina.Text);
            comand.CommandText = "UPDATE Artikli SET Stanje = Stanje + " + kol.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + " WHERE Šifra = " + sifra.Text + ";";
            try
            {
                comand.ExecuteNonQuery();
                MessageBox.Show("Uspješno ste promjenili stanje");
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspješan unos!");
            }
           
            kolicina.Clear();
            naziv.Clear();
            sifra.SelectedIndex = -1;
        }
        }

        private void PromjenaStanja_Load(object sender, EventArgs e)
        {
            sifra.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();
            comand.CommandText = "SELECT * FROM Artikli; ";
            SqlCeDataReader myReader = comand.ExecuteReader();
            while (myReader.Read())
            {
                sifra.Items.Add(myReader[0].ToString());
                
            }

        }

        private void sifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sifra.SelectedIndex != -1)
            {
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);

                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();

                comand.CommandText = "SELECT * FROM Artikli WHERE Šifra =" + sifra.Text + ";";
                SqlCeDataReader myReader = comand.ExecuteReader();
                while (myReader.Read())
                {
                    naziv.Text = myReader.GetString(1);
                }
            }
        }
    }
}
