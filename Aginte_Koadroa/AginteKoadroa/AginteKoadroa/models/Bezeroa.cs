using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.models
{
public partial class Bezeroa
{
    [Key]
    public string Id { get; set; }
    public string Izena { get; set; }
    public string Helbidea { get; set; }
    public string Telf { get; set; }
    public string Emaila { get; set; }
    public string SaltzaileaID { get; set; }
    //Bezero batek saltzaile bat dauka
    public virtual Saltzailea Saltzailea { get; set; } 
    public virtual List<Salmenta> Salmenta { get; set; }
}
}

