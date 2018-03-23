namespace DepCalc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "GenLedger", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "GenLedger", c => c.String(nullable: false, maxLength: 8));
        }
    }
}
