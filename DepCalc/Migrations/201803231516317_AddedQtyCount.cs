namespace DepCalc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedQtyCount : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "QtyCount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "QtyCount", c => c.Int(nullable: false));
        }
    }
}
