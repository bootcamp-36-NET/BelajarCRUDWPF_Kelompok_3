namespace CRUDWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        Supplier_Id = c.Int(nullable: false),
                        Supplier_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Supplier", t => t.Supplier_Id1)
                .Index(t => t.Supplier_Id1);
            
            CreateTable(
                "dbo.TB_M_Supplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        JoinDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_TransactionItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        TransactionId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Item", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_Transaction", t => t.TransactionId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.TB_M_Transaction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_TransactionItem", "TransactionId", "dbo.TB_M_Transaction");
            DropForeignKey("dbo.TB_M_TransactionItem", "ItemId", "dbo.TB_M_Item");
            DropForeignKey("dbo.TB_M_Item", "Supplier_Id1", "dbo.TB_M_Supplier");
            DropIndex("dbo.TB_M_TransactionItem", new[] { "ItemId" });
            DropIndex("dbo.TB_M_TransactionItem", new[] { "TransactionId" });
            DropIndex("dbo.TB_M_Item", new[] { "Supplier_Id1" });
            DropTable("dbo.TB_M_Transaction");
            DropTable("dbo.TB_M_TransactionItem");
            DropTable("dbo.TB_M_Supplier");
            DropTable("dbo.TB_M_Item");
        }
    }
}
