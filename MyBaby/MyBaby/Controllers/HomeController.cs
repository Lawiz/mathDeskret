
using System.Web.Mvc;
using Models;

namespace MyBaby.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public void   UnionGraphs()
		{
			var resultTestUnion=GraphsAPI.Uinion(Program.testGraph1, Program.testGraph2);

		}
		public void IntersectGraphs()
		{
			var resultTestIntersect = GraphsAPI.Intersect(Program.testGraph1, Program.testGraph2);
			
		}
	}
}