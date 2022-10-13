using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.models
{
    public partial class Saltzailea
    {
        [Key]
        public string Id { get; set; }
        public string Izena { get; set; }
        public string Taldea { get; set; }
        //1:n
        public virtual List<Bezeroa> Bezeroa { get; set; }
    }
}
