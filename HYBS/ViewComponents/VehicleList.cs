using HYBS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.ViewComponents
{
    public class VehicleList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var vehiclevalues = new List<UserVehicle>
            {
                new UserVehicle
                {
                    Id=1,
                    UserName="Alas"



                },
                 new UserVehicle
                {
                    Id=2,
                    UserName="Apo"



                },
                  new UserVehicle
                {
                    Id=3,
                    UserName="Ssailli"



                }

            };

            return View(vehiclevalues);


        }

    }
}
