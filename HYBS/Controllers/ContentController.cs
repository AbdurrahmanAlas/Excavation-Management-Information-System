using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Controllers
{
    [Authorize]
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentRepository());
        Context c = new Context();
        public IActionResult ContentByHeading(int id)
        {
           

            var contentValues = cm.GetListByHeadingID(id);

            return View(contentValues);
        }




        [HttpGet]
        public IActionResult AddContent()
        {

            return View();


        }


        [HttpPost]
        public IActionResult AddContent(Content p )

        {
            //string mail = (string)Session["WriterMail"];

            var heading = c.Headings.Select(x => x.HeadingID).FirstOrDefault();

            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());



            p.ContentStatus = true;

            p.HeadingID = heading;
            cm.TAdd(p);


            return RedirectToAction("ContentByHeading");


        }
    }
}
