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
    public partial class UnosRadnika : Form
    {
        public UnosRadnika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ImeRadnika.Text == "")
            {
                MessageBox.Show("Niste unijeli ime!");
                ImeRadnika.Focus();
                return;
            }
            else if (PrezimeRadnika.Text == "")
            {
                MessageBox.Show("Niste unijeli prezime!");
                PrezimeRadnika.Focus();
                return;
            }
            else if (sifra.Text == "")
            {
                MessageBox.Show("Niste unijeli šifru!");
                sifra.Focus();
                return;
            }
            else if (sifra2.Text == "")
            {
                MessageBox.Show("Niste potvrdili šifru!");
                sifra2.Focus();
                return;
            }
            else if (sifra2.Text != sifra.Text)
            {
                MessageBox.Show("Neispravna šifra!");
                sifra2.Clear();
                sifra2.Focus();
                return;
            }
            else
            {
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();

                comand.CommandText = "INSERT INTO Zaposleni (Ime,Prezime) VALUES ('" + ImeRadnika.Text + "' , '" + PrezimeRadnika.Text + "');";
                try
                {
                    comand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unos nije uspješan!");
                }
                SqlCeCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO Login(KorisnickoIme, Sifra, NivoPristupa) VALUES ('" + ImeRadnika.Text + "', " + sifra.Text + ", 'Radnik');";
                try
                {
                    comand.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                MessageBox.Show("Usješan unos!");
                ImeRadnika.Clear();
                PrezimeRadnika.Clear();
                sifra.Clear();
                sifra2.Clear();
            }
        }
        private void UnosRadnika_Load(object sender, EventArgs e)
        {

        }

        
    }
}
