using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ariketa3
{
    internal class Kontaktua
    {
        public string nan { get; set; }
        public string izena { get; set; }
        public string abizena { get; set; }
        public virtual string email { get; set; }
        public string IzenOsoa { get; set; }
        public virtual string Gorde()
        {
            string mezua = "Kontaktua ondo gorde da";
            return mezua;
        }
    }
}
