namespace WindowsFormsApplication1
{
    partial class PregledRadnika
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
            this.Radnici = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Radnici
            // 
            this.Radnici.FormattingEnabled = true;
            this.Radnici.Location = new System.Drawing.Point(12, 12);
            this.Radnici.Name = "Radnici";
            this.Radnici.Size = new System.Drawing.Size(333, 329);
            this.Radnici.TabIndex = 0;
            this.Radnici.SelectedIndexChanged += new System.EventHandler(this.Radnici_SelectedIndexChanged);
            // 
            // PregledRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 363);
            this.Controls.Add(this.Radnici);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 402);
            this.MinimumSize = new System.Drawing.Size(373, 402);
            this.Name = "PregledRadnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled radnika";
            this.Load += new System.EventHandler(this.PregledRadnika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Radnici;
    }
}