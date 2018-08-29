using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DepCalc.Models
{
    public class ItemSearchViewModel
    {

        //All items to use in search function. 
       [Required]
        public string ItemName { get; set; }
        public int PageNumber { get; set; }
        public int ItemsPerPage { get; set; }
    }
}