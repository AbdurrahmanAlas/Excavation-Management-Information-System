using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.ViewComponents.Ceza
{
    public class CezaListByCompany:ViewComponent
    {
        PunishmentManager pm = new PunishmentManager(new EfCezaRepository());

        public IViewComponentResult Invoke(int id)
        {

            var values = pm.GetList(id);


            return View(values);

        }




    }
}
