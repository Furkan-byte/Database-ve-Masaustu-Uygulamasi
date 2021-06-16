namespace Database_Systems_Project.FORMS
{
    partial class FilmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmForm));
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.tbFilmTuru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFilmSuresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilmAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmEkle.Location = new System.Drawing.Point(421, 257);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFilmEkle.Size = new System.Drawing.Size(136, 50);
            this.btnFilmEkle.TabIndex = 21;
            this.btnFilmEkle.Text = "Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // tbFilmTuru
            // 
            this.tbFilmTuru.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFilmTuru.Location = new System.Drawing.Point(362, 171);
            this.tbFilmTuru.Name = "tbFilmTuru";
            this.tbFilmTuru.Size = new System.Drawing.Size(253, 31);
            this.tbFilmTuru.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(221, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Film Türü";
            // 
            // tbFilmSuresi
            // 
            this.tbFilmSuresi.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFilmSuresi.Location = new System.Drawing.Point(362, 112);
            this.tbFilmSuresi.Name = "tbFilmSuresi";
            this.tbFilmSuresi.Size = new System.Drawing.Size(253, 31);
            this.tbFilmSuresi.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(215, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Film Süresi";
            // 
            // tbFilmAdi
            // 
            this.tbFilmAdi.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFilmAdi.Location = new System.Drawing.Point(362, 56);
            this.tbFilmAdi.Name = "tbFilmAdi";
            this.tbFilmAdi.Size = new System.Drawing.Size(253, 31);
            this.tbFilmAdi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(231, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Film Adı";
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 524);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.tbFilmTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFilmSuresi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilmAdi);
            this.Controls.Add(this.label1);
            this.Name = "FilmForm";
            this.Text = "FilmForm";
            this.Load += new System.EventHandler(this.FilmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.TextBox tbFilmTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFilmSuresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilmAdi;
        private System.Windows.Forms.Label label1;
    }
}