using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_List
{
    internal class Datuak
    {
        public string Izena { get; set; }
        public Datuak(string izena)
        { this.Izena = izena; }

        public static string DatuenZerrenda(List<Datuak> datuak)
        {
            string mezua = "";
            foreach (Datuak datua in datuak)
            {
                mezua += datua.Izena;
            }
            return mezua;
        }
    }
}

