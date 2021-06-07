namespace BFG_CoffeeShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPriceToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CoffeeOrder", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CoffeeOrder", "TotalPrice", c => c.Double(nullable: false));
        }
    }
}
