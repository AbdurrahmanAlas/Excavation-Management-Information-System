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
    public class OtherStructureController : Controller
    {
        OtherStructureManager osm = new OtherStructureManager(new EfOtherStructureRepository());
        public IActionResult Index()
        {

            var values = osm.GetListByCompany();


            return View(values);
        }

        [HttpGet]
        public IActionResult AddOtherStructure()
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
        public IActionResult AddOtherStructure(OtherStructure p)
        {

            osm.AddOtherStructure(p);
            return RedirectToAction("Index", "OtherStructure");

        }
        public IActionResult DeleteOtherStructure(int id)
        {

            var structurevalue = osm.GetByID(id);
            osm.DeleteOtherStructure(structurevalue);
            return RedirectToAction("Index");



        }
        [HttpGet]
        public IActionResult EditStructure(int id)
        {



            CompanyManager cm = new CompanyManager(new EfCompanyRepository());
            List<SelectListItem> ilcevalues = (from x in cm.GetList()


                                               select new SelectListItem
                                               {


                                                   Text = x.CompanyName,
                                                   Value = x.CompanyId.ToString()

                                               }).ToList();







            ViewBag.cv = ilcevalues;
            var structurevalue = osm.GetByID(id);

            return View(structurevalue);
        }


        [HttpPost]
        public IActionResult EditStructure(OtherStructure p)
        {

            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());


            osm.UpdateOtherStructure(p);

            return RedirectToAction("Index");
        }







    }
}
