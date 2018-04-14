using MVC.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCATM.Controllers.Security
{
    public class AccountController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(AccountModel model)
        {
            return View();
        }
    }
}