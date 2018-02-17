using MVC.Models.Models;
using MVC.Repository.Contracts;
using System;
using System.Web.Mvc;

namespace MVCATM.Controllers.Security
{
    public class LoginController : Controller
    {
        readonly IUserAccountRepository _repository;

        public LoginController(IUserAccountRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var result = false;

                try
                {
                    result = _repository.Login(model.Username, model.Password);
                }
                catch (Exception)
                {
                    ViewBag.LoginStatus = "failed";
                }

                if (result)
                {
                    ViewBag.LoginStatus = "success";
                    return RedirectToAction("Home", "Account");
                }
                else
                {
                    ViewBag.LoginStatus = "nouser";
                }
            }

            return View(nameof(Login));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_repository != null)
                {
                    _repository.Dispose();
                }
            }

            base.Dispose(disposing);
        }
    }
}