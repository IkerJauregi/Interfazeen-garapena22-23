using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.models
{
    public partial class Salmenta
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Zenbatekoa { get; set; }
        public string BezeroaID { get; set; }
        //1-1
        public virtual Bezeroa Bezeroa { get; set; }
    }
}
