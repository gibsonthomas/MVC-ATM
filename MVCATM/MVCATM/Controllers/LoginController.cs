using BusinessLogic.Repositories.Contracts;
using System.Web.Mvc;

namespace MVCATM.Controllers
{
    public class LoginController : Controller
    {
        readonly IUserAccountRepository _repository;

        public LoginController(IUserAccountRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(nameof(Login));
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}