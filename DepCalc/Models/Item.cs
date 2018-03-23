using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace DepCalc.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required, StringLength(8)]
        public string GenLedger { get; set; }
        [Required]
        public double QtyServUnit { get; set; }
        [Required]
        public double QtyCount { get; set; }
        [Required]
        public string PurchUnit { get; set; }
        [Required]
        public string CountUnit { get; set; }
        [Required]
        public string SellUnit { get; set; }
        [Required]
        public string CountFrequency { get; set; }
        [Required]
        public double StandCost { get; set; }
    }
}