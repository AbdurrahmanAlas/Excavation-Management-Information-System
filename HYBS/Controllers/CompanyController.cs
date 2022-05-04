using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using HYBS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        CompanyManager cm = new CompanyManager(new EfCompanyRepository());
        PunishmentManager pm = new PunishmentManager(new EfCezaRepository());
        CompanyDocumentManager cdm = new CompanyDocumentManager(new EfCompanyDocumentRepository());


        public IActionResult CompanyList()
        {
            var jsonCompany = JsonConvert.SerializeObject(cm.GetList());
            return Json(jsonCompany);


        }


        
        public IActionResult Index()
        {

            var values = cm.GetList();
       
            return View(values);
        }

        public IActionResult CompanyReadAll(int id)
        {
            ViewBag.i = id;
            ViewBag.x = id;
            ViewBag.y = id;
            ViewBag.z = id;
            var values = cm.GetCompanyByID(id);
            return View(values);



        }
        public IActionResult FırmaBilgiler(int id)
        {

            var values = cm.GetCompanyByID(id);

            return View(values);
        }
        [HttpGet]
        public IActionResult CompanyAdd()
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());
            List<SelectListItem> ilcevalues = (from x in cm.GetList()


                                               select new SelectListItem
                                               {


                                                   Text = x.CompanyName,
                                                   Value = x.CompanyId.ToString()

                                               }).ToList();







            ViewBag.cv = ilcevalues;
            return View();
        }


        [HttpPost]
        public IActionResult CompanyAdd(Company p)
        {

            CompanyValidator cv = new CompanyValidator();
            ValidationResult results = cv.Validate(p);

            if (results.IsValid)
            {


                p.DocumentPhoto = "";
                p.EmployeeEmail = "";
                p.Status = true;

                cm.CompanyAdd(p);




                return RedirectToAction("Index", "Company");

            }

            else
            {

                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
                return View();





            }
        }
        [HttpGet]
        public IActionResult CompanyDocumentAdd()
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());
            List<SelectListItem> ilcevalues = (from x in cm.GetList()

                                               select new SelectListItem
                                               {
                                                   Text = x.CompanyName,
                                                   Value = x.CompanyId.ToString()

                                               }).ToList();

            ViewBag.cv = ilcevalues;

            return View();

        }
        [HttpPost]
        public IActionResult CompanyDocumentAdd(AddDocumentModel p)
        {
            p.Status = true;
            CompanyDocument w = new CompanyDocument();

            if (p.DocumentPhoto != null)
            {
                var extension = Path.GetExtension(p.DocumentPhoto.FileName);
                var newiimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageBalance/", newiimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.DocumentPhoto.CopyTo(stream);
                w.DocumentPhoto = newiimagename;

            }
            w.DocumentName = p.DocumentName;
            w.CompanyId = p.CompanyId;
            //w.DocumentPhoto = p.DocumentPhoto;

            cdm.TAdd(w);
            return RedirectToAction("Index", "Company");

        }



        public IActionResult DeleteCompany(int id)
        {

            var companyvalue = cm.GetById(id);
            cm.CompanyDelete(companyvalue);
            return RedirectToAction("Index");



        }

        [HttpGet]
        public IActionResult EditCompany(int id)
        {
            var companyvalue = cm.GetById(id);
            return View(companyvalue);
        }

        [HttpPost]
        public IActionResult EditCompany(Company p)
        {


            p.DocumentPhoto = "";
            p.EmployeeEmail = "";
            p.Status = true;

            cm.CompanyUpdate(p);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteCompanyDocument(int id)
        {

            var deletevalue = cdm.TGetById(id);
            cdm.TDelete(deletevalue);
            return RedirectToAction("Index");



        }















    }
}