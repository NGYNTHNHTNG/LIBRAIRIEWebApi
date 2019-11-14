using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Employes
    {
        public Employes()
        {
            Commentaires = new HashSet<Commentaires>();
        }

        public int Emploginid { get; set; }
        public int Statusid { get; set; }
        public string Emplastname { get; set; }
        public string Empfirstname { get; set; }
        public string Emppassword { get; set; }
        public DateTime? Commentstatusdate { get; set; }
        public string Authornotes { get; set; }
        public DateTime? Commentstatutchangedate { get; set; }
        public string Commentstatutchangecomment { get; set; }
        public DateTime? Statempldate { get; set; }
        public string Statemplcomment { get; set; }
        public string Emplogin { get; set; }

        public virtual ICollection<Commentaires> Commentaires { get; set; }
    }
}
