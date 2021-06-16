using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Systems_Project.FORMS
{
    public partial class TimeToTvForm : Form
    {
        public TimeToTvForm()
        {
            InitializeComponent();
        }
        DiziForm df = new DiziForm();
        FilmForm ff = new FilmForm();
        ProfilForm pf = new ProfilForm();
        string k_id;
        public void userid(string ku_id)
        {
            k_id = ku_id;
        }

        private void TimeToTvForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiziEkle_Click(object sender, EventArgs e)
        {
            df.userId(k_id);
            df.ShowDialog();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            ff.userrId(k_id);
            ff.ShowDialog();
        }

        private void btnFavorileriGor_Click(object sender, EventArgs e)
        {
            pf.userrrrId(k_id);
            pf.ShowDialog();
        }
    }
}
