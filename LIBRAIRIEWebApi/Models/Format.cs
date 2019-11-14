using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Format
    {
        public Format()
        {
            Livre = new HashSet<Livre>();
        }

        public int Formatid { get; set; }
        public string Formatname { get; set; }
        public string Formatdesc { get; set; }

        public virtual ICollection<Livre> Livre { get; set; }
    }
}
