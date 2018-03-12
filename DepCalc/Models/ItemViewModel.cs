using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepCalc.Models
{

    //This view model represents a single item. 
    public class ItemViewModel
    {
        public int? InvItemId { get; set; }
        [DisplayName("Item Name")]
        public string InvItemName { get; set; }
        [DisplayName("Gen #")]
        public string GenLedger { get; set; }
        [DisplayName("Amount Served")]
        public double QtyServUnit { get; set; }
        public string QtyCountUnit { get; set; }
        public double QtyCount { get; set; }
        [DisplayName("Item is purchased by")]
        public string PurchUnit { get; set; }
        public string CountUnit { get; set; }
        public string SellUnit { get; set; }
        public string CountFrequency { get; set; }
        public double StandCost { get; set; }
        public object ItemProdInfo => "ID: " + InvItemId + " | " + "Item Name: " + InvItemName + " | " + QtyServUnit + " " + " per " + CountUnit + "| " + "This item is sold by " + SellUnit + " " + QtyServUnit + " per " + QtyCountUnit + " " + PurchUnit + "| " + "By Default this item is counted " + CountFrequency;
    }
}

