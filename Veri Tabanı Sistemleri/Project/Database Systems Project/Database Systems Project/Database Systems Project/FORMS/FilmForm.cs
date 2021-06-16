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
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();
        }
        FilmFonk filmf = new FilmFonk();
        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            string filmismi = tbFilmAdi.Text.Trim();
            string filmsuresi = tbFilmSuresi.Text.Trim();
            string filmturu = tbFilmTuru.Text.Trim();
            if (filmismi == "")
            {
                MessageBox.Show("İsim kısmı boş bırakılmaz!");
                tbFilmAdi.Focus();
                return;
            }
            if (filmsuresi == "")
            {
                MessageBox.Show("Film Süresi kısmı boş bırakılmaz!");
                tbFilmSuresi.Focus();
                return;
            }
            if (filmturu == "")
            {
                MessageBox.Show("Film türü kısmı boş bırakılmaz!");
                tbFilmTuru.Focus();
                return;
            }
            else
            {
                filmf.FilmEkle(filmismi, int.Parse(filmsuresi), filmturu);
                int b = int.Parse(filmf.FilmID(filmismi));
                filmf.IzlenenFilm(int.Parse(ktt_id), b);
                MessageBox.Show("Film Eklendi");
                this.Hide();
            }
        }
        string ktt_id;
        public void userrId(string kull_id)
        {
            ktt_id = kull_id;

        }

        private void FilmForm_Load(object sender, EventArgs e)
        {

        }
    }
}
