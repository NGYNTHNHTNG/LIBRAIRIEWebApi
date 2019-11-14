using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Status
    {
        public Status()
        {
            Auteur = new HashSet<Auteur>();
            Commande = new HashSet<Commande>();
            Commentaires = new HashSet<Commentaires>();
            Editeur = new HashSet<Editeur>();
            Evenement = new HashSet<Evenement>();
            Livre = new HashSet<Livre>();
            Panier = new HashSet<Panier>();
            Transporteur = new HashSet<Transporteur>();
        }

        public int Statusid { get; set; }
        public string Statusname { get; set; }
        public string StatusDescr { get; set; }

        public virtual ICollection<Auteur> Auteur { get; set; }
        public virtual ICollection<Commande> Commande { get; set; }
        public virtual ICollection<Commentaires> Commentaires { get; set; }
        public virtual ICollection<Editeur> Editeur { get; set; }
        public virtual ICollection<Evenement> Evenement { get; set; }
        public virtual ICollection<Livre> Livre { get; set; }
        public virtual ICollection<Panier> Panier { get; set; }
        public virtual ICollection<Transporteur> Transporteur { get; set; }
    }
}
