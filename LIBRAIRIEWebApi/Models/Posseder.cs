using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Posseder
    {
        public int Themeid { get; set; }
        public string Bookisbn13 { get; set; }

        public virtual Livre Bookisbn13Navigation { get; set; }
        public virtual Theme Theme { get; set; }
    }
}
