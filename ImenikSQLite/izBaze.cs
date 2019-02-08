using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ImenikSQLite
{
    public class izBaze
    {
        public List<razredOseba> OdpriImenik(razredImenik imenik)
        {
            List<razredOseba> osebe = new List<razredOseba>();
            
            SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
            con.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM osebe WHERE imenik_id=(SELECT id FROM imeniki " +
                    "WHERE imeImenika='" + imenik.ImeImenika + "');", con);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    razredOseba oseba = new razredOseba();
                    oseba.OsebaId = Convert.ToInt32(read["id"]);
                    oseba.Ime = read["ime"].ToString();
                    oseba.Priimek = read["priimek"].ToString();
                    oseba.Naslov = read["naslov"].ToString();
                    oseba.Telefon = read["telefonska_stevilka"].ToString();
                    oseba.Email = read["email"].ToString();
                    oseba.Imenik_ID = Convert.ToInt32(read["imenik_id"]);
                    osebe.Add(oseba);
                }
            }
            con.Close();
            return osebe;
        }
        public void DodajImenik(string ImeImenika)
        {
            SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO imeniki (imeImenika)" +
                    "VALUES ('" + ImeImenika+ "')";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            con.Close();
        }
        public razredOseba vrniOsebo(string ime, string priimek)
        {
            razredOseba oseba = new razredOseba();
            //int id = Convert.ToInt32(splits[0]);
            SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
            con.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM osebe WHERE (ime='" + ime + "') AND (priimek='" +priimek+ "');", con);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    oseba.OsebaId = Convert.ToInt32(read["id"]);
                    oseba.Ime = read["ime"].ToString();
                    oseba.Priimek = read["priimek"].ToString();
                    oseba.Naslov = read["naslov"].ToString();
                    oseba.Telefon = read["telefonska_stevilka"].ToString();
                    oseba.Email = read["email"].ToString();
                    oseba.Imenik_ID = Convert.ToInt32(read["imenik_id"]);
                }
            }
            con.Close();
            return oseba;
        }
        public void izbrisiOsebo(string ime, string priimek)
        {
            /*string[] splits;
            splits = osebaIzImenika.Split('.');*/
            SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "DELETE FROM osebe WHERE (ime='" + ime + "') AND (priimek='"+priimek+"');";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            con.Close();
        }
        public void posodobiOsebo(string ime,string priimek, razredOseba oseba)
        {
            SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE osebe " +
                    "SET ime='" + oseba.Ime + "', priimek='" + oseba.Priimek + "', " +
                    "naslov='" + oseba.Naslov + "', telefonska_stevilka='" + oseba.Telefon + "', " +
                    "email='" + oseba.Email + "' " +
                    "WHERE id=(SELECT id FROM osebe WHERE (ime='"+ime+"') AND (priimek='"+priimek+"'));";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            con.Close();
        }
        public List<razredOseba> SortirajPoPriimku(razredImenik imenik)
        {
            List<razredOseba> osebe = new List<razredOseba>();
            razredOseba oseba = new razredOseba();
            SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
            con.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM osebe WHERE imenik_id=(SELECT id FROM imeniki " +
                    "WHERE imeImenika=" + imenik.ImeImenika + ") ORDER BY priimek DESC;", con);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    oseba.OsebaId = Convert.ToInt32(read["id"]);
                    oseba.Ime = read["ime"].ToString();
                    oseba.Priimek = read["priimek"].ToString();
                    oseba.Naslov = read["naslov"].ToString();
                    oseba.Telefon = read["telefonska_stevilka"].ToString();
                    oseba.Email = read["email"].ToString();
                    oseba.Imenik_ID = Convert.ToInt32(read["imenik_id"]);
                    osebe.Add(oseba);
                }
            }
            con.Close();
            return osebe;
        }
        public List<razredOseba> SortirajPoImenu(razredImenik imenik)
        {
            List<razredOseba> osebe = new List<razredOseba>();
            razredOseba oseba = new razredOseba();
            SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
            con.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM osebe WHERE imenik_id=(SELECT id FROM imeniki " +
                    "WHERE imeImenika=" + imenik.ImeImenika + ") ORDER BY ime DESC;", con);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    oseba.OsebaId = Convert.ToInt32(read["id"]);
                    oseba.Ime = read["ime"].ToString();
                    oseba.Priimek = read["priimek"].ToString();
                    oseba.Naslov = read["naslov"].ToString();
                    oseba.Telefon = read["telefonska_stevilka"].ToString();
                    oseba.Email = read["email"].ToString();
                    oseba.Imenik_ID = Convert.ToInt32(read["imenik_id"]);
                    osebe.Add(oseba);
                }
            }
            con.Close();
            return osebe;
        }
    }
}
