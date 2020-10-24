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
    public partial class BrisanjeRadnika : Form
    {
        public BrisanjeRadnika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Da li ste sigurni da želite obrisati radnika?", "Upozorenje", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);

                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();


                comand.CommandText = "DELETE FROM Zaposleni WHERE ID =" + IdRradnika.Text + "AND Ime ='" + ImeRadnika.Text + "' AND Prezime = '" + PrezimeRadnika.Text + "';";
                try
                {
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Obrisano!");

                }
                catch (Exception ee)
                {
                    MessageBox.Show("Nije moguće obrisati!" + ee.Message);
                }
                ImeRadnika.Clear();
                PrezimeRadnika.Clear();
                IdRradnika.SelectedIndex = -1;

            }
        }
        private void BrisanjeRadnika_Load(object sender, EventArgs e)
        {
            IdRradnika.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);

            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();
            comand.CommandText = "SELECT * FROM Zaposleni; ";
            SqlCeDataReader myReader = comand.ExecuteReader();
            while (myReader.Read())
            {
                IdRradnika.Items.Add(myReader[0].ToString());
            }
        }

        private void IdRradnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdRradnika.SelectedIndex!= -1)
            {
                ImeRadnika.Clear();
                PrezimeRadnika.Clear();
                SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);

                conn.Open();
                SqlCeCommand comand = conn.CreateCommand();

                comand.CommandText = "SELECT * FROM Zaposleni WHERE ID =" + IdRradnika.Text + ";";
                SqlCeDataReader myReader = comand.ExecuteReader();
                while (myReader.Read())
                {
                    ImeRadnika.Text = myReader.GetString(1);
                    PrezimeRadnika.Text = myReader.GetString(2);
                }
            }
        }
    }
}
