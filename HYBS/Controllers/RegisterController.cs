using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(User p)
        {
            UserValidator wv = new UserValidator();
            ValidationResult results = wv.Validate(p);

            if(results.IsValid)
            {

            
            p.PersonSurName = "";
            p.PersonAbout = "Deneme";
            p.PersonImage = "";
            p.PersonTitle = "";
            p.PersonStatus = true;

            um.UserAdd(p);




            return RedirectToAction("Index","Login");

            }

            else
            {

                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
                return View();


            }


        }


    }
}
