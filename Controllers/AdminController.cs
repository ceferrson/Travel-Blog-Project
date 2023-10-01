using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TravelTripProject.Models.Classes;
using PagedList.Mvc;
using PagedList;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        TravelDbContext context = new TravelDbContext();
        public IActionResult Index()
        {
            var blog = context.Blogs.ToList();
            return View(blog);
        }
        [HttpGet]
        public IActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewBlog(Blog blog)
        { 
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }  
        public IActionResult DeleteBlog(int id )
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetBlog(int id)
        { 
            var blog = context.Blogs.Find(id);
            return View(blog);
        }
        public IActionResult UpdateBlog(Blog blogData)
        {
            var blog = context.Blogs.Find(blogData.ID);
            blog.Title = blogData.Title;
            blog.Description = blogData.Description;
            blog.Date = blogData.Date;
            blog.BlogImage = blogData.BlogImage;
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult CommentList()
        {
            //html'faylinda comment uzerinden blog'lara da erisecem deye include ederek Blog'u da gonderirem
            var comments = context.Comments.Include(c => c.Blog).ToList();
            return View(comments);
        }
        public IActionResult DeleteComment(int id)
        {
            var comment = context.Comments.Find(id);
            context.Comments.Remove(comment);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}
