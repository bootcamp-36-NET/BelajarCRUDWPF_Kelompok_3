namespace CRUDWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_M_TransactionItem", "ItemId_Id", "dbo.TB_M_Item");
            DropForeignKey("dbo.TB_M_TransactionItem", "TransactionId_Id", "dbo.TB_M_Transaction");
            DropIndex("dbo.TB_M_TransactionItem", new[] { "ItemId_Id" });
            DropIndex("dbo.TB_M_TransactionItem", new[] { "TransactionId_Id" });
            RenameColumn(table: "dbo.TB_M_TransactionItem", name: "ItemId_Id", newName: "ItemId");
            RenameColumn(table: "dbo.TB_M_TransactionItem", name: "TransactionId_Id", newName: "TransactionId");
            AlterColumn("dbo.TB_M_TransactionItem", "ItemId", c => c.Int(nullable: false));
            AlterColumn("dbo.TB_M_TransactionItem", "TransactionId", c => c.Int(nullable: false));
            CreateIndex("dbo.TB_M_TransactionItem", "TransactionId");
            CreateIndex("dbo.TB_M_TransactionItem", "ItemId");
            AddForeignKey("dbo.TB_M_TransactionItem", "ItemId", "dbo.TB_M_Item", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TB_M_TransactionItem", "TransactionId", "dbo.TB_M_Transaction", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_TransactionItem", "TransactionId", "dbo.TB_M_Transaction");
            DropForeignKey("dbo.TB_M_TransactionItem", "ItemId", "dbo.TB_M_Item");
            DropIndex("dbo.TB_M_TransactionItem", new[] { "ItemId" });
            DropIndex("dbo.TB_M_TransactionItem", new[] { "TransactionId" });
            AlterColumn("dbo.TB_M_TransactionItem", "TransactionId", c => c.Int());
            AlterColumn("dbo.TB_M_TransactionItem", "ItemId", c => c.Int());
            RenameColumn(table: "dbo.TB_M_TransactionItem", name: "TransactionId", newName: "TransactionId_Id");
            RenameColumn(table: "dbo.TB_M_TransactionItem", name: "ItemId", newName: "ItemId_Id");
            CreateIndex("dbo.TB_M_TransactionItem", "TransactionId_Id");
            CreateIndex("dbo.TB_M_TransactionItem", "ItemId_Id");
            AddForeignKey("dbo.TB_M_TransactionItem", "TransactionId_Id", "dbo.TB_M_Transaction", "Id");
            AddForeignKey("dbo.TB_M_TransactionItem", "ItemId_Id", "dbo.TB_M_Item", "Id");
        }
    }
}
