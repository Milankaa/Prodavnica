namespace WindowsFormsApplication1
{
    partial class PromjenaStanja
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
            this.Promjeni = new System.Windows.Forms.Button();
            this.kolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.naziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifra = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Promjeni
            // 
            this.Promjeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Promjeni.Location = new System.Drawing.Point(74, 161);
            this.Promjeni.Name = "Promjeni";
            this.Promjeni.Size = new System.Drawing.Size(105, 29);
            this.Promjeni.TabIndex = 9;
            this.Promjeni.Text = "Dodaj";
            this.Promjeni.UseVisualStyleBackColor = true;
            this.Promjeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // kolicina
            // 
            this.kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolicina.Location = new System.Drawing.Point(129, 109);
            this.kolicina.Name = "kolicina";
            this.kolicina.Size = new System.Drawing.Size(121, 23);
            this.kolicina.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Količina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Šifra artikla";
            // 
            // naziv
            // 
            this.naziv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naziv.Location = new System.Drawing.Point(129, 77);
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            this.naziv.Size = new System.Drawing.Size(121, 23);
            this.naziv.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Naziv artikla";
            // 
            // sifra
            // 
            this.sifra.FormattingEnabled = true;
            this.sifra.Location = new System.Drawing.Point(129, 46);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(121, 21);
            this.sifra.TabIndex = 12;
            this.sifra.SelectedIndexChanged += new System.EventHandler(this.sifra_SelectedIndexChanged);
            // 
            // PromjenaStanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 234);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.Promjeni);
            this.Controls.Add(this.kolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 273);
            this.MinimumSize = new System.Drawing.Size(325, 273);
            this.Name = "PromjenaStanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena stanja";
            this.Load += new System.EventHandler(this.PromjenaStanja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Promjeni;
        private System.Windows.Forms.TextBox kolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sifra;
    }
}