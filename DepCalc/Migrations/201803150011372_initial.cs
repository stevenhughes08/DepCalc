namespace DepCalc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        InvItemId = c.Int(nullable: false, identity: true),
                        InvItemName = c.String(),
                        GenLedger = c.String(),
                        QtyServUnit = c.Double(nullable: false),
                        QtyCountUnit = c.String(),
                        QtyCount = c.Double(nullable: false),
                        PurchUnit = c.String(),
                        CountUnit = c.String(),
                        SellUnit = c.String(),
                        CountFrequency = c.String(),
                        StandCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.InvItemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
