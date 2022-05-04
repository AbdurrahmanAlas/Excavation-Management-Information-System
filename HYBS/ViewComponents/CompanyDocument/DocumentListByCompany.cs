using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.ViewComponents.CompanyDocument
{
    public class DocumentListByCompany : ViewComponent
    {
        CompanyDocumentManager cdm = new CompanyDocumentManager(new EfCompanyDocumentRepository());
        public IViewComponentResult Invoke(int id)
        {

            var values = cdm.GetList(id);
            return View(values);

        }

    }
}