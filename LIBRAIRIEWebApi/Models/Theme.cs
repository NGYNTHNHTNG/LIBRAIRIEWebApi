using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Theme
    {
        public Theme()
        {
            InclureSousTheme = new HashSet<Inclure>();
            InclureTheme = new HashSet<Inclure>();
            Posseder = new HashSet<Posseder>();
        }

        public int Themeid { get; set; }
        public string Themename { get; set; }
        public string Themedesc { get; set; }

        public virtual ICollection<Inclure> InclureSousTheme { get; set; }
        public virtual ICollection<Inclure> InclureTheme { get; set; }
        public virtual ICollection<Posseder> Posseder { get; set; }
    }
}
