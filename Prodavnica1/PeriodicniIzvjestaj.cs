using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PeriodicniIzvjestaj : Form
    {
        DateTime datum1;
        DateTime datum2;
        string datum22;
        string datum11;

        public PeriodicniIzvjestaj()
        {
            InitializeComponent();
        }

        private void PeriodicniIzvjestaj_Load(object sender, EventArgs e)
        {
           textBox1.Text = "Izvještaj za period :" ;
           datum1 = DateTime.Parse(dateTimePicker1.Text);
           datum2 = DateTime.Parse(dateTimePicker2.Text);
           datum11 = datum1.Date.ToString("yyyy-MM-dd");
           datum22 = datum2.Date.ToString("yyyy-MM-dd");
           textBox2.Text = dateTimePicker1.Text + " do: ";
           textBox3.Text = "   " + dateTimePicker2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Text + " do: " ;
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text ="   " +  dateTimePicker2.Text;
         }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            datum1 = DateTime.Parse(dateTimePicker1.Text);
            datum2 = DateTime.Parse(dateTimePicker2.Text);
            datum11 = datum1.Date.ToString("yyyy-MM-dd");
            datum22 = datum2.Date.ToString("yyyy-MM-dd");
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();

            comand.CommandText = "SELECT SUM(Iznos) FROM Račun WHERE Datum BETWEEN '" + datum11 + "' AND '" + datum22 + "' ;";
            try
            {
                SqlCeDataReader myReader = comand.ExecuteReader();
                myReader.Read();
                string promet = myReader[0].ToString();
                listBox1.Items.Add("Ostvareni promet :\t " + promet + " KM");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            comand.CommandText = "SELECT COUNT (BrojRacuna)FROM Račun WHERE Datum BETWEEN '" + datum11 + "' AND '" + datum22 + "' ;";
            try
            {
                SqlCeDataReader myReader = comand.ExecuteReader();
                myReader.Read();
                string brRac = myReader[0].ToString();
                listBox1.Items.Add("Izdato računa : \t" + brRac);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
