// <auto-generated />
namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstoreconstraint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Stores", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stores", "Name", c => c.String());
        }
    }
}
