using Shop.Auhtors;
using Shop.Books;
using Shop.Migrations.SeedData;
using Shop.PublishingHauses;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace Shop.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Shop.EntityFramework.ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Shop";
        }

        protected override void Seed(Shop.EntityFramework.ShopDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here.
            
            new AuthorsCreator(context).Create();
            new PublishingHausesCreator(context).Create();
            new BooksCreator(context).Create();
            new EditionCreator(context).Create();
            new CarrierCreator(context).Create();
            new CoversCreator(context).Create();
            
        }
    }
}
