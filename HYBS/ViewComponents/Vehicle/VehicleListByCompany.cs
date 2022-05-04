using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.ViewComponents.Vehicle
{
    public class VehicleListByCompany:ViewComponent
    {
        VehicleManager vm = new VehicleManager(new EfVehicleRepository());


        public IViewComponentResult Invoke(int id)
        {

            var values = vm.GetList(id);
            return View(values);



        }

    }
}
