namespace WindowsFormsApplication1
{
    partial class BrisanjeRadnika
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
            this.button1 = new System.Windows.Forms.Button();
            this.PrezimeRadnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImeRadnika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdRradnika = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(88, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obriši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrezimeRadnika
            // 
            this.PrezimeRadnika.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrezimeRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrezimeRadnika.Location = new System.Drawing.Point(120, 108);
            this.PrezimeRadnika.Name = "PrezimeRadnika";
            this.PrezimeRadnika.ReadOnly = true;
            this.PrezimeRadnika.Size = new System.Drawing.Size(130, 23);
            this.PrezimeRadnika.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prezime";
            // 
            // ImeRadnika
            // 
            this.ImeRadnika.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImeRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImeRadnika.Location = new System.Drawing.Point(120, 72);
            this.ImeRadnika.Name = "ImeRadnika";
            this.ImeRadnika.ReadOnly = true;
            this.ImeRadnika.Size = new System.Drawing.Size(130, 23);
            this.ImeRadnika.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(39, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID radnika";
            // 
            // IdRradnika
            // 
            this.IdRradnika.BackColor = System.Drawing.Color.White;
            this.IdRradnika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdRradnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IdRradnika.FormattingEnabled = true;
            this.IdRradnika.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.IdRradnika.Location = new System.Drawing.Point(121, 39);
            this.IdRradnika.Name = "IdRradnika";
            this.IdRradnika.Size = new System.Drawing.Size(129, 24);
            this.IdRradnika.TabIndex = 9;
            this.IdRradnika.SelectedIndexChanged += new System.EventHandler(this.IdRradnika_SelectedIndexChanged);
            // 
            // BrisanjeRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(317, 204);
            this.Controls.Add(this.IdRradnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrezimeRadnika);
            this.Controls.Add(this.ImeRadnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(333, 243);
            this.MinimumSize = new System.Drawing.Size(333, 243);
            this.Name = "BrisanjeRadnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje Radnika";
            this.Load += new System.EventHandler(this.BrisanjeRadnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PrezimeRadnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImeRadnika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IdRradnika;
    }
}