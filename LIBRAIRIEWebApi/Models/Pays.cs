using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Pays
    {
        public Pays()
        {
            Adresse = new HashSet<Adresse>();
        }

        public int Countryid { get; set; }
        public string Pays1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public decimal Number { get; set; }

        public virtual ICollection<Adresse> Adresse { get; set; }
    }
}
