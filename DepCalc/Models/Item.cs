using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace DepCalc.Models
{
    public class Item
    {
        public int InvItemId { get; set; }
        public string InvItemName { get; set; }
        public string GenLedger { get; set; }
        public double QtyServUnit { get; set; }
        public string QtyCountUnit { get; set; }
        public double QtyCount { get; set; }
        public string PurchUnit { get; set; }
        public string CountUnit { get; set; }
        public string SellUnit { get; set; }
        public string CountFrequency { get; set; }
        public double StandCost { get; set; }
    }
}