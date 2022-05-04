using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
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
    public class FillingController : Controller
    {
        FillingManager fm = new FillingManager(new EfFillingRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var kazıtoplam = c.Fillings.Sum(x => x.Kazı);
            ViewBag.kazıtoplam = kazıtoplam;

            var bakiyetoplam = c.Fillings.Sum(x => x.Dolgu);
            ViewBag.dolgutoplam = bakiyetoplam;


            var values = fm.GetFillingWithCompany();

            return View(values);
        }


        [HttpGet]
        public IActionResult FillingAdd()
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());
            List<SelectListItem> values = (from x in cm.GetList()


                                           select new SelectListItem
                                           {


                                               Text = x.CompanyName,
                                               Value = x.CompanyId.ToString()

                                           }).ToList();







            ViewBag.cv = values;
            return View();
        }


        [HttpPost]
        public IActionResult FillingAdd(Filling p)
        {

            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            fm.FillingAdd(p);

            return RedirectToAction("Index", "Filling");




        }
        [HttpGet]
        public IActionResult EditFilling(int id)
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());

            List<SelectListItem> firmavalues = (from x in cm.GetList()


                                                select new SelectListItem
                                                {


                                                    Text = x.CompanyName,
                                                    Value = x.CompanyId.ToString()

                                                }).ToList();



            ViewBag.cv = firmavalues;





            var fillingvalues = fm.GetById(id);

            return View(fillingvalues);
        }

        [HttpPost]
        public IActionResult EditFilling(Filling p)
        {


            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = true;

            fm.FillingUpdate(p);

            return RedirectToAction("Index", "Filling");
        }


        public IActionResult DeleteFilling(int id)
        {

            var fillingvalue = fm.GetById(id);
            fm.FillingDelete(fillingvalue);
            return RedirectToAction("Index");



        }

    }
}
