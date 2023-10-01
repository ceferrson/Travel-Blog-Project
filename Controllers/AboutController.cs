using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
	public class AboutController : Controller
	{
		//Create context class
		TravelDbContext context = new TravelDbContext();
		public IActionResult Index()
		{
			//get about list from database
			var aboutDatas = context.Abouts.ToList();
			return View(aboutDatas);
		}
	}
}
