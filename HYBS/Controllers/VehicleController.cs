using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using HYBS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Controllers
{
    public class VehicleController : Controller
    {
        VehicleManager vm = new VehicleManager(new EfVehicleRepository());
        //Context c = new Context();
        public IActionResult Index()
        {
            var values = vm.GetVehicleWithCompany();

            return View(values);
        }

        public PartialViewResult PartialAddVehicle()
        {
            return PartialView();
        }

        public PartialViewResult VehicleListByCompany(int id)
        {

            var values = vm.GetList(id);

            return PartialView(values);


        }


        public IActionResult VehicleListByCompany1()
        {
            var values = vm.GetVehicleWithCompany();
            return View(values);



        }

        [HttpGet]
        public IActionResult VehicleAdd()
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
        public IActionResult VehicleAdd(AddVehicleImage p)
        {

            p.Status = true;
            //p.VehicleIzinBitis = DateTime.Parse(DateTime.Now.ToShortDateString());

            Vehicle w = new Vehicle();

            if (p.VehicleImage != null)
            {
                var extension = Path.GetExtension(p.VehicleImage.FileName);
                var newiimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageBalance/", newiimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.VehicleImage.CopyTo(stream);
                w.VehicleBrand = newiimagename;

            }
            w.DoumentName = p.DocumentName;
            w.CompanyId = p.CompanyId;
            w.VehicleModel = p.VehicleModel;
            w.VehicleTip = p.VehicleTip;
            w.VehicleHGS = p.VehicleHGS;
            w.VehicleIMEI = p.VehicleIMEI;
            w.VehiclePlaka = p.VehiclePlaka;
            w.VehicleYear = p.VehicleYear;
            w.VehicleDara = p.VehicleDara;
            w.VehicleIzinBitis = p.VehicleIzinBitis;







            vm.VehicleAdd(w);

            return RedirectToAction("VehicleListByCompany1", "Vehicle");





        }

        [HttpGet]
        public IActionResult EditVehicle(int id)
        {

            CompanyManager cm = new CompanyManager(new EfCompanyRepository());

            List<SelectListItem> firmavalues = (from x in cm.GetList()


                                                select new SelectListItem
                                                {


                                                    Text = x.CompanyName,
                                                    Value = x.CompanyId.ToString()

                                                }).ToList();



            ViewBag.cv = firmavalues;


            var vehiclevalue = vm.GetById(id);
            return View(vehiclevalue);
        }






        [HttpPost]
        public IActionResult EditVehicle(AddVehicleImage p)
        {



            p.Status = true;
            if (p.VehicleImage == null)
            {
                return NotFound("Dosya Seç kısmından  Resim Ekleyiniz");
            }

            Vehicle w = new Vehicle();
            
            if (p.VehicleImage != null)
            {
                var extension = Path.GetExtension(p.VehicleImage.FileName);
                var newiimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageBalance/", newiimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.VehicleImage.CopyTo(stream);
                w.VehicleBrand = newiimagename;


            }
           
            w.VehicleId = p.VehicleId;
            w.DoumentName = p.DocumentName;
            //w.VehicleBrand = Convert.ToString(p.VehicleImage);
            w.CompanyId = p.CompanyId;
            w.VehicleModel = p.VehicleModel;
            w.VehiclePlaka = p.VehiclePlaka;
            w.VehicleYear = p.VehicleYear;

            w.VehicleTip = p.VehicleTip;
            w.VehicleHGS = p.VehicleHGS;
            w.VehicleIMEI = p.VehicleIMEI;
            w.VehicleDara = p.VehicleDara;
            w.VehicleIzinBitis = p.VehicleIzinBitis;






            vm.VehicleUpdate(w);

            return RedirectToAction("VehicleListByCompany1");
        }





        //[HttpGet]
        //public IActionResult EditVehicle(int id)
        //{
        //    CompanyManager cm = new CompanyManager(new EfCompanyRepository());

        //    List<SelectListItem> firmavalues = (from x in cm.GetList()


        //                                        select new SelectListItem
        //                                        {


        //                                            Text = x.CompanyName,
        //                                            Value = x.CompanyId.ToString()

        //                                        }).ToList();



        //    ViewBag.cv = firmavalues;

        //    var vehiclevalues = vm.GetById(id);

        //    return View(vehiclevalues);
        //}

        //[HttpPost]
        //public IActionResult EditVehicle(Vehicle p)
        //{



        //    p.Status = true;

        //    vm.VehicleUpdate(p);

        //    return RedirectToAction("VehicleListByCompany1", "Vehicle");
        //}
    }
}
