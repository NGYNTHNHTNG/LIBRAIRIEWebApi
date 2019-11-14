using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Adresse
    {
        public Adresse()
        {
            CommandeAddressinvoice = new HashSet<Commande>();
            CommandeAddressshipp = new HashSet<Commande>();
            Societe = new HashSet<Societe>();
        }

        public int Addressid { get; set; }
        public int Countryid { get; set; }
        public int? Publisherid { get; set; }
        public int? Customerid { get; set; }
        public int? CliCustomerid { get; set; }
        public string Addressname { get; set; }
        public string Addressnumber { get; set; }
        public string Addressstreettype { get; set; }
        public string Addressstreetname { get; set; }
        public string Addresspostalcode { get; set; }
        public string Addresscity { get; set; }
        public string Addressmore { get; set; }
        public DateTime? Addresschangedate3 { get; set; }
        public DateTime? Addresschangedate2 { get; set; }
        public DateTime? Addressinvoiceendofvaliddate { get; set; }
        public bool? Addressactive { get; set; }

        public virtual Client CliCustomer { get; set; }
        public virtual Pays Country { get; set; }
        public virtual Client Customer { get; set; }
        public virtual Editeur Publisher { get; set; }
        public virtual ICollection<Commande> CommandeAddressinvoice { get; set; }
        public virtual ICollection<Commande> CommandeAddressshipp { get; set; }
        public virtual ICollection<Societe> Societe { get; set; }
    }
}
