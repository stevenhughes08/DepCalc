namespace DepCalc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DepCalc.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DepCalc.DepCalcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DepCalcContext context)
        {
            context.Items.AddOrUpdate(
                    p => p.ItemId,
                    new Item { ItemId = 1, ItemName = "Chicken ", GenLedger = " 65040011", QtyServUnit = 8, QtyCount = 1, PurchUnit = "HD", CountUnit = "HD", SellUnit = "PC", CountFrequency = "Daily", StandCost = 2.6049 },
                    new Item { ItemId = 2, ItemName = "Chicken - Grilled ", GenLedger = "65040011", QtyServUnit = 8, QtyCount = 1, PurchUnit = "HD", CountUnit = "HD", SellUnit = "PC", CountFrequency = "Daily", StandCost = 3.4787 },
                    new Item { ItemId = 3, ItemName = "K11 Crispy11 Seas ", GenLedger = "65040810", QtyServUnit = 37.44, QtyCount = 16, PurchUnit = "CS", CountUnit = "BG", SellUnit = "OZ", CountFrequency = "Weekly", StandCost = 147.6 },
                    new Item { ItemId = 4, ItemName = "Hoagie Bun ", GenLedger = " 65040825", QtyServUnit = 1, QtyCount = 72, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 21.33 },
                    new Item { ItemId = 5, ItemName = "KFC Sand Wrap ", GenLedger = " 65040865", QtyServUnit = 1, QtyCount = 2000, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 57.39 },
                    new Item { ItemId = 6, ItemName = "Foil Wrap ", GenLedger = " 65040865", QtyServUnit = 1, QtyCount = 3000, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 39 },
                    new Item { ItemId = 7, ItemName = "Superbox ", GenLedger = " 65040865", QtyServUnit = 1, QtyCount = 500, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 40.633 },
                    new Item { ItemId = 8, ItemName = "Apple Turnover ", GenLedger = " 65040860", QtyServUnit = 1, QtyCount = 60, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 14.91 },
                    new Item { ItemId = 9, ItemName = "Carton Big Box ", GenLedger = " 65040865", QtyServUnit = 1, QtyCount = 200, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 33.4284 },
                    new Item { ItemId = 10, ItemName = "Kids Meal Lid ", GenLedger = " 65040865", QtyServUnit = 1, QtyCount = 400, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 83.86 },
                    new Item { ItemId = 11, ItemName = "HOT WINGS ", GenLedger = " 65040072", QtyServUnit = 41, QtyCount = 10, PurchUnit = "CS", CountUnit = "BG", SellUnit = "EA", CountFrequency = "Daily", StandCost = 76.8719 },
                    new Item { ItemId = 12, ItemName = "DIPPING WINGS ", GenLedger = " 65040070", QtyServUnit = 43, QtyCount = 10, PurchUnit = "CS", CountUnit = "BG", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 59.6 },
                    new Item { ItemId = 13, ItemName = "Kids Applesauce ", GenLedger = " 65040800", QtyServUnit = 1, QtyCount = 50, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 19.29 },
                    new Item { ItemId = 14, ItemName = "Boneless Wings ", GenLedger = " 65040070", QtyServUnit = 90, QtyCount = 8, PurchUnit = "CS", CountUnit = "BG", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 73.84 },
                    new Item { ItemId = 15, ItemName = "TB-Shrimp ", GenLedger = " 65040906", QtyServUnit = 24, QtyCount = 64, PurchUnit = "CS", CountUnit = "BG", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 193.2 },
                    new Item { ItemId = 16, ItemName = "Spicy BBQ Sauce ", GenLedger = " 65040800", QtyServUnit = 41.79, QtyCount = 14, PurchUnit = "CS", CountUnit = "BG", SellUnit = "OZ", CountFrequency = "Weekly", StandCost = 33.65 },
                    new Item { ItemId = 17, ItemName = "Canola Oil ", GenLedger = " 65040805", QtyServUnit = 16, QtyCount = 1, PurchUnit = "LB - Pound ", CountUnit = "LB - Pound", SellUnit = "OZ", CountFrequency = "Daily", StandCost = 0.6758 },
                    new Item { ItemId = 18, ItemName = "Hawaiian Buns ", GenLedger = " 65040825", QtyServUnit = 1, QtyCount = 120, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 28.4535 },
                    new Item { ItemId = 19, ItemName = "Breading Flour ", GenLedger = " 65040810", QtyServUnit = 400, QtyCount = 1, PurchUnit = "BG ", CountUnit = "BG", SellUnit = "OZ", CountFrequency = "Weekly", StandCost = 6.7435 },
                    new Item { ItemId = 20, ItemName = "Granola Bars ", GenLedger = " 65040800", QtyServUnit = 1, QtyCount = 435, PurchUnit = "CS", CountUnit = "EA", SellUnit = "EA", CountFrequency = "Weekly", StandCost = 60.9 }
                );
        }

    }
}
