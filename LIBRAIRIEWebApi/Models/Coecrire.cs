using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Coecrire
    {
        public int Authorid { get; set; }
        public string Bookisbn13 { get; set; }

        public virtual Auteur Author { get; set; }
        public virtual Livre Bookisbn13Navigation { get; set; }
    }
}
