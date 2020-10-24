using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DnevniIzvjestaj : Form
    {
        public DnevniIzvjestaj()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void DnevniIzvjestaj_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DateTime datum = DateTime.Now;
            listBox1.Items.Add("Dnevni izvještaj za dan :");
            listBox1.Items.Add(datum.ToString("dd/MM/yyyy"));
            listBox1.Items.Add("Dnevna Prodaja : ");
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();

            comand.CommandText = "SELECT SUM(Iznos) FROM Račun WHERE DATEPART(year, Datum) =" + datum.Year + "AND DATEPART(month, Datum) =" + datum.Month + "AND DATEPART(day, Datum) =" + datum.Day + ";";
            try
            {
                SqlCeDataReader myReader = comand.ExecuteReader();
                myReader.Read();
                string prodaja = myReader[0].ToString();
                listBox1.Items.Add(prodaja + " KM");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            comand.CommandText = "SELECT COUNT (BrojRacuna)FROM Račun WHERE DATEPART(year, Datum) =" + datum.Year + "AND DATEPART(month, Datum) =" + datum.Month + "AND DATEPART(day, Datum) =" + datum.Day + ";";
            try
            {
                SqlCeDataReader myReader = comand.ExecuteReader();
                myReader.Read();
                string brRac = myReader[0].ToString();
                listBox1.Items.Add("Izdato računa : " + brRac);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
