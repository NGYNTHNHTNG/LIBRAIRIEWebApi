using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Panier
    {
        public Panier()
        {
            Composer = new HashSet<Composer>();
        }

        public int Cartid { get; set; }
        public int Customerid { get; set; }
        public int Statusid { get; set; }
        public string Cartname { get; set; }
        public DateTime Cartdate { get; set; }
        public DateTime? Statcartdate { get; set; }
        public string Statcartcomment { get; set; }

        public virtual Client Customer { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Composer> Composer { get; set; }
    }
}
