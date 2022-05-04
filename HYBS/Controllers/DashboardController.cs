using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
           
            ViewBag.v1 = c.Structures.Count().ToString();
            ViewBag.v2 = c.Fillings.Count().ToString();
            ViewBag.v3 = c.Companies.Count().ToString();
            ViewBag.v4 = c.Vehicles.Count().ToString();
            ViewBag.v5 = c.SmallVehicles.Count().ToString();
            ViewBag.v6 = c.OtherStructures.Count().ToString();
            ViewBag.v7 = c.AltyapıIslers.Count().ToString();
            ViewBag.v8 = c.Punishments.Count().ToString();
            var deger11 = c.CompanyBalances.Sum(x => x.Amount).ToString();
            ViewBag.d11 = deger11;
            var kazıtoplam = c.Structures.Sum(x => x.Kazı);
            ViewBag.kazıtoplam = kazıtoplam;
            var dolgutoplam = c.Structures.Sum(x => x.Dolgu);
            ViewBag.dolgutoplam = dolgutoplam;
            return View();
        }
    }
}
