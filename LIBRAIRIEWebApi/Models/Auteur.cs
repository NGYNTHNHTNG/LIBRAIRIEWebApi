using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Auteur
    {
        public Auteur()
        {
            Coecrire = new HashSet<Coecrire>();
            Livre = new HashSet<Livre>();
        }

        public int Authorid { get; set; }
        public int Statusid { get; set; }
        public string Authorlastname { get; set; }
        public string Authorfirstname { get; set; }
        public string Authorbio { get; set; }
        public byte[] Authorpicture { get; set; }
        public string Authornotes { get; set; }
        public DateTime? Statauthdate { get; set; }
        public string Statauthcomment { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Coecrire> Coecrire { get; set; }
        public virtual ICollection<Livre> Livre { get; set; }
    }
}
