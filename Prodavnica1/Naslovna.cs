using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Naslovna : Form
    {
        private int h, m, s;
        public static string connString = @"Data Source=C:\Users\Milanka1\Desktop\Prodavnica1\Prodavnica1\Database1.sdf";
        public Naslovna()
        {
            InitializeComponent();           
        }

        private void UnosRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosRadnika forma = new UnosRadnika();
            forma.Show();
            this.Opacity = 0;
        }

        private void pregledRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledRadnika forma = new PregledRadnika();
            forma.Show();
            this.Opacity = 0;

        }

        private void brisanjeRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrisanjeRadnika forma = new BrisanjeRadnika();
            forma.Show();
            this.Opacity = 0;
        }

        private void UnosArtiklaToolStripComboBox1_Click(object sender, EventArgs e)
        {
            UnosArtikla forma = new UnosArtikla();
            forma.Show();
            this.Opacity = 0;
        }

        private void pregledArtikalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledArtikala forma = new PregledArtikala();
            forma.Show();
            this.Opacity = 0;
        }

        private void brisanjeArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrisanjeArtikala forma = new BrisanjeArtikala();
            forma.Show();
            this.Opacity = 0;
        }

        private void promjenaStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromjenaStanja forma = new PromjenaStanja();
            forma.Show();
            this.Opacity = 0;
        }

        private void unosRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosRacuna forma = new UnosRacuna();
            forma.Show();
            this.Opacity = 0;
        }

        private void storniranjeRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorniranjeRacuna forma = new StorniranjeRacuna();
            forma.Show();
            this.Opacity = 0;
        }

        private void Naslovna_Load(object sender, EventArgs e)
        {
            Datum.Text = DateTime.Today.ToLongDateString();        
        }

        private void Naslovna_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            s = DateTime.Now.Second;

            if (h > 12)
            {
                h -= 12;
            }
            DateTime time = DateTime.Parse(h + ":" + m + ":" + s);
            label1.Text =time.ToString("hh:mm:ss");
        }

        private void pregledStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledStanja forma = new PregledStanja();
            forma.Show();
            this.Opacity = 0;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void prijava_Click(object sender, EventArgs e)
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
            SqlCeConnection con = new SqlCeConnection(connString);
            con.Open();
            SqlCeCommand comand = con.CreateCommand();
            comand.CommandText = "SELECT * FROM Login WHERE KorisnickoIme = '" + textBox1.Text + " ' and Sifra = '" + maskedTextBox1.Text + "'; ";
            SqlCeDataReader myReader = comand.ExecuteReader();
            myReader.Read();
             try
             {
                 string sifra = myReader.GetString(1);
                 string korisnik = myReader.GetString(0);
                 string nivo = myReader.GetString(2); ;
                 if (textBox1.Text == korisnik && maskedTextBox1.Text == sifra)
                 {
                     MessageBox.Show("Uspješno ste se prijavili!");
                     panel1.Visible = false;
                     pictureBox1.Visible = true;
                     ArtikliToolStripMenuItem.Enabled = true;
                     RacuniToolStripMenuItem.Enabled = true;
                     izvještajiToolStripMenuItem.Enabled = true;
                     linkLabel2.Visible = false;
                     Odjava.Visible = true;
                     if (nivo == "Admin")
                     {
                         RadniciToolStripMenuItem1.Enabled = true;
                     }
                 }
             }
             catch (Exception)
             {
                 MessageBox.Show("Pogrešno korisničko ime ili šifra!" );
             }
            textBox1.Clear();
            maskedTextBox1.Clear();
        }

        private void izadji_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox1.Visible = true;
        }

        private void RacuniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ArtikliToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RadniciToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dnevniIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DnevniIzvjestaj forma = new DnevniIzvjestaj();
            forma.Show();
            this.Opacity = 0;
        }

        private void izvještajiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void periodičniIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeriodicniIzvjestaj forma = new PeriodicniIzvjestaj();
            forma.Show();
            this.Opacity = 0;
        }

        private void Odjava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ArtikliToolStripMenuItem.Enabled = false;
            RacuniToolStripMenuItem.Enabled = false;
            izvještajiToolStripMenuItem.Enabled = false;
            RadniciToolStripMenuItem1.Enabled = false;
            linkLabel2.Visible = true;
            Odjava.Visible = false;

        }

        private void promjenaCijeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromjenaCijene forma = new PromjenaCijene();
            forma.Show();
            this.Opacity = 0;
        }

    }
}
