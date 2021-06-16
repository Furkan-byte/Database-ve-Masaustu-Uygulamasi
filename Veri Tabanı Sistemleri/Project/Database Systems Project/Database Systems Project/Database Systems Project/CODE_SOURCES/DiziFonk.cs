using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Database_Systems_Project.CODE_SOURCES
{
    class DiziFonk
    {
        public static string dbp = "Data Source=DESKTOP-84MBG8P;Initial Catalog=TTTProject;Integrated Security=True";
        public int DiziEkle(string diziIsim,
               int ToplamBolumSayisi,
               int IzlenenBolumSayisi,
               int SezonSayisi,
               string diziTuru)
        {
            string query = string.Format("INSERT INTO diziler(DiziIsim,SezonSayisi,ToplamBolumSayisi,IzlenenBolumSayisi,DiziTuru)" +
                "VALUES ('{0}','{1}','{2}','{3}','{4}')",
                diziIsim, SezonSayisi, ToplamBolumSayisi, IzlenenBolumSayisi, diziTuru);
            return DataAccess.ExecuteNonQuery(query);
        }
        public int DiziSil(int DiziId)
        {
            string query = "DELETE FROM diziler WHERE ID = " + DiziId;
            return DataAccess.ExecuteNonQuery(query);
        }
        public int DiziGuncelle(string diziIsim,
            int id,
            int sezonSayisi,
            int TBS,
            int IBS,
            string diziTuru)
        {
            string query = string.Format("UPDATE diziler SET  DiziIsim= '{1}'," + "SezonSayisi='{2}'," + "ToplamBolumSayisi='{3}'," +
                 "IzlenenBolumSayisi='{4}'," + "DiziTuru='{5}'" + "WHERE ID='{0}'",id , diziIsim, sezonSayisi, TBS, IBS, diziTuru);
            return DataAccess.ExecuteNonQuery(query);
        }
        public DataTable DiziListele(int useId)
        {
            string query = "SELECT DiziIsim,SezonSayisi,ToplamBolumSayisi,IzlenenBolumSayisi,DiziTuru,diziler.ID FROM diziler join izlenendiziler on diziler.ID=izlenendiziler.DiziID WHERE izlenendiziler.ID=" + useId;
            return DataAccess.ExecuteQuery(query);

        }
        public DataTable GetDiziByName(string diziismi)
        {
            string query = string.Format("Select *from diziler WHERE DiziIsim LIKE '{0}%'", diziismi);
            return DataAccess.ExecuteQuery(query);
        }
        public int IzlenenDizi(int userID,int diziID)
        {
            string query = string.Format("INSERT INTO izlenendiziler(ID,DiziID)" + "VALUES ('{0}','{1}')",userID,diziID);
            return DataAccess.ExecuteNonQuery(query);
        }
        public string DiziID(string diziIsmi)
        {
            SqlConnection conn = new SqlConnection(dbp);
            SqlCommand cmd = new SqlCommand("SELECT ID FROM diziler WHERE diziIsim ='" + diziIsmi + "'", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            string b_id = dt.Rows[0][0].ToString();
            return b_id;
        }
    }
}
