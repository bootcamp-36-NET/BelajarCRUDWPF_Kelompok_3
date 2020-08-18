namespace CRUDWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Supplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_TransactionItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ItemId_Id = c.Int(),
                        TransactionId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Item", t => t.ItemId_Id)
                .ForeignKey("dbo.TB_M_Transaction", t => t.TransactionId_Id)
                .Index(t => t.ItemId_Id)
                .Index(t => t.TransactionId_Id);
            
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
            DropForeignKey("dbo.TB_M_TransactionItem", "TransactionId_Id", "dbo.TB_M_Transaction");
            DropForeignKey("dbo.TB_M_TransactionItem", "ItemId_Id", "dbo.TB_M_Item");
            DropIndex("dbo.TB_M_TransactionItem", new[] { "TransactionId_Id" });
            DropIndex("dbo.TB_M_TransactionItem", new[] { "ItemId_Id" });
            DropTable("dbo.TB_M_Transaction");
            DropTable("dbo.TB_M_TransactionItem");
            DropTable("dbo.TB_M_Supplier");
            DropTable("dbo.TB_M_Item");
        }
    }
}
