using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Declencher
    {
        public string Bookisbn13 { get; set; }
        public int Eventid { get; set; }

        public virtual Livre Bookisbn13Navigation { get; set; }
        public virtual Evenement Event { get; set; }
    }
}
