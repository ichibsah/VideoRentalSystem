// <auto-generated />
namespace VideoRentalSystem.Migrations.VideoRentalLoanContext
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addisDeletedproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Tarifs", "IsDeleted", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("public.Tarifs", "IsDeleted");
        }
    }
}
