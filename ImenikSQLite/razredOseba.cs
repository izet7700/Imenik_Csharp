using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImenikSQLite
{
    public class razredOseba
    {
        public int OsebaId { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public int Imenik_ID { get; set; }
        public string Naslov { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public razredOseba()
        {
            OsebaId = 0; Ime = ""; Priimek = ""; Naslov = ""; Telefon = ""; Email = ""; Imenik_ID = 0;
        }
        public razredOseba(int id, string ime, string priimek, int imenik)
        {
            OsebaId = id; Ime = ime; Priimek = priimek; Imenik_ID = imenik;
        }
        public razredOseba(int id, string ime, string priimek, string naslov, string telefon, string email, int imenik)
        {
            OsebaId = id; Ime = ime; Priimek = priimek; Naslov = naslov; Telefon = telefon; Email = email; Imenik_ID = imenik;
        }
    }
}
