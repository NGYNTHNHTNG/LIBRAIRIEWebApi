using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Grille
    {
        public Grille()
        {
            Livre = new HashSet<Livre>();
        }

        public int Gridid { get; set; }
        public int Publisherid { get; set; }
        public string Gridcat { get; set; }
        public double Gridprice { get; set; }

        public virtual Editeur Publisher { get; set; }
        public virtual ICollection<Livre> Livre { get; set; }
    }
}
