namespace OdeToFood.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class OdeToFoodDb : DbContext
	{
		// Your context has been configured to use a 'OdeToFoodDb' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'OdeToFood.Models.OdeToFoodDb' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'OdeToFoodDb' 
		// connection string in the application configuration file.
		public OdeToFoodDb()
			: base("name=OdeToFoodDb")
		{
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
		public DbSet<Restaurant> Restaurants { get; set; }
		public DbSet<RestaurantReview> RestaurantReviews { get; set; }

	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}