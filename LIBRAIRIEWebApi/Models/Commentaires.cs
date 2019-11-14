using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Commentaires
    {
        public int Commentid { get; set; }
        public string Bookisbn13 { get; set; }
        public int LigLineid { get; set; }
        public int Customerid { get; set; }
        public int Statusid { get; set; }
        public int? Emploginid { get; set; }
        public string Commentnotes { get; set; }
        public int? Commenteval { get; set; }
        public DateTime? Commentdate { get; set; }
        public int? Commentyescount { get; set; }
        public int? Commentnocount { get; set; }
        public string Commentipaddress { get; set; }
        public DateTime? Statcommentdate { get; set; }
        public string Statcommentcomment { get; set; }

        public virtual Livre Bookisbn13Navigation { get; set; }
        public virtual Client Customer { get; set; }
        public virtual Employes Emplogin { get; set; }
        public virtual Lignecmd LigLine { get; set; }
        public virtual Status Status { get; set; }
    }
}
