using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImenikSQLite
{
    public class razredImenik
    {
        public string ImeImenika{ get; set; }
        public List<razredOseba> seznamOseb { get; set; }
        public int steviloOseb
        {
            get { return seznamOseb.Count(); }
        }
        public razredImenik()
        {
            ImeImenika = ""; 
        }
        public razredImenik(string imeI, List<razredOseba> seznam)
        {
            ImeImenika = imeI; seznamOseb = seznam;
        }
    }
}
