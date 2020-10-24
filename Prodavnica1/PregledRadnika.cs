using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PregledRadnika : Form
    {
        public PregledRadnika()
        {
            InitializeComponent();
        }

        private void Radnici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PregledRadnika_Load(object sender, EventArgs e)
        {
            Radnici.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();

            comand.CommandText = "SELECT * FROM Zaposleni;";
            SqlCeDataReader myReader = comand.ExecuteReader();
            while (myReader.Read())
            {
                Radnici.Items.Add(myReader[0].ToString() + "." +  myReader.GetString(1) + "  " + myReader.GetString(2));
            }
        }
    }
}
