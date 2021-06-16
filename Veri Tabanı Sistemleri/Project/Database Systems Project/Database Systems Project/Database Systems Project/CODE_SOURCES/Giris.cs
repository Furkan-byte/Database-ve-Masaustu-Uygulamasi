using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Database_Systems_Project.CODE_SOURCES
{

    class Giris
    {
        public static string dbp = "Data Source=DESKTOP-84MBG8P;Initial Catalog=TTTProject;Integrated Security=True";
        public int Kayit(string isim,string soyisim,string kullaniciAdi,string sifre)
        {
            string query = string.Format("INSERT INTO kullanici(Isim,Soyisim,KullaniciAdi,Sifre)" +
          "VALUES('{0}','{1}','{2}','{3}')",
          isim, soyisim, kullaniciAdi, sifre);
            return DataAccess.ExecuteNonQuery(query);
        }
        public string KullaniciID(string kullaniciAdi, string sifre)
        {
            SqlConnection conn = new SqlConnection(dbp);
            SqlCommand cmd = new SqlCommand("SELECT ID FROM kullanici WHERE KullaniciAdi ='" + kullaniciAdi + "' AND Sifre = '" + sifre + "'", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            string a_id = dt.Rows[0][0].ToString();
            return a_id;
        }

        public bool UserGiris(
        string kullaniciAdi,
        string sifre)
        {

            string query = string.Format("SELECT * FROM kullanici WHERE KullaniciAdi ='" + kullaniciAdi + "' AND Sifre = '" + sifre + "'");
            if (DataAccess.ExecuteReader(query) == true)
            {
                return true;
            }
            else
                return false;

        }

    }
}
