using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Globalization;
namespace WindowsFormsApplication1
{
    public partial class UnosRacuna : Form
    {
        string path = @"..\..\Racuni\Racun.txt";
        double suma = 0.00;
        public UnosRacuna()
        {
            InitializeComponent();
           Datum.Text = DateTime.Today.ToLongDateString();
        }
        private void SacuvajRacun()
        {
            int d = listBox1.Items.Count;
            string[] lines = new string[2 * d + 17];
            lines[0] = "\tONOGOST DOO";
            lines[1] = "\tJovana Cvijica bb";
            lines[2] = "\t  71420 Pale\n";
            lines[3] = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            lines[4] = "MALOPRODAJNI FISKALNI RAČUN";
            lines[5] = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            if (d > 3)
            {
                for (int i = 0; i < 2 * d; i += 2)
                {
                    lines[i + 6] = listBox1.Items[i / 2].ToString();
                    lines[i + 7] = listBox2.Items[i / 2].ToString() + "\t \t" + listBox3.Items[i / 2].ToString();
                }

                lines[2 * d + 7] = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
                lines[2 * d + 8] = "ZA UPLATU: \t \t" + label6.Text + " KM";
                lines[2 * d + 11] = Datum.Text + " - " + Vrijeme.Text;
                lines[2 * d + 9] = "Broj računa : " + brRacuna.Text;
            }
            else
            {
                for (int i = 0; i < 2 * d; i += 2)
                {
                    lines[i + 6] = listBox1.Items[i / 2].ToString();
                    lines[i + 7] = listBox2.Items[i / 2].ToString() + "\t \t " + listBox3.Items[i / 2].ToString();
                }
                for (int i = 0; i < 6 - 2 * d; i++)
                {
                    lines[i + 6 + 2 * d] = " ";

                }
                lines[2 * d + 12] = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
                lines[2 * d + 13] = "ZA UPLATU: \t \t" + label6.Text;
                lines[2 * d + 16] = Datum.Text + " - " + Vrijeme.Text;
                lines[2 * d + 14] = "Broj računa : " + brRacuna.Text;
            }
            File.WriteAllLines(path, lines, Encoding.UTF8);
        }

        private void UnosRacuna_Load(object sender, EventArgs e)
        {
            
            Artikli.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand comand = conn.CreateCommand();
            comand.CommandText = "SELECT * FROM Artikli ORDER BY NazivArtikla;";
            SqlCeDataReader myReader = comand.ExecuteReader();
            while (myReader.Read())
            {
                Artikli.Items.Add(myReader.GetString(1));
            }
            Random random = new Random();
            brRacuna.Text = random.Next(100000, 999999).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Artikli.Text == "")
            {
                MessageBox.Show("Niste unijeli naziv artikla!");
                Artikli.Focus();
                return;
            }
            if (Kolicina.Text == "")
            {
                MessageBox.Show("Niste unijeli količinu!");
                Kolicina.Focus();
                return;
            }
            float f;
            if (!float.TryParse(Kolicina.Text, out f))
            {
                MessageBox.Show("Količina mora biti broj!");
                Kolicina.Focus();
                return;
            }
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();

            SqlCeCommand command = conn.CreateCommand();
           
            command.CommandText = "SELECT * FROM Artikli WHERE NazivArtikla = '" + Artikli.Text + "';";
            SqlCeDataReader myReader = command.ExecuteReader();
             
            while (myReader.Read())
               { 
                string jm = myReader.GetString(2);
                if (jm == "KOM")
                {
                    int i;
                    if (!Int32.TryParse(Kolicina.Text, out i))
                    {
                        MessageBox.Show("Količina mora biti cijeli broj!");
                        Kolicina.Clear();
                        Kolicina.Focus();
                        return;
                    }
                }
            
                double stanje = myReader.GetDouble(4);
                
                if (float.Parse(Kolicina.Text) > stanje)
                {
                    MessageBox.Show("Količina nije na stanju! Na stanju ima: " + stanje + "  " + jm);
                    Kolicina.Clear();
                    Kolicina.Focus();
                    return;
                }
                double cijena = myReader.GetDouble(3);
                float kol = float.Parse(Kolicina.Text);
                double ukupno = cijena * kol;
                suma = suma + ukupno;
                string s = suma.ToString("F2", CultureInfo.CreateSpecificCulture("en-US"));

                label6.Text = s;
                listBox1.Items.Add(Artikli.Text);
                listBox2.Items.Add(Kolicina.Text + "  x  " + cijena.ToString());
                listBox3.Items.Add(ukupno.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")));
            }
            float kolicina = float.Parse(Kolicina.Text);
            SqlCeCommand comand = conn.CreateCommand();
            comand.CommandText = "UPDATE Artikli SET Stanje = Stanje - " + kolicina.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + " WHERE NazivArtikla = '" + Artikli.Text + "';";

            comand.ExecuteNonQuery();

            Kolicina.Clear();
            Artikli.SelectedIndex = -1;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            if (h > 12)
            {
                h -= 12;
            }
            DateTime time = DateTime.Parse(h + ":" + m + ":" + s);
            Vrijeme.Text = time.ToString("hh:mm:ss");
        }

        private void StampanjeRacuna_Click(object sender, EventArgs e)
        {
        
            int d = listBox1.Items.Count;
            if(d==0)
            {
                MessageBox.Show("Niste unijeli ni jedan artikal!");
                Artikli.Focus();
                return;

            }
            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            DateTime date = DateTime.Now;
            String Date1 = date.ToString("yyyy-MM-dd hh:mm:ss");

            command.CommandText = "INSERT INTO Račun (BrojRacuna, Iznos, Datum) VALUES (" + brRacuna.Text + "," + label6.Text + ",'" + Date1 + "');";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception )
            {
                MessageBox.Show("Greška pri unosu računa!");
            }

            SacuvajRacun();
            MessageBox.Show("Sačuvano!");
            suma = 0.00;
            label6.Text = suma.ToString("F2", CultureInfo.CreateSpecificCulture("en-US"));

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            Random random = new Random();
            brRacuna.Text = random.Next(100000, 999999).ToString();
            
        }

        private void UnosRacuna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show(null, "Da li ste sigurni da zelite da izadjete?", "UPOZORENJE", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    string element;
                    double kolicina;
                    int greska;
                    int count = listBox1.Items.Count; 
                    while (count != 0)
                    {
                        element = listBox1.Items[count - 1].ToString();
                        if (Int32.TryParse(listBox2.Items[count - 1].ToString().Substring(0, listBox2.Items[count - 1].ToString().IndexOf(" ")), out greska))
                        {
                            kolicina = double.Parse(listBox2.Items[count - 1].ToString().Substring(0, listBox2.Items[count - 1].ToString().IndexOf(" ")));

                            SqlCeConnection conn = new SqlCeConnection(Naslovna.connString);
                            conn.Open();
                            SqlCeCommand command = conn.CreateCommand();
                            command.CommandText = "UPDATE Artikli SET Stanje = Stanje + " + kolicina + " WHERE NazivArtikla = '" + element + "';";
                            try
                            {
                                command.ExecuteNonQuery();
                            }
                            catch(Exception ee)
                            {
                                MessageBox.Show("" + ee);
                            }
                            listBox2.Items.RemoveAt(count - 1);
                            listBox1.Items.RemoveAt(count - 1);
                            listBox3.Items.RemoveAt(count - 1);
                            count--;
                            
                        }
                        else
                            MessageBox.Show("Greška!");
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
