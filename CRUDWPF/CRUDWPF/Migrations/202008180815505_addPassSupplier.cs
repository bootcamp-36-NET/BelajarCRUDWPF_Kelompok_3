namespace CRUDWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPassSupplier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_Supplier", "Email", c => c.String());
            AddColumn("dbo.TB_M_Supplier", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_M_Supplier", "Password");
            DropColumn("dbo.TB_M_Supplier", "Email");
        }
    }
}
