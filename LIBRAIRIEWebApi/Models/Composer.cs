using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Composer
    {
        public int Cartid { get; set; }
        public string Bookisbn13 { get; set; }
        public int Cartbookcount { get; set; }
        public double Cartbookamount { get; set; }
        public double? Cartbookglobalamount { get; set; }

        public virtual Livre Bookisbn13Navigation { get; set; }
        public virtual Panier Cart { get; set; }
    }
}
