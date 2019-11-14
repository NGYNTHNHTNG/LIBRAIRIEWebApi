using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Lignecmd
    {
        public Lignecmd()
        {
            Commentaires = new HashSet<Commentaires>();
        }

        public int Lineid { get; set; }
        public int Orderid { get; set; }
        public string Bookisbn13 { get; set; }
        public int Customerid { get; set; }
        public double Linequantity { get; set; }
        public double Linepriceht { get; set; }
        public double Linevat { get; set; }
        public bool? Lineactive { get; set; }

        public virtual ICollection<Commentaires> Commentaires { get; set; }
    }
}
