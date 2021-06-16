namespace Database_Systems_Project.FORMS
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Rnametext = new System.Windows.Forms.TextBox();
            this.Rlastnametext = new System.Windows.Forms.TextBox();
            this.Rusernametext = new System.Windows.Forms.TextBox();
            this.Rpasswordtext = new System.Windows.Forms.TextBox();
            this.Rregisterbutton = new System.Windows.Forms.Button();
            this.Rcleanbutton = new System.Windows.Forms.Button();
            this.lblHata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "KullanıcıAdı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // Rnametext
            // 
            this.Rnametext.Location = new System.Drawing.Point(428, 101);
            this.Rnametext.Name = "Rnametext";
            this.Rnametext.Size = new System.Drawing.Size(303, 20);
            this.Rnametext.TabIndex = 4;
            this.Rnametext.TextChanged += new System.EventHandler(this.Rnametext_TextChanged);
            // 
            // Rlastnametext
            // 
            this.Rlastnametext.Location = new System.Drawing.Point(428, 149);
            this.Rlastnametext.Name = "Rlastnametext";
            this.Rlastnametext.Size = new System.Drawing.Size(303, 20);
            this.Rlastnametext.TabIndex = 5;
            // 
            // Rusernametext
            // 
            this.Rusernametext.Location = new System.Drawing.Point(428, 196);
            this.Rusernametext.Name = "Rusernametext";
            this.Rusernametext.Size = new System.Drawing.Size(303, 20);
            this.Rusernametext.TabIndex = 6;
            // 
            // Rpasswordtext
            // 
            this.Rpasswordtext.Location = new System.Drawing.Point(428, 249);
            this.Rpasswordtext.Name = "Rpasswordtext";
            this.Rpasswordtext.Size = new System.Drawing.Size(303, 20);
            this.Rpasswordtext.TabIndex = 7;
            // 
            // Rregisterbutton
            // 
            this.Rregisterbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rregisterbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rregisterbutton.Location = new System.Drawing.Point(428, 316);
            this.Rregisterbutton.Name = "Rregisterbutton";
            this.Rregisterbutton.Size = new System.Drawing.Size(100, 45);
            this.Rregisterbutton.TabIndex = 8;
            this.Rregisterbutton.Text = "Kaydol";
            this.Rregisterbutton.UseVisualStyleBackColor = false;
            this.Rregisterbutton.Click += new System.EventHandler(this.Rregisterbutton_Click);
            // 
            // Rcleanbutton
            // 
            this.Rcleanbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcleanbutton.Location = new System.Drawing.Point(631, 316);
            this.Rcleanbutton.Name = "Rcleanbutton";
            this.Rcleanbutton.Size = new System.Drawing.Size(100, 45);
            this.Rcleanbutton.TabIndex = 9;
            this.Rcleanbutton.Text = "Temizle";
            this.Rcleanbutton.UseVisualStyleBackColor = true;
            this.Rcleanbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(545, 415);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 20);
            this.lblHata.TabIndex = 10;
            this.lblHata.Click += new System.EventHandler(this.label5_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(950, 527);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.Rcleanbutton);
            this.Controls.Add(this.Rregisterbutton);
            this.Controls.Add(this.Rpasswordtext);
            this.Controls.Add(this.Rusernametext);
            this.Controls.Add(this.Rlastnametext);
            this.Controls.Add(this.Rnametext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rnametext;
        private System.Windows.Forms.TextBox Rlastnametext;
        private System.Windows.Forms.TextBox Rusernametext;
        private System.Windows.Forms.TextBox Rpasswordtext;
        private System.Windows.Forms.Button Rregisterbutton;
        private System.Windows.Forms.Button Rcleanbutton;
        private System.Windows.Forms.Label lblHata;
    }
}