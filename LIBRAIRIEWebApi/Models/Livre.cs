using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Livre
    {
        public Livre()
        {
            Appliquer = new HashSet<Appliquer>();
            Coecrire = new HashSet<Coecrire>();
            Commentaires = new HashSet<Commentaires>();
            Composer = new HashSet<Composer>();
            Declencher = new HashSet<Declencher>();
            Lier = new HashSet<Lier>();
            Posseder = new HashSet<Posseder>();
        }

        public string Bookisbn13 { get; set; }
        public int Formatid { get; set; }
        public int? Bookvolid { get; set; }
        public int Authorid { get; set; }
        public int Publishercollid { get; set; }
        public int Gridid { get; set; }
        public int Statusid { get; set; }
        public string Booktitle { get; set; }
        public string Booksubtitle { get; set; }
        public string Bookisbn10 { get; set; }
        public byte[] Bookpicture { get; set; }
        public string Bookpaging { get; set; }
        public DateTime Bookreleasedate { get; set; }
        public string Booksynopsis { get; set; }
        public int? Bookavailablestock { get; set; }
        public string Bookseries { get; set; }
        public double Bookprice { get; set; }
        public string Booknotes { get; set; }
        public DateTime? Statbookdate { get; set; }
        public string Statbookcomment { get; set; }

        public virtual Auteur Author { get; set; }
        public virtual Livrevolume Bookvol { get; set; }
        public virtual Format Format { get; set; }
        public virtual Grille Grid { get; set; }
        public virtual Editeurcollection Publishercoll { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Appliquer> Appliquer { get; set; }
        public virtual ICollection<Coecrire> Coecrire { get; set; }
        public virtual ICollection<Commentaires> Commentaires { get; set; }
        public virtual ICollection<Composer> Composer { get; set; }
        public virtual ICollection<Declencher> Declencher { get; set; }
        public virtual ICollection<Lier> Lier { get; set; }
        public virtual ICollection<Posseder> Posseder { get; set; }
    }
}
