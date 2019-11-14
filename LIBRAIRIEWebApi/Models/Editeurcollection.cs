using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Editeurcollection
    {
        public Editeurcollection()
        {
            Livre = new HashSet<Livre>();
        }

        public int Publishercollid { get; set; }
        public int Publisherid { get; set; }
        public string Publishercollname { get; set; }

        public virtual Editeur Publisher { get; set; }
        public virtual ICollection<Livre> Livre { get; set; }
    }
}
