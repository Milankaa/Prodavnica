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
    public partial class StorniranjeRacuna : Form
    {
        public StorniranjeRacuna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Da li ste sigurni da želite obrisati račun?", "Upozorenje", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                if (brojRacuna.Text == "")
                {
                    MessageBox.Show("Niste unijeli broj računa!");
                    brojRacuna.Focus();
                    return;
                }
                SqlCeConnection con = new SqlCeConnection(Naslovna.connString);
                con.Open();
                SqlCeCommand comand = con.CreateCommand();
                comand.CommandText = "DELETE FROM Račun WHERE BrojRacuna = " + brojRacuna.Text + ";";
                comand.ExecuteNonQuery();
                MessageBox.Show("Račun obrisan!");
                brojRacuna.SelectedIndex = -1;
                iznos.Clear();
                datum.Clear();
            }
        }

        private void brojRacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brojRacuna.SelectedIndex != -1)
            {
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();
                comand.CommandText = "SELECT * FROM Račun WHERE BrojRacuna = " + brojRacuna.Text + ";";

                SqlCeDataReader myReader = comand.ExecuteReader();
                myReader.Read();
                iznos.Text = myReader[1].ToString();
                datum.Text = myReader[2].ToString();
            }
        }

        private void UcitajBrojRacuna()
        {
            brojRacuna.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();
            comand.CommandText = "SELECT * FROM Račun; ";
            SqlCeDataReader myReader = comand.ExecuteReader();
            while (myReader.Read())
            {
                brojRacuna.Items.Add(myReader[0].ToString());

            }
        }
        private void StorniranjeRacuna_Load(object sender, EventArgs e)
        {
            UcitajBrojRacuna();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
