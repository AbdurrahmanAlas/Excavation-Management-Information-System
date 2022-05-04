using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
    public class StructureController : Controller
    {
        StructureManager sm = new StructureManager(new EfStructureRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var kazıtoplam = c.Structures.Sum(x => x.Kazı);
            ViewBag.kazıtoplam = kazıtoplam;

            var bakiyetoplam = c.Structures.Sum(x => x.Dolgu);
            ViewBag.dolgutoplam = bakiyetoplam;

          

            var values = sm.GetStructureListCompany();


            return View(values);
        }
        [HttpGet]
        public IActionResult StructureAdd()
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
        public IActionResult StructureAdd(Structure p)
        {


            sm.StructureAdd(p);

            return RedirectToAction("Index", "Structure");




        }


       

        public IActionResult DeleteStructure(int id)
        {

            var structurevalue = sm.GetById(id);
            sm.StructureDelete(structurevalue);
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
            var structurevalue = sm.GetById(id);

            return View(structurevalue);
        }


        [HttpPost]
        public IActionResult EditStructure(Structure p)
        {
            p.OnayDate = DateTime.Parse(DateTime.Now.ToShortDateString());



            sm.StructureUpdate(p);

            return RedirectToAction("Index");
        }







    }

}