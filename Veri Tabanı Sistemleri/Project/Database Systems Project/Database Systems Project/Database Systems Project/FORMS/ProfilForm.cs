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
    public partial class ProfilForm : Form
    {
        public ProfilForm()
        {
            InitializeComponent();
        }
        FilmFonk filmfonk = new FilmFonk();
        DiziFonk dizifonk = new DiziFonk();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProfilForm_Load(object sender, EventArgs e)
        {
            FilmPanosu();
            DiziPanosu();
        }
        public string kut_id;
        public void userrrrId(string kull_id)
        {
            kut_id = kull_id;

        }
        public void FilmPanosu()
        {
            tbFilmAdiView.Text = "";
            tbFilmSuresiView.Text = "";
            tbFilmTuruView.Text = "";
            lblFilmID.Text = "";
            FilmDataView.DataSource = filmfonk.FilmListele(int.Parse(kut_id));
            
        }
        public void DiziPanosu()
        {
            tbDiziAdiView.Text = "";
            tbDiziTuruView.Text = "";
            tbIDBView.Text = "";
            tbTDBView.Text = "";
            tbDiziTuruView.Text = "";
            tbSezonSayisiView.Text = "";
            DiziDataView.DataSource = dizifonk.DiziListele(int.Parse(kut_id));

        }

        private void FilmDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int alan = FilmDataView.SelectedCells[0].RowIndex;
            lblFilmID.Text = FilmDataView.Rows[alan].Cells[3].Value.ToString();
            tbFilmAdiView.Text = FilmDataView.Rows[alan].Cells[0].Value.ToString();
            tbFilmSuresiView.Text = FilmDataView.Rows[alan].Cells[1].Value.ToString();
            tbFilmTuruView.Text = FilmDataView.Rows[alan].Cells[2].Value.ToString();
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            if (lblFilmID.Text == "")
            {
                MessageBox.Show("Kişi seçiniz!");
            }
            else
            {
                if (MessageBox.Show("Bu filmi silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    filmfonk.FilmSil(Convert.ToInt32(lblFilmID.Text));
                    FilmPanosu();
                }
                else
                {
                    FilmPanosu();

                }
            }
        }

        private void btnFilmGuncelle_Click(object sender, EventArgs e)
        {
            if (tbFilmAdiView.Text.Trim() == "" || tbFilmSuresiView.Text.Trim() == "" || tbFilmTuruView.Text.Trim() == "")
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz!");
            }
            else
            {
                if (lblFilmID.Text == "")
                {
                    MessageBox.Show("Kişi seçiniz.");
                }
                else
                {
                    filmfonk.FilmGuncelle(tbFilmAdiView.Text, Convert.ToInt32(tbFilmSuresiView.Text), tbFilmTuruView.Text, Convert.ToInt32(lblFilmID.Text));
                    FilmPanosu();
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDiziAdiView.Text.Trim() == "" || tbDiziTuruView.Text.Trim() == "" || tbIDBView.Text.Trim() == "" ||
                tbTDBView.Text.Trim() == "" || tbSezonSayisiView.Text.Trim() == "")
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz!");
            }
            else
            {
                if (lblDiziID.Text == "")
                {
                    MessageBox.Show("Kişi seçiniz.");
                }
                else
                {
                    dizifonk.DiziGuncelle(tbDiziAdiView.Text, Convert.ToInt32(lblDiziID.Text), Convert.ToInt32(tbSezonSayisiView.Text), 
                        Convert.ToInt32(tbTDBView.Text), Convert.ToInt32(tbIDBView.Text),tbDiziTuruView.Text);
                    DiziPanosu();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblDiziID.Text == "")
            {
                MessageBox.Show("Kişi seçiniz!");
            }
            else
            {
                if (MessageBox.Show("Bu kişiyi silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dizifonk.DiziSil(Convert.ToInt32(lblDiziID.Text));
                    DiziPanosu();
                }
                else
                {
                    DiziPanosu();

                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiziDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DiziDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int alan = DiziDataView.SelectedCells[0].RowIndex;
            tbDiziAdiView.Text = DiziDataView.Rows[alan].Cells[0].Value.ToString();
            tbDiziTuruView.Text = DiziDataView.Rows[alan].Cells[4].Value.ToString();
            tbIDBView.Text = DiziDataView.Rows[alan].Cells[3].Value.ToString();
            lblDiziID.Text = DiziDataView.Rows[alan].Cells[5].Value.ToString();
            tbTDBView.Text = DiziDataView.Rows[alan].Cells[2].Value.ToString();
            tbSezonSayisiView.Text = DiziDataView.Rows[alan].Cells[1].Value.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FilmDataView.DataSource = filmfonk.GetFilmByName(tbFilmSearch.Text);
        }

        private void tbDiziSearch_TextChanged(object sender, EventArgs e)
        {
            DiziDataView.DataSource = dizifonk.GetDiziByName(tbDiziSearch.Text);
        }

        private void FilmDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
