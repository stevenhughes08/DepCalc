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
        public double QtyServUnit { get; set; }
        public string QtyCountUnit { get; set; }
        public double QtyCount { get; set; }
        public string PurchUnit { get; set; }
        public string CountUnit { get; set; }
        public string SellUnit { get; set; }
        public string CountFrequency { get; set; }
        public double StandCost { get; set; }
        public object ItemProdInfo => "ID: " + InvItemId + " | " + "Item Name: " +  InvItemName + " | " + QtyServUnit + " " + " per " + CountUnit + "| " + "This item is sold by " +  SellUnit + " " +  QtyServUnit +  " per " +  QtyCountUnit + " " + PurchUnit + "| " + "By Default this item is counted " + CountFrequency;

    }
}