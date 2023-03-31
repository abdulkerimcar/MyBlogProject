using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace MyProject.Areas.Admin.ViewComponents.Statictic
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {

            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();
            //string api = "5ba0bcedae79f172bab73420c8fc5a17";
            //string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units&metric&appid="+api;
            //XDocument document = XDocument.Load(connection);
            //ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attributes("value");
			return View();
        }
    }
}
