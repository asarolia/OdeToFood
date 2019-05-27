using OdeToFood.Filters;
using OdeToFood.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
	public class CuisineController : Controller
	{
		// istantiate DB model 

		OdeToFoodDb _db = new OdeToFoodDb();

		// GET: Cuisine
		[Log]
		
		public ActionResult Search(string name)
		{

			// return View();
			// just return string 
			//return Content("Hello! from custom route: parsed name value :"+name);
			// return Json
			//return Json(new { Message = name, From = "Abhishek" }, JsonRequestBehavior.AllowGet);
			// return File 
			//return File(Server.MapPath("~/Content/site.css"),"text/css");

			// fetch data from in memory model 
			//var items = 
			//		from r in _reviews
			//		select r;

			var items = _db.Restaurants.ToList();

			return View(items);

		}


		// For quick testing hard code the data with some in memory impleemntation for model 
		//static List<RestaurantReview> _reviews = new List<RestaurantReview> {
		//	new RestaurantReview
		//	{
				
		//	Id= 1,
		//	Name= "Punjabi Dhaba",
		//	Location = "Delhi"
			
		//	},
		//	new RestaurantReview
		//	{
		//	Id= 2,
		//	Name= "Punjabi Tadka",
		//	Location= "Noida"
		//	}
		//};

	protected void Dispose(bool disposing)
		{
			if(_db != null)
			{
				_db.Dispose();
			}

			base.Dispose(disposing);
		}		

	}
}