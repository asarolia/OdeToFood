using System;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Filters
{
	public class LogAttribute : ActionFilterAttribute
	{
		// executed before any action method in controller
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			base.OnActionExecuting(filterContext);
		}

		// executed after action method execution
		public override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			base.OnActionExecuted(filterContext);
		}
		
		// executed after controller processed respone /request
		public override void OnResultExecuted(ResultExecutedContext filterContext)
		{
			base.OnResultExecuted(filterContext);
		}

		// executed before controller process response/result
		public override void OnResultExecuting(ResultExecutingContext filterContext)
		{
			base.OnResultExecuting(filterContext);
		}
	}
}
