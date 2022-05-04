using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.ViewComponents.StructureCom
{
    public class StructureListByCompany:ViewComponent
    {
        StructureManager sm = new StructureManager(new EfStructureRepository());

        public IViewComponentResult Invoke(int id)
        {

            var values = sm.GetListDocument(id);


            return View(values);

        }


    }
}
