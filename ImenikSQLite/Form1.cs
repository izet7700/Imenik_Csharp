using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace ImenikSQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public razredImenik izbrani_imenik = new razredImenik();
        private void izberiImenikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                imenikListBox.Items.Clear();
                izBaze odpriIm = new izBaze();
                izbrani_imenik.ImeImenika = izberiImenikComboBox.SelectedItem.ToString();
                izbrani_imenik.seznamOseb = odpriIm.OdpriImenik(izbrani_imenik);
                foreach(razredOseba oseba in izbrani_imenik.seznamOseb)
                {
                    imenikListBox.Items.Add(oseba.Ime+" "+oseba.Priimek+", "+oseba.Naslov
                        +", "+oseba.Telefon+", "+ oseba.Email);
                }
                imenikGroupBox.Visible = true;
            }
            catch { MessageBox.Show("ERROR"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void izberiImenikComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void izberiImenikButton_Click(object sender, EventArgs e)
        {
            
        }

        private void izberiImenikComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                izberiImenikComboBox.Items.Clear();
                SQLiteConnection con = new SQLiteConnection("data source=imenikDB.db");
                con.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM imeniki;", con);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        izberiImenikComboBox.Items.Add(read["imeImenika"]);
                    }
                }
                con.Close();
            }
            catch { MessageBox.Show("Error!"); }
        }

        public void dodajImenikButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dodajImenikTextBox.Text != "")
                {
                    izBaze novi_imenik = new izBaze();
                    novi_imenik.DodajImenik(dodajImenikTextBox.Text);
                    MessageBox.Show("Imenik je dodan!");
                }
                else { MessageBox.Show("Vpišite ime imenika!"); }
            }
            catch { MessageBox.Show("Ni mogoče dodati imenik!"); }
        }

        private void imenikListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajOseboButton_Click(object sender, EventArgs e)
        {
            try
            {
                dodaj_uredi dodaj = new dodaj_uredi(izberiImenikComboBox.SelectedItem.ToString());
                dodaj.Show();
            }
            catch { MessageBox.Show("ERROR!"); }
        }

        private void urediOseboButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] splits;
                splits = imenikListBox.SelectedItem.ToString().Split(',');
                string[] imePri;
                imePri = splits[0].Split(' ');
                string imeOs = imePri[0], priimekOs = imePri[1];
                dodaj_uredi uredi = new dodaj_uredi(imeOs, priimekOs);
                uredi.Show();
                imenikListBox.Items.Clear();
                izBaze odpriIm = new izBaze();
                izbrani_imenik.ImeImenika = izberiImenikComboBox.SelectedItem.ToString();
                izbrani_imenik.seznamOseb = odpriIm.OdpriImenik(izbrani_imenik);
                foreach (razredOseba oseba in izbrani_imenik.seznamOseb)
                {
                    imenikListBox.Items.Add(oseba.Ime + " " + oseba.Priimek + ", " + oseba.Naslov
                        + ", " + oseba.Telefon + ", " + oseba.Email);
                }
            }
            catch { MessageBox.Show("Ni izbrana oseba!"); }
        }

        private void izbrišiOseboButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] splits;
                splits = imenikListBox.SelectedItem.ToString().Split(',');
                string[] imePri;
                imePri = splits[0].Split(' ');
                string imeOs = imePri[0], priimekOs = imePri[1];
                izBaze izbrisi = new izBaze();
                izbrisi.izbrisiOsebo(imeOs, priimekOs);
                MessageBox.Show("Oseba je izbrisana!");
                imenikListBox.Items.Clear();
                izBaze odpriIm = new izBaze();
                izbrani_imenik.ImeImenika = izberiImenikComboBox.SelectedItem.ToString();
                izbrani_imenik.seznamOseb = odpriIm.OdpriImenik(izbrani_imenik);
                foreach (razredOseba oseba in izbrani_imenik.seznamOseb)
                {
                    imenikListBox.Items.Add(oseba.Ime + " " + oseba.Priimek + ", " + oseba.Naslov
                        + ", " + oseba.Telefon + ", " + oseba.Email);
                }

            }
            catch { MessageBox.Show("Oseba ni izbrisana!"); }
        }
    }
}
