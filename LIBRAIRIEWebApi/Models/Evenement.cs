using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Evenement
    {
        public Evenement()
        {
            Declencher = new HashSet<Declencher>();
        }

        public int Eventid { get; set; }
        public int Statusid { get; set; }
        public string Eventname { get; set; }
        public DateTime Eventstartingdate { get; set; }
        public DateTime Eventendingdate { get; set; }
        public double Eventdiscount { get; set; }
        public string Eventdescr { get; set; }
        public byte[] Eventpicture { get; set; }
        public string Eventnotes { get; set; }
        public DateTime? Stateventdate { get; set; }
        public string Stateventcomment { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Declencher> Declencher { get; set; }
    }
}
