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
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }
        RegisterForm rf = new RegisterForm();
        TimeToTvForm ttt = new TimeToTvForm();

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            rf.ShowDialog();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string kid;
            Giris g = new Giris();
            kid = g.KullaniciID(Eusernametext.Text,Epasswordtext.Text);
            if (g.UserGiris(Eusernametext.Text,Epasswordtext.Text))
            {
                MessageBox.Show("Giriş başarılı");
                this.Hide();
                ttt.userid(kid);
                ttt.ShowDialog();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");
            }
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
