using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenbakiak
{
    public class Zenbakiak
    {
        public float zenb { get; set; }
        public float zenb2 { get; set; }
        public float zenb3 { get; set; }
        public float zenb4 { get; set; }

        public Zenbakiak()
        {

        }
        public float eragiketa()
        {
            float emaitza = 0;
            emaitza = (zenb + (2 * zenb2) + (3 * zenb3) + (4 * zenb4)) / 4;
            return emaitza;
        }
    }
}
