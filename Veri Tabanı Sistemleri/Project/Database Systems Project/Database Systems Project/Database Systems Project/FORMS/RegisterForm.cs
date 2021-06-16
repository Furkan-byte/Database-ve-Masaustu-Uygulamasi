using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Systems_Project.CODE_SOURCES;

namespace Database_Systems_Project.FORMS
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rnametext.Text = "";
            Rlastnametext.Text = "";
            Rusernametext.Text = "";
            Rpasswordtext.Text = "";
        }

        private void Rregisterbutton_Click(object sender, EventArgs e)
        {
            lblHata.Text = "";
            Giris g = new Giris();
            string isim = Rnametext.Text.Trim();
            string soyisim = Rlastnametext.Text.Trim();
            string kullaniciadi = Rusernametext.Text.Trim();
            string sifre = Rpasswordtext.Text.Trim();
            if (isim == "")
            {
                lblHata.Text = "İsim kısmı boş bırakılmaz!";
                Rnametext.Focus();
                return;
            }
            if (soyisim == "")
            {
                lblHata.Text = "Soyisim kısmı boş bırakılmaz!";
                Rlastnametext.Focus();
                return;
            }
            if (kullaniciadi == "")
            {
                lblHata.Text = "Kullanıcı Adı kısmı boş bırakılmaz!";
                Rusernametext.Focus();
                return;
            }
            if (sifre == "")
            {
                lblHata.Text = "Şifre kısmı boş bırakılmaz!";
                Rpasswordtext.Focus();
                return;
            }
            var result = g.Kayit(isim, soyisim, kullaniciadi, sifre);
            if (result > 0)
            {
                MessageBox.Show("Kayıt Başarılı :)");
                this.Hide();



            }
            else
            {
                lblHata.Text = "Kayıt Başarısız!!!";
            }
        }

        private void Rnametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
