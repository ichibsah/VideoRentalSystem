namespace VideoRentalSystem.Migrations.FilmAwardSqLite
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using System.Linq;

    internal sealed class sqLiteConfiguration : DbMigrationsConfiguration<VideoRentalSystem.Data.SqLite.VideoRentalFilmAwardsContext>
    {
        public sqLiteConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\FilmAwardSqLite";

            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(VideoRentalSystem.Data.SqLite.VideoRentalFilmAwardsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}