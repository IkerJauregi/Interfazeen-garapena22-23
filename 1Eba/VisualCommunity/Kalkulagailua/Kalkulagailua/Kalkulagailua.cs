using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulagailua
{
    internal class Kalkulagailua
    {
        //propietateak
        public float Zenbaki1 { get; set; }
        public float Zenbaki2 { get; set; }
        //eraikitzailea
        public Kalkulagailua(float zenbaki1, float zenbaki2)
        {
            this.Zenbaki1 = zenbaki1;
            this.Zenbaki2 = zenbaki2;
        }

        public Kalkulagailua()
        {
        }

        //metodoak
        public float Gehiketa()
        { return Zenbaki1 + Zenbaki2; }
        public float Kenketa()
        {
            return Zenbaki1 - Zenbaki2;
        }
        public float Zatiketa()
        {
            return Zenbaki1 / Zenbaki2;
        }
        public float Biderketa()
        {
            return Zenbaki1 * Zenbaki2;
        }
    }
}
