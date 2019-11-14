using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Livrevolume
    {
        public Livrevolume()
        {
            Livre = new HashSet<Livre>();
        }

        public int Bookvolid { get; set; }
        public string Bookvolname { get; set; }
        public int Bookvolquantity { get; set; }

        public virtual ICollection<Livre> Livre { get; set; }
    }
}
