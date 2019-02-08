using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImenikSQLite
{
    public partial class dodaj_uredi : Form
    {
        public dodaj_uredi()
        {
            InitializeComponent();
        }
        string imeIme,imeOsebe,priimekOsebe;
        razredOseba oseba = new razredOseba();
        public dodaj_uredi(string ime_imenika)
        {
            imeIme = ime_imenika;
            InitializeComponent();
        }      
        public dodaj_uredi(string ime, string priimek)
        {
            imeOsebe = ime; priimekOsebe = priimek;
            InitializeComponent();
            izBaze izpisiOs = new izBaze();
            oseba=izpisiOs.vrniOsebo(imeOsebe,priimekOsebe);
            if(imeOsebeTextBox.Text=="") imeOsebeTextBox.Text = oseba.Ime;
            priimekOsebeTextBox.Text = oseba.Priimek;
            naslovTextBox.Text = oseba.Naslov;
            telefonTextBox.Text = oseba.Telefon;
            emailTextBox.Text = oseba.Email;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public string ime, priimek, naslov, telefon, email;
        public void shraniButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (oseba.Ime == "")
                {
                    ime = imeOsebeTextBox.Text;
                    priimek = priimekOsebeTextBox.Text;
                    naslov = naslovTextBox.Text;
                    telefon = telefonTextBox.Text;
                    email = emailTextBox.Text;
                    SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
                    con.Open();
                    using (SQLiteCommand com = new SQLiteCommand(con))
                    {
                        com.CommandText = "INSERT INTO osebe (ime, priimek, naslov, telefonska_stevilka, email, imenik_id) " +
                            "VALUES ('" + ime + "','" + priimek + "','" + naslov + "','" + telefon + "', " +
                            "'" + email + "',(SELECT id FROM imeniki WHERE imeImenika='" + imeIme + "')) ;";
                        com.ExecuteNonQuery();
                        com.Dispose();
                    }
                    ime = ""; priimek = ""; naslov = ""; telefon = ""; email = "";
                    MessageBox.Show("Oseba je dodana!");
                    this.Close();
                }
                else
                {
                    oseba.Ime = imeOsebeTextBox.Text;
                    oseba.Priimek = priimekOsebeTextBox.Text;
                    oseba.Naslov = naslovTextBox.Text;
                    oseba.Telefon = telefonTextBox.Text;
                    oseba.Email = emailTextBox.Text;
                    izBaze updateOs = new izBaze();
                    updateOs.posodobiOsebo(imeOsebe, priimekOsebe, oseba);
                    MessageBox.Show("Podatki so shranjeni!");
                    this.Close();
                }
            }
            catch { MessageBox.Show("Ni mogoče shrniti!"); }
        }
    }
}
