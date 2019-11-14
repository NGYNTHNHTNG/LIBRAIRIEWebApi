using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Motclef
    {
        public Motclef()
        {
            Lier = new HashSet<Lier>();
        }

        public int Keywordid { get; set; }
        public string Keywordname { get; set; }
        public string Keywordcomment { get; set; }

        public virtual ICollection<Lier> Lier { get; set; }
    }
}
