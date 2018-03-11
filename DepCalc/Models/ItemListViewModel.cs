using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepCalc.Models
{

    //Represents a list of items. 
    public class ItemListViewModel
    {
        public List<ItemViewModel> Items { get; set; }
        public int TotalItems { get; set; }
    }
}