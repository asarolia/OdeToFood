using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class Restaurant
	{
		// list properties associated with a restaurant

		public int Id { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }
		// every restaurant should be associated with its reviews so create collection object for that
		public ICollection<RestaurantReview> Reviews { get; set; }

	}
}