using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PregledArtikala : Form
    {
        public PregledArtikala()
        {
            InitializeComponent();
        }

        private void PregledArtikala_Load(object sender, EventArgs e)
        {
            Artikli.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();

            comand.CommandText = "SELECT * FROM Artikli ORDER BY Šifra;";
            SqlCeDataReader myReader = comand.ExecuteReader();
            while (myReader.Read())
            {
                Artikli.Items.Add(myReader.GetSqlInt32(0) + ".\t " +  myReader.GetString(1));
            }
        }
    }
}
