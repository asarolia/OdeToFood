namespace OdeToFood.Migrations
{
	using OdeToFood.Models;
	using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
			context.Restaurants.AddOrUpdate(r => r.Name,
				new Models.Restaurant { Name="Dhabba 62", Location = "Noida Sector 62, India"},
				new Models.Restaurant { Name = "Desi Vibes", Location = "Noida Sector 18, India" },
				new Models.Restaurant { Name = "Dhabba 62", Location = "Noida, India", 
				new RestaurantReview { }
				}
				)
        }
    }
}
