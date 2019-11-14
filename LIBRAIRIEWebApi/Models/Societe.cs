using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Societe
    {
        public string Socnom { get; set; }
        public int? Addressid { get; set; }
        public string Socsiret { get; set; }
        public string Socsiren { get; set; }
        public string Socmail { get; set; }
        public string Socphone { get; set; }

        public virtual Adresse Address { get; set; }
    }
}
