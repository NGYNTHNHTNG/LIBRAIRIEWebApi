using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Lier
    {
        public int Keywordid { get; set; }
        public string Bookisbn13 { get; set; }

        public virtual Livre Bookisbn13Navigation { get; set; }
        public virtual Motclef Keyword { get; set; }
    }
}
