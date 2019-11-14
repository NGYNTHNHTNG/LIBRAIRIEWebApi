using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Client
    {
        public Client()
        {
            AdresseCliCustomer = new HashSet<Adresse>();
            AdresseCustomer = new HashSet<Adresse>();
            Commande = new HashSet<Commande>();
            Commentaires = new HashSet<Commentaires>();
            Panier = new HashSet<Panier>();
        }

        public int Customerid { get; set; }
        public int Statusid { get; set; }
        public string Customerlastname { get; set; }
        public string Customerfirstname { get; set; }
        public DateTime Customerbirthdate { get; set; }
        public DateTime Customerregistrationdate { get; set; }
        public string Customermail { get; set; }
        public string Customerphone { get; set; }
        public string Customernotes { get; set; }
        public DateTime? Statcustdate { get; set; }
        public string Statcustcomment { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Adresse> AdresseCliCustomer { get; set; }
        public virtual ICollection<Adresse> AdresseCustomer { get; set; }
        public virtual ICollection<Commande> Commande { get; set; }
        public virtual ICollection<Commentaires> Commentaires { get; set; }
        public virtual ICollection<Panier> Panier { get; set; }
    }
}
