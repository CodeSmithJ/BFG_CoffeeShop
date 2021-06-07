namespace BFG_CoffeeShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigrate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CoffeeOrder", "Barista", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CoffeeOrder", "Barista", c => c.String(nullable: false));
        }
    }
}
