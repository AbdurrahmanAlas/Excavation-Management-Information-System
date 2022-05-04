using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Controllers
{
    [Authorize]
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingRepository());
        public IActionResult Index()
        {
            var values = hm.GetList();

            return View(values);
        }
        [HttpGet]
        public IActionResult AddHeading()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddHeading(Heading h)
        {
            h.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            hm.TAdd(h);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditHeading(int id)
        {

            var vehiclevalues = hm.TGetById(id);
            return View(vehiclevalues);
        }

        [HttpPost]
        public IActionResult EditHeading(Heading p)
        {



            p.HeadingStatus = true;

            hm.TUpdate(p);

            return RedirectToAction("Index", "Heading");
        }



    }

}

