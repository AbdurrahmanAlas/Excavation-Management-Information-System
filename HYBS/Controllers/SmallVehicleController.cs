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
    public class SmallVehicleController : Controller
    {
        SmallVehicleManager svm = new SmallVehicleManager(new EfSmallVehicleRepository());
        SmallBalanceManager sbm = new SmallBalanceManager(new EfSmallBalanceRepository());
        public IActionResult Index()
        {
            var values = svm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSmallVehicle()
        {



            return View();

        }
        [HttpPost]

        public IActionResult AddSmallVehicle(SmallVehicle p)
        {

           svm.TAdd(p);
            return RedirectToAction("Index","SmallVehicle");


        }
        [HttpGet]
        public IActionResult EditSmallVehicle(int id)
        {

            var vehiclevalues = svm.TGetById(id);

            return View(vehiclevalues);

    
        }

        [HttpPost]
        public IActionResult EditSmallVehicle(SmallVehicle p)
        {
            svm.TUpdate(p);

            return RedirectToAction("Index", "SmallVehicle");


        }

        public IActionResult DeleteSmallVehicle(int id)
        {

            var companyvalue = svm.TGetById(id);
            svm.TDelete(companyvalue);
            return RedirectToAction("Index");



        }

        public IActionResult Balance()
        {
            var values = sbm.GetListWithSmallVehicle();

            return View(values);
        }




        [HttpGet]
        public IActionResult AddBalance()
        {
            SmallVehicleManager svm = new SmallVehicleManager(new EfSmallVehicleRepository());
            List<SelectListItem> firmavalues = (from x in svm.GetList()


                                                select new SelectListItem
                                                {


                                                    Text = x.Name+""+x.Surname,
                                                    Value = x.SmallVehicleId.ToString()

                                                }).ToList();



            ViewBag.cv = firmavalues;



            return View();
        }
        [HttpPost]
        public IActionResult AddBalance(BalanceSmall p)
        {

            sbm.TAdd(p);


            return RedirectToAction("Balance","SmallVehicle");
        }

      
    }
}
