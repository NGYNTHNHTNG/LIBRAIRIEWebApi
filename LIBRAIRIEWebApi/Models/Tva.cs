using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Tva
    {
        public Tva()
        {
            Appliquer = new HashSet<Appliquer>();
        }

        public int Vatid { get; set; }
        public string Vattype { get; set; }
        public double Vattaux { get; set; }

        public virtual ICollection<Appliquer> Appliquer { get; set; }
    }
}
