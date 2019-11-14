using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Appliquer
    {
        public string Bookisbn13 { get; set; }
        public int Vatid { get; set; }

        public virtual Livre Bookisbn13Navigation { get; set; }
        public virtual Tva Vat { get; set; }
    }
}
