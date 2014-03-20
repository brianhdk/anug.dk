using System.Web.Mvc;

namespace Anug.Website.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}