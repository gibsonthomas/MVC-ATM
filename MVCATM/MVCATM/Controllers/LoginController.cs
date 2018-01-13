using BusinessLogic.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCATM.Controllers
{
    public class LoginController : Controller
    {
        IUserAccountRepository _repository;

        public LoginController(IUserAccountRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}