using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using HYBS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Controllers
{
    [Authorize]
    public class CompanyBalanceController : Controller
    {
        CompanyBalanceManager cbm = new CompanyBalanceManager(new EfCompanyBalanceRepository());
        CompanyManager cm = new CompanyManager(new EfCompanyRepository());
        public IActionResult Index()
        {
            var company = cbm.GetBalanceWithCompany();
            return View(company);
        }

        public IActionResult CompanyBalanceIndex()
        {
            var values = cm.GetList();
            return View(values);
        }




        [HttpGet]
        public IActionResult CompanyBalanceAdd()
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());

            List<SelectListItem> firmavalues = (from x in cm.GetList()


                                                select new SelectListItem
                                                {


                                                    Text = x.CompanyName,
                                                    Value = x.CompanyId.ToString()

                                                }).ToList();



            ViewBag.cv = firmavalues;

            return View();
        }
        [HttpPost]
        public IActionResult CompanyBalanceAdd(AddCompanyBalanceImage p)
        {

            CompanyBalance w = new CompanyBalance();

            //if(p.DocumentPhoto!=null)
            //{
            //    var extension = Path.GetExtension(p.DocumentPhoto.FileName);
            //    var newiimagename = Guid.NewGuid() + extension;
            //    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageBalance/", newiimagename);
            //    var stream = new FileStream(location, FileMode.Create);
            //    p.DocumentPhoto.CopyTo(stream);
            //    w.DocumentPhoto = newiimagename;

            //}
            w.DocumentName = p.DocumentName;
            w.CompanyId = p.CompanyId;
            w.DateTime = p.DateTime;
            w.FillArea = p.FillArea;
            w.Amount = p.Amount;
            w.District = p.District;
            w.Island = p.Island;
            w.Parcel = p.Parcel;
            w.miktar = p.miktar;
    




            cbm.TAdd(w);

            return RedirectToAction("Index", "CompanyBalance");





        }
        [HttpGet]
        public IActionResult EditCompanyBalance(int id)
        {

            CompanyManager cm = new CompanyManager(new EfCompanyRepository());

            List<SelectListItem> firmavalues = (from x in cm.GetList()


                                                select new SelectListItem
                                                {


                                                    Text = x.CompanyName,
                                                    Value = x.CompanyId.ToString()

                                                }).ToList();



            ViewBag.cv = firmavalues;


            var vehiclevalue = cbm.TGetById(id);
            return View(vehiclevalue);
        }

        [HttpPost]
        public IActionResult EditCompanyBalance(AddCompanyBalanceImage p)
        {
            //if (p.DocumentPhoto == null)
            //{
            //    return NotFound("Dosya Seç kısmından  Resim Ekleyiniz");
            //}


            CompanyBalance w = new CompanyBalance();

            //if (p.DocumentPhoto != null )
            //{
            //    var extension = Path.GetExtension(p.DocumentPhoto.FileName);
            //    var newiimagename = Guid.NewGuid() + extension;
            //    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageBalance/", newiimagename);
            //    var stream = new FileStream(location, FileMode.Create);
            //    p.DocumentPhoto.CopyTo(stream);
            //    w.DocumentPhoto = newiimagename;

            //}
        
            w.CompanyBalanceID = p.CompanyBalanceID;

            w.CompanyId = p.CompanyId;
            w.DocumentName = p.DocumentName;
            w.CompanyId = p.CompanyId;
            w.DateTime = p.DateTime;
            w.FillArea = p.FillArea;
            w.Amount = p.Amount;
            w.District = p.District;
            w.Island = p.Island;
            w.Parcel = p.Parcel;
            w.miktar = p.miktar;




            cbm.TUpdate(w);
            
            return RedirectToAction("Index");
        }


        public IActionResult DeleteCompanyBalance(int id)
        {

            var balancevalue = cbm.TGetById(id);
            cbm.TDelete(balancevalue);
            return RedirectToAction("Index");



        }

    }
}
