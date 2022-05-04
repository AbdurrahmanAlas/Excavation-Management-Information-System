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
    public class AltyapıController : Controller
    {
        AltyapıManager altm = new AltyapıManager(new EfAltyapıIslerRepository());
        public IActionResult Index()
        {
            var values = altm.GetVehicleWithCompany();


            return View(values);
        }

        [HttpGet]
        public IActionResult AddAltyapı()
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());
            List<SelectListItem> values = (from x in cm.GetList()
                                           select new SelectListItem
                                           {

                                               Text = x.CompanyName,
                                               Value = x.CompanyId.ToString()


                                           }


                                          ).ToList() ;

            ViewBag.cv = values;
            return View();



        }

        [HttpPost]
        public IActionResult AddAltyapı(AltyapıIsler p)
        {
            p.IhaleDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.LocationDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.FınıshDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            altm.TAdd(p);
            return RedirectToAction("Index", "Altyapı");




        }



        [HttpGet]
        public IActionResult EditAltyapı(int id)
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());

            List<SelectListItem> firmavalues = (from x in cm.GetList()


                                                select new SelectListItem
                                                {


                                                    Text = x.CompanyName,
                                                    Value = x.CompanyId.ToString()

                                                }).ToList();



            ViewBag.cv = firmavalues;





            var vehiclevalues = altm.TGetById(id);



            return View(vehiclevalues);
        }

        [HttpPost]
        public IActionResult EditAltyapı(AltyapıIsler p)
        {

            altm.TUpdate(p);

            return RedirectToAction("Index", "Altyapı");
        }


        public IActionResult DeleteAltyapı(int id)
        {

            var fillingvalue = altm.TGetById(id);
            altm.TDelete(fillingvalue);
            return RedirectToAction("Index");



        }
    }
}
