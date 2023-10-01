using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
	public class BlogController : Controller
	{
		TravelDbContext context = new TravelDbContext();
		//Bu class'in obyekti sayesinde hem blog'a hem blog'a mexsus commentlere elcatanliq yaranir
		BlogComment blogComment = new BlogComment();
		public IActionResult Index()
		{
			//Get All Blogs
			blogComment.blogValue = context.Blogs.ToList();
			return View(blogComment);
		}
		public IActionResult BlogDetails(int id) 
		{
			//Id'e uygun blog'u elde edek
			blogComment.blogValue = context.Blogs.Where(b => b.ID == id).ToList();
			//BlogId'ye uygun commentleri elde edek:
			blogComment.commentValue = context.Comments.Where(c => c.BlogId == id).ToList();
			return View(blogComment);
		}
		[HttpPost]
		public IActionResult WriteComment(Comment comment, int blogID)
		{
			context.Comments.Add(comment);
			context.SaveChanges();
			//I send this value to the blogdetails method and its parameter's name is id so i show that  blogID will be
			//that parameter with to named it id with the help of new anonym function
			return RedirectToAction("BlogDetails", new { id = blogID });
		}

	}
}
