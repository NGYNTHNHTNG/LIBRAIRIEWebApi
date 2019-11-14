using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Inclure
    {
        public int Themeid { get; set; }
        public int SousThemeid { get; set; }

        public virtual Theme SousTheme { get; set; }
        public virtual Theme Theme { get; set; }
    }
}
