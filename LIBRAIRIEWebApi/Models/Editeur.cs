using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Editeur
    {
        public Editeur()
        {
            Adresse = new HashSet<Adresse>();
            Editeurcollection = new HashSet<Editeurcollection>();
            Grille = new HashSet<Grille>();
        }

        public int Publisherid { get; set; }
        public int Statusid { get; set; }
        public string EditeurNom { get; set; }
        public string Publishermail { get; set; }
        public string Publisherphone { get; set; }
        public string Publishernotes { get; set; }
        public DateTime? Stateditdate { get; set; }
        public string Stateditcomment { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Adresse> Adresse { get; set; }
        public virtual ICollection<Editeurcollection> Editeurcollection { get; set; }
        public virtual ICollection<Grille> Grille { get; set; }
    }
}
