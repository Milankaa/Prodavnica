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
    public partial class Prijava : Form
    {
        private bool prijavljen = false;
        public Prijava()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Niste unijeli korisničko ime!");
                textBox1.Focus();
                return;
            }
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Niste unijeli šifru!");
                maskedTextBox1.Focus();
                return;
            }
            SqlCeConnection con = new SqlCeConnection(Naslovna.connString);
            con.Open();
            SqlCeCommand comand = con.CreateCommand();
            comand.CommandText = "SELECT * FROM Login WHERE KorisnickoIme = '" + textBox1.Text + " ' and Sifra = '" + maskedTextBox1.Text + "'; ";
            try
            {
                comand.ExecuteNonQuery();
                MessageBox.Show("Uspješno ste se prijavili!");
                prijavljen = true;
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Pogrešno korisničko ime ili šifra!\n" + ee);
            }
            textBox1.Clear();
            maskedTextBox1.Clear();
        }
        public bool Prijavljen()
        {
            return prijavljen;
        }
    }
}
