namespace Database_Systems_Project.FORMS
{
    partial class TimeToTvForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeToTvForm));
            this.btnDiziEkle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnFavorileriGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiziEkle
            // 
            this.btnDiziEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnDiziEkle.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiziEkle.ForeColor = System.Drawing.Color.Black;
            this.btnDiziEkle.Location = new System.Drawing.Point(173, 269);
            this.btnDiziEkle.Name = "btnDiziEkle";
            this.btnDiziEkle.Size = new System.Drawing.Size(111, 63);
            this.btnDiziEkle.TabIndex = 2;
            this.btnDiziEkle.Text = "Dizi Ekle";
            this.btnDiziEkle.UseVisualStyleBackColor = false;
            this.btnDiziEkle.Click += new System.EventHandler(this.btnDiziEkle_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.Location = new System.Drawing.Point(173, 366);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(111, 63);
            this.btnFilmEkle.TabIndex = 3;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnFavorileriGor
            // 
            this.btnFavorileriGor.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFavorileriGor.Location = new System.Drawing.Point(568, 316);
            this.btnFavorileriGor.Name = "btnFavorileriGor";
            this.btnFavorileriGor.Size = new System.Drawing.Size(111, 63);
            this.btnFavorileriGor.TabIndex = 4;
            this.btnFavorileriGor.Text = "Favorilerimi Gör";
            this.btnFavorileriGor.UseVisualStyleBackColor = true;
            this.btnFavorileriGor.Click += new System.EventHandler(this.btnFavorileriGor_Click);
            // 
            // TimeToTvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 635);
            this.Controls.Add(this.btnFavorileriGor);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnDiziEkle);
            this.Name = "TimeToTvForm";
            this.Text = "TimeToTv";
            this.Load += new System.EventHandler(this.TimeToTvForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDiziEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnFavorileriGor;
    }
}