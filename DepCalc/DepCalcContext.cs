using DepCalc.Models;
using System;
using System.Data.Entity;



namespace DepCalc
{
    public class DepCalcContext : DbContext
    {
        public DepCalcContext() : base("name=DepCalcContext") { }
        public virtual DbSet<Item> Items { get; set; }
    }
}
