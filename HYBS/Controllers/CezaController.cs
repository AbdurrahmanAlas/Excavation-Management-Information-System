using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using HYBS.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class CezaController : Controller
    {
        PunishmentManager pm = new PunishmentManager(new EfCezaRepository());

        //VehicleManager vm = new VehicleManager(new EfVehicleRepository());

        public IActionResult Index()
        {

            var values = pm.GetPunishmentListWithCompany();

            return View(values);
        }


        [HttpGet]
        public IActionResult CezaAdd()
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());
            List<SelectListItem> values = (from x in cm.GetList()


                                           select new SelectListItem
                                           {


                                               Text = x.CompanyName,
                                               Value = x.CompanyId.ToString()

                                           }).ToList();

            ViewBag.cv = values;

            return View();
        }


        [HttpPost]
        public IActionResult CezaAdd(AddCezaImage p)
        {
            Punishment w = new Punishment();

            if(p.CezaPhoto!=null)
            {
                var extension = Path.GetExtension(p.CezaPhoto.FileName);
                var newiimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageFiles/", newiimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.CezaPhoto.CopyTo(stream);
                w.CezaPhoto = newiimagename;

            }
            w.CompanyName = p.CompanyName;
            w.CompanyId = p.CompanyId;
            w.CezaTeam = p.CezaTeam;
            w.CezaDate = p.CezaDate;
            w.CezaAmont = p.CezaAmont;
            w.DocumentName = p.DocumentName;
            w.Description = p.Description;
            w.Plaka = p.Plaka;




            pm.CezaAdd(w);

            return RedirectToAction("Index", "Ceza");




        }
        [HttpGet]
        public IActionResult EditCeza(int id)
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());

            List<SelectListItem> firmavalues = (from x in cm.GetList()


                                                select new SelectListItem
                                                {


                                                    Text = x.CompanyName,
                                                    Value = x.CompanyId.ToString()

                                                }).ToList();



            ViewBag.cv = firmavalues;
            var vehiclevalues = pm.GetById(id);



            return View(vehiclevalues);
        }

        [HttpPost]
        public IActionResult EditCeza(AddCezaImage p,IFormFile file)
        {

            p.Status = true;
            p.CezaDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            Punishment w = new Punishment();

            if (p.CezaPhoto != null)
            {
                var extension = Path.GetExtension(p.CezaPhoto.FileName);
                var newiimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageFiles/", newiimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.CezaPhoto.CopyTo(stream);
                w.CezaPhoto = newiimagename;

            }
            

            w.CezaId = p.CezaId;
            w.CompanyName = p.CompanyName;
            w.CompanyId = p.CompanyId;
            w.CezaTeam = p.CezaTeam;
            w.CezaDate = p.CezaDate;
            w.CezaAmont = p.CezaAmont;
            w.DocumentName = p.DocumentName;
            w.Description = p.Description;
            w.Plaka = p.Plaka;

            //if(file==null)
            //{

            //    w.CezaPhoto = file.FileName;
                

            //}



            pm.CezaUpdate(w);

            return RedirectToAction("Index", "Ceza");
        }

        [HttpGet]
        public IActionResult ProductEdit(int id)
        {
            CompanyManager cm = new CompanyManager(new EfCompanyRepository());

            List<SelectListItem> firmavalues = (from x in cm.GetList()


                                                select new SelectListItem
                                                {


                                                    Text = x.CompanyName,
                                                    Value = x.CompanyId.ToString()

                                                }).ToList();



            ViewBag.cv = firmavalues;
            var vehiclevalues = pm.GetById(id);



            return View(vehiclevalues);
        }

            [HttpPost]
        public async Task<IActionResult> ProductEdit(AddCezaImage model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = pm.GetById(model.CezaId);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.CompanyName = model.CompanyName;
                entity.CompanyId = model.CompanyId;
                entity.CezaTeam = model.CezaTeam;
                entity.CezaDate = model.CezaDate;
                entity.Description = model.Description;
                entity.CezaAmont = model.CezaAmont;
                entity.DocumentName = model.DocumentName;
                entity.Description = model.Description;
                entity.Plaka = model.Plaka;
              
               
                if (file != null)
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    entity.CezaPhoto = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                //if (pm.CezaUpdate(entity, categoryIds))
                //{
                //    CreateMessage("kayıt güncellendi", "success");
                //    return RedirectToAction("ProductList");
                //}
                //CreateMessage(_productService.ErrorMessage, "danger");
            }
            //ViewBag.Categories = cm.GetAll();
            return View(model);
        }





        public IActionResult DeleteCeza(int id)
        {

            var balancevalue = pm.GetById(id);
            pm.CezaDelete(balancevalue);
            return RedirectToAction("Index");



        }

        public IActionResult CezaWithCompany()
        {

            var values = pm.GetPunishmentListWithCompany();
            return View(values);

        }

        public IActionResult CezaReadAll(int id)
        {
            var values = pm.GetCezaByID(id);
            return View(values);

        }
    }
}
