using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Transporteur
    {
        public Transporteur()
        {
            Commande = new HashSet<Commande>();
        }

        public int Shippingid { get; set; }
        public int Statusid { get; set; }
        public double Shippingfees { get; set; }
        public string Shippingcarriername { get; set; }
        public byte[] Shippingcarrierlogo { get; set; }
        public string Shippingcarriermail { get; set; }
        public string Shippingcarrierphone { get; set; }
        public string Shippingnotes { get; set; }
        public DateTime? Statshippdate { get; set; }
        public string Statshippcomment { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Commande> Commande { get; set; }
    }
}
