namespace WindowsFormsApplication1
{
    partial class Naslovna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Naslovna));
            this.RadniciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UnosRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnosArtiklaToolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaStanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledStanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RacuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storniranjeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevniIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodičniIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Datum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.izadji = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prijava = new System.Windows.Forms.Button();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.promjenaCijeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadniciToolStripMenuItem1
            // 
            this.RadniciToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UnosRadnikaToolStripMenuItem,
            this.pregledRadnikaToolStripMenuItem,
            this.brisanjeRadnikaToolStripMenuItem});
            this.RadniciToolStripMenuItem1.Enabled = false;
            this.RadniciToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RadniciToolStripMenuItem1.Name = "RadniciToolStripMenuItem1";
            this.RadniciToolStripMenuItem1.Size = new System.Drawing.Size(73, 25);
            this.RadniciToolStripMenuItem1.Text = "Radnici";
            this.RadniciToolStripMenuItem1.Click += new System.EventHandler(this.RadniciToolStripMenuItem1_Click);
            // 
            // UnosRadnikaToolStripMenuItem
            // 
            this.UnosRadnikaToolStripMenuItem.Name = "UnosRadnikaToolStripMenuItem";
            this.UnosRadnikaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.UnosRadnikaToolStripMenuItem.Text = "Unos Radnika";
            this.UnosRadnikaToolStripMenuItem.Click += new System.EventHandler(this.UnosRadnikaToolStripMenuItem_Click);
            // 
            // pregledRadnikaToolStripMenuItem
            // 
            this.pregledRadnikaToolStripMenuItem.Name = "pregledRadnikaToolStripMenuItem";
            this.pregledRadnikaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.pregledRadnikaToolStripMenuItem.Text = "Pregled Radnika";
            this.pregledRadnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledRadnikaToolStripMenuItem_Click);
            // 
            // brisanjeRadnikaToolStripMenuItem
            // 
            this.brisanjeRadnikaToolStripMenuItem.Name = "brisanjeRadnikaToolStripMenuItem";
            this.brisanjeRadnikaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.brisanjeRadnikaToolStripMenuItem.Text = "Brisanje Radnika";
            this.brisanjeRadnikaToolStripMenuItem.Click += new System.EventHandler(this.brisanjeRadnikaToolStripMenuItem_Click);
            // 
            // ArtikliToolStripMenuItem
            // 
            this.ArtikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UnosArtiklaToolStripComboBox1,
            this.pregledArtikalaToolStripMenuItem,
            this.brisanjeArtiklaToolStripMenuItem,
            this.promjenaCijeneToolStripMenuItem,
            this.stanjeToolStripMenuItem});
            this.ArtikliToolStripMenuItem.Enabled = false;
            this.ArtikliToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ArtikliToolStripMenuItem.Name = "ArtikliToolStripMenuItem";
            this.ArtikliToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.ArtikliToolStripMenuItem.Text = "Artikli";
            this.ArtikliToolStripMenuItem.Click += new System.EventHandler(this.ArtikliToolStripMenuItem_Click);
            // 
            // UnosArtiklaToolStripComboBox1
            // 
            this.UnosArtiklaToolStripComboBox1.Name = "UnosArtiklaToolStripComboBox1";
            this.UnosArtiklaToolStripComboBox1.Size = new System.Drawing.Size(191, 26);
            this.UnosArtiklaToolStripComboBox1.Text = "Unos Artikla";
            this.UnosArtiklaToolStripComboBox1.Click += new System.EventHandler(this.UnosArtiklaToolStripComboBox1_Click);
            // 
            // pregledArtikalaToolStripMenuItem
            // 
            this.pregledArtikalaToolStripMenuItem.Name = "pregledArtikalaToolStripMenuItem";
            this.pregledArtikalaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.pregledArtikalaToolStripMenuItem.Text = "Pregled Artikala";
            this.pregledArtikalaToolStripMenuItem.Click += new System.EventHandler(this.pregledArtikalaToolStripMenuItem_Click);
            // 
            // brisanjeArtiklaToolStripMenuItem
            // 
            this.brisanjeArtiklaToolStripMenuItem.Name = "brisanjeArtiklaToolStripMenuItem";
            this.brisanjeArtiklaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.brisanjeArtiklaToolStripMenuItem.Text = "Brisanje Artikla";
            this.brisanjeArtiklaToolStripMenuItem.Click += new System.EventHandler(this.brisanjeArtiklaToolStripMenuItem_Click);
            // 
            // stanjeToolStripMenuItem
            // 
            this.stanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promjenaStanjaToolStripMenuItem,
            this.pregledStanjaToolStripMenuItem});
            this.stanjeToolStripMenuItem.Name = "stanjeToolStripMenuItem";
            this.stanjeToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.stanjeToolStripMenuItem.Text = "Stanje";
            // 
            // promjenaStanjaToolStripMenuItem
            // 
            this.promjenaStanjaToolStripMenuItem.Name = "promjenaStanjaToolStripMenuItem";
            this.promjenaStanjaToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.promjenaStanjaToolStripMenuItem.Text = "Promjena stanja";
            this.promjenaStanjaToolStripMenuItem.Click += new System.EventHandler(this.promjenaStanjaToolStripMenuItem_Click);
            // 
            // pregledStanjaToolStripMenuItem
            // 
            this.pregledStanjaToolStripMenuItem.Name = "pregledStanjaToolStripMenuItem";
            this.pregledStanjaToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.pregledStanjaToolStripMenuItem.Text = "Pregled stanja";
            this.pregledStanjaToolStripMenuItem.Click += new System.EventHandler(this.pregledStanjaToolStripMenuItem_Click);
            // 
            // RacuniToolStripMenuItem
            // 
            this.RacuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosRačunaToolStripMenuItem,
            this.storniranjeRačunaToolStripMenuItem});
            this.RacuniToolStripMenuItem.Enabled = false;
            this.RacuniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RacuniToolStripMenuItem.Name = "RacuniToolStripMenuItem";
            this.RacuniToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.RacuniToolStripMenuItem.Text = "Računi";
            this.RacuniToolStripMenuItem.Click += new System.EventHandler(this.RacuniToolStripMenuItem_Click);
            // 
            // unosRačunaToolStripMenuItem
            // 
            this.unosRačunaToolStripMenuItem.Name = "unosRačunaToolStripMenuItem";
            this.unosRačunaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.unosRačunaToolStripMenuItem.Text = "Unos računa";
            this.unosRačunaToolStripMenuItem.Click += new System.EventHandler(this.unosRačunaToolStripMenuItem_Click);
            // 
            // storniranjeRačunaToolStripMenuItem
            // 
            this.storniranjeRačunaToolStripMenuItem.Name = "storniranjeRačunaToolStripMenuItem";
            this.storniranjeRačunaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.storniranjeRačunaToolStripMenuItem.Text = "Storniranje računa";
            this.storniranjeRačunaToolStripMenuItem.Click += new System.EventHandler(this.storniranjeRačunaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RadniciToolStripMenuItem1,
            this.ArtikliToolStripMenuItem,
            this.RacuniToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(532, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dnevniIzvještajToolStripMenuItem,
            this.periodičniIzvještajToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Enabled = false;
            this.izvještajiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            this.izvještajiToolStripMenuItem.Click += new System.EventHandler(this.izvještajiToolStripMenuItem_Click);
            // 
            // dnevniIzvještajToolStripMenuItem
            // 
            this.dnevniIzvještajToolStripMenuItem.Name = "dnevniIzvještajToolStripMenuItem";
            this.dnevniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.dnevniIzvještajToolStripMenuItem.Text = "Dnevni  izvještaj";
            this.dnevniIzvještajToolStripMenuItem.Click += new System.EventHandler(this.dnevniIzvještajToolStripMenuItem_Click);
            // 
            // periodičniIzvještajToolStripMenuItem
            // 
            this.periodičniIzvještajToolStripMenuItem.Name = "periodičniIzvještajToolStripMenuItem";
            this.periodičniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.periodičniIzvještajToolStripMenuItem.Text = "Periodični izvještaj";
            this.periodičniIzvještajToolStripMenuItem.Click += new System.EventHandler(this.periodičniIzvještajToolStripMenuItem_Click);
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Datum.Location = new System.Drawing.Point(24, 386);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(58, 25);
            this.Datum.TabIndex = 1;
            this.Datum.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(421, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.Location = new System.Drawing.Point(404, 42);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(101, 26);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Prijavi se";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 334);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.izadji);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prijava);
            this.panel1.Location = new System.Drawing.Point(29, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 203);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // izadji
            // 
            this.izadji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.izadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izadji.Location = new System.Drawing.Point(240, 126);
            this.izadji.Name = "izadji";
            this.izadji.Size = new System.Drawing.Size(75, 33);
            this.izadji.TabIndex = 11;
            this.izadji.Text = "Izađi";
            this.izadji.UseVisualStyleBackColor = false;
            this.izadji.Click += new System.EventHandler(this.izadji_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBox1.Location = new System.Drawing.Point(225, 70);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(185, 23);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(225, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Šifra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(47, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Korisničko ime";
            // 
            // prijava
            // 
            this.prijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijava.Location = new System.Drawing.Point(138, 126);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(75, 33);
            this.prijava.TabIndex = 6;
            this.prijava.Text = "Prijavi se";
            this.prijava.UseVisualStyleBackColor = false;
            this.prijava.Click += new System.EventHandler(this.prijava_Click);
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.Color.White;
            this.Odjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odjava.Location = new System.Drawing.Point(404, 42);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(103, 26);
            this.Odjava.TabIndex = 7;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "Odjavi se";
            this.Odjava.Visible = false;
            this.Odjava.VisitedLinkColor = System.Drawing.Color.Blue;
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // promjenaCijeneToolStripMenuItem
            // 
            this.promjenaCijeneToolStripMenuItem.Name = "promjenaCijeneToolStripMenuItem";
            this.promjenaCijeneToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.promjenaCijeneToolStripMenuItem.Text = "Promjena cijene";
            this.promjenaCijeneToolStripMenuItem.Click += new System.EventHandler(this.promjenaCijeneToolStripMenuItem_Click);
            // 
            // Naslovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 434);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(548, 473);
            this.MinimumSize = new System.Drawing.Size(548, 473);
            this.Name = "Naslovna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodavnica";
            this.Activated += new System.EventHandler(this.Naslovna_Activated);
            this.Load += new System.EventHandler(this.Naslovna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem RadniciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UnosRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArtikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RacuniToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pregledRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaStanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storniranjeRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnosArtiklaToolStripComboBox1;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem pregledStanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnevniIzvještajToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button izadji;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.ToolStripMenuItem periodičniIzvještajToolStripMenuItem;
        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.ToolStripMenuItem promjenaCijeneToolStripMenuItem;


    }
}

