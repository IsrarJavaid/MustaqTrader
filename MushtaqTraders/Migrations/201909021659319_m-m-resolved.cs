namespace MushtaqTraders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mmresolved : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseProducts",
                c => new
                    {
                        PurchaseId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PurchasingPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.PurchaseId, t.ProductId });
            
            CreateTable(
                "dbo.SaleProducts",
                c => new
                    {
                        SaleId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        SellingPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.SaleId, t.ProductId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SaleProducts");
            DropTable("dbo.PurchaseProducts");
        }
    }
}
