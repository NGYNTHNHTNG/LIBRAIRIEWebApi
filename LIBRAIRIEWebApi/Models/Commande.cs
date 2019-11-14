using System;
using System.Collections.Generic;

namespace LIBRAIRIEWebApi.Models
{
    public partial class Commande
    {
        public int Orderid { get; set; }
        public int Customerid { get; set; }
        public int Addressinvoiceid { get; set; }
        public int Addressshippid { get; set; }
        public int Statusid { get; set; }
        public int Shippingid { get; set; }
        public DateTime Orderdate { get; set; }
        public double? Orderglobalamount { get; set; }
        public double Ordershippingfees { get; set; }
        public DateTime? Ordershippingdate { get; set; }
        public int? Orderpaymentcount { get; set; }
        public double? Orderpaymentamount { get; set; }
        public DateTime? Orderpaymentdate { get; set; }
        public string Ordercustomeripaddress { get; set; }
        public string Ordernotes { get; set; }
        public string Ordershippnumber { get; set; }
        public string Ordershippstat { get; set; }
        public DateTime? Statorderdate { get; set; }
        public string Statordercomment { get; set; }

        public virtual Adresse Addressinvoice { get; set; }
        public virtual Adresse Addressshipp { get; set; }
        public virtual Client Customer { get; set; }
        public virtual Transporteur Shipping { get; set; }
        public virtual Status Status { get; set; }
    }
}
