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
    public partial class DiziForm : Form
    {
        public DiziForm()
        {
            InitializeComponent();
        }
        DiziFonk dizif = new DiziFonk();

        private void btnDiziEkle_Click(object sender, EventArgs e)
        {
            string diziIsmi = tbDiziAdi.Text.Trim();
            string Sezonsayisi = tbSezonSayisi.Text.Trim();
            string ToplamBolum = tbTBS.Text.Trim();
            string IzlenenBolum = tbIBS.Text.Trim();
            string diziTuru = tbDiziTuru.Text.Trim();
            if (diziIsmi == "")
            {
                MessageBox.Show("İsim kısmı boş bırakılmaz!");
                tbDiziAdi.Focus();
                return;
            }
            if (Sezonsayisi == "")
            {
                MessageBox.Show("Sezon Sayısı kısmı boş bırakılmaz!");
                tbSezonSayisi.Focus();
                return;
            }
            if (ToplamBolum == "")
            {
                MessageBox.Show("Toplam Bolum Sayısı kısmı boş bırakılmaz!");
               tbTBS.Focus();
                return;
            }
            if (IzlenenBolum == "")
            {
                MessageBox.Show("Izlenen Bolum Sayısı kısmı boş bırakılmaz!");
                tbIBS.Focus();
                return;
            }
            if (diziTuru == "")
            {
                MessageBox.Show("Dizi Türü kısmı boş bırakılmaz!");
                tbDiziTuru.Focus();
                return;
            }
            else
            {
                dizif.DiziEkle(diziIsmi, int.Parse(ToplamBolum), int.Parse(IzlenenBolum), int.Parse(Sezonsayisi), diziTuru);
                int a = int.Parse(dizif.DiziID(diziIsmi));
                dizif.IzlenenDizi(int.Parse(kt_id), a);
                MessageBox.Show("Dizi Eklendi");
                this.Hide();
            }
        }
        string kt_id;
        public void userId(string kul_id)
        {
            kt_id = kul_id;

        }

        private void DiziForm_Load(object sender, EventArgs e)
        {

        }
    }
}
