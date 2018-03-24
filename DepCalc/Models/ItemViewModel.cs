using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepCalc.Models
{

    //This view model represents a single item. 
    public class ItemViewModel
    {
        public int? ItemId { get; set; }
        //[DisplayName("Item Name")]
        public string ItemName { get; set; }
       // [DisplayName("Gen #")]
        public string GenLedger { get; set; }
        //[DisplayName("Amount Served")]
        public double QtyServUnit { get; set; }
        public double QtyCount { get; set; }
       // [DisplayName("Item is purchased by")]
        public string PurchUnit { get; set; }
        public string CountUnit { get; set; }
        public string SellUnit { get; set; }
        public string CountFrequency { get; set; }
        public double StandCost { get; set; }
        public object ItemProdInfo => "ID: " + ItemId + "  " +  ItemName + " | " + QtyServUnit + SellUnit + " per " + QtyCount +  CountUnit + " " + "This is is counted" + CountFrequency + " Standard cost =" + StandCost;
    }
}

