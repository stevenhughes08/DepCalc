namespace DepCalc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Items");
            AddColumn("dbo.Items", "ItemId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Items", "ItemName", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "GenLedger", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "PurchUnit", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "CountUnit", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "SellUnit", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "CountFrequency", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Items", "ItemId");
            DropColumn("dbo.Items", "InvItemId");
            DropColumn("dbo.Items", "InvItemName");
            DropColumn("dbo.Items", "QtyCountUnit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "QtyCountUnit", c => c.String());
            AddColumn("dbo.Items", "InvItemName", c => c.String());
            AddColumn("dbo.Items", "InvItemId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Items");
            AlterColumn("dbo.Items", "CountFrequency", c => c.String());
            AlterColumn("dbo.Items", "SellUnit", c => c.String());
            AlterColumn("dbo.Items", "CountUnit", c => c.String());
            AlterColumn("dbo.Items", "PurchUnit", c => c.String());
            AlterColumn("dbo.Items", "GenLedger", c => c.String());
            DropColumn("dbo.Items", "ItemName");
            DropColumn("dbo.Items", "ItemId");
            AddPrimaryKey("dbo.Items", "InvItemId");
        }
    }
}
