using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Database_Systems_Project.CODE_SOURCES
{
    class FilmFonk
    {
        public static string dbp = "Data Source=DESKTOP-84MBG8P;Initial Catalog=TTTProject;Integrated Security=True";
        public int FilmEkle(string FilmIsim,
       int FilmSuresi,
       string FilmTuru)
        {
            string query = string.Format("INSERT INTO filmler(FilmIsmi,FilmSuresi,FilmTuru)" +
                "VALUES ('{0}','{1}','{2}')",
                FilmIsim, FilmSuresi, FilmTuru);
            return DataAccess.ExecuteNonQuery(query);
        }
        public int FilmSil(int FilmId)
        {
            string query = "DELETE FROM filmler WHERE ID = " + FilmId;
            return DataAccess.ExecuteNonQuery(query);
        }
        public int FilmGuncelle(string filmIsim,
           int FilmSuresi,
           string FilmTuru,
           int id)
        {
            string query = string.Format("UPDATE filmler SET  FilmIsmi= '{1}'," + "FilmSuresi='{2}'," + "FilmTuru='{3}'" +
                "WHERE ID='{0}'", id, filmIsim, FilmSuresi, FilmTuru);
            return DataAccess.ExecuteNonQuery(query);
        }
        public DataTable FilmListele(int userrrId)
        {
            string query = "SELECT FilmIsmi,FilmSuresi,FilmTuru,filmler.ID FROM filmler join izlenenfilmler on filmler.ID=izlenenfilmler.FilmID WHERE izlenenfilmler.ID="+userrrId;
            return DataAccess.ExecuteQuery(query);

        }
        public DataTable GetFilmByName(string filmismi)
        {
            string query = string.Format("SELECT * FROM filmler WHERE FilmIsmi LIKE '{0}%'", filmismi);
            return DataAccess.ExecuteQuery(query);
        }
        public string FilmID(string FilmIsmi)
        {
            SqlConnection conn = new SqlConnection(dbp);
            SqlCommand cmd = new SqlCommand("SELECT ID FROM filmler WHERE filmIsmi ='" + FilmIsmi + "'", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            string c_id = dt.Rows[0][0].ToString();
            return c_id;
        }
        public int IzlenenFilm(int userID, int filmID)
        {
            string query = string.Format("INSERT INTO izlenenfilmler(ID,FilmID)" + "VALUES ('{0}','{1}')", userID, filmID);
            return DataAccess.ExecuteNonQuery(query);
        }

    }
}
