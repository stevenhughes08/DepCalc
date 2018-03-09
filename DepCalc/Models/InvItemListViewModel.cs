using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepCalc.Models
{
    public class InvItemListViewModel
    {
        public List<InvItemViewModel> AllInvItems { get; set; }
        //the intTotalItems will most likely need to be changed once this list view comes to focus. 
        public int TotalInvItems { get; set; }
        public List<InvItemViewModel> InvItems { get; internal set; }
    }
}