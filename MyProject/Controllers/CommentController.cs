using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult PartialAddComment()
		{
			return View();
		}
		[HttpPost]
		public IActionResult PartialAddComment(Comment comment)
		{
			comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.CommentStatus = true;
			comment.BlogID = 5;
			cm.CommentAdd(comment);
			return RedirectToAction("Index", "Blog");
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values= cm.GetList(id);
			return PartialView(values);
		}
	}
}
