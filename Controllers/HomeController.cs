using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class HomeController : Controller
    {
        TravelDbContext context = new TravelDbContext();
		public IActionResult Index()
        {
			//Get All Blogs:
			var blogDatas = context.Blogs.ToList();
			return View(blogDatas);
        }

        public PartialViewResult PartialIndex()
        {
			//Get All Blogs:
			var blogDatas = context.Blogs.ToList();
			return PartialView(blogDatas);
        }
        public PartialViewResult PartialIndex2()
        {
            //Get All blogs
            var blogDatas = context.Blogs.ToList();
            return PartialView(blogDatas);
        }
        public PartialViewResult PartialIndex3()
        {
            //Get All Blogs
            var blogDatas = context.Blogs.ToList();
            return PartialView(blogDatas);
        }
    }
}
