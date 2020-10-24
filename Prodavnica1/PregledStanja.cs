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
    public partial class PregledStanja : Form
    {
        public PregledStanja()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Artikli.Items.Clear();
            Stanje.Items.Clear();
            Cijena.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();
            
            comand.CommandText = "SELECT * FROM Artikli ORDER BY Šifra;";
            SqlCeDataReader myReader = comand.ExecuteReader();
            while (myReader.Read())
            {
                Artikli.Items.Add(myReader.GetSqlInt32(0) + "." +   myReader.GetString(1));
                Cijena.Items.Add(myReader[3].ToString() + " KM");
                Stanje.Items.Add(myReader[4].ToString() + " " + myReader.GetString(2));
            }
        }
    }
}
