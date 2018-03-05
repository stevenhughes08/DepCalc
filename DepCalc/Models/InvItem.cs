using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepCalc.Models
{
    public class InvItemViewModel
    {
        public int? InvItemId { get; set; }
        public string InvItemName { get; set; }
        public string GenLedger { get; set; }
        public int QtyServUnit { get; set; }
        public int QtyCountUnit { get; set; }
        public string PurchUnit { get; set; }
        public string CountUnit { get; set; }
        public string SellUnit { get; set; }
        public string CountFrequency { get; set; }
        public int StandCost { get; set; }

}