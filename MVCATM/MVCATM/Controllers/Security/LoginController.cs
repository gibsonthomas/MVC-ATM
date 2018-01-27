using BusinessLogic.Repositories.Contracts;
using System.Web.Mvc;

namespace MVCATM.Controllers.Security
{
    public class LoginController : Controller
    {
        readonly IUserAccountRepository _repository;

        public LoginController()
            : this(null)
        {

        }

        public LoginController(IUserAccountRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult ValidateUser(string username, string password)
        {
            var result = _repository.Login(username, password);

            if(result)
            {

            }
            else
            {

            }

            return View();
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