using BusinessLogic.Repositories.Contracts;
using BusinessLogic.Repositories.Implementations;
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
            _repository = repository?? new UserAccountRepository();
        }

        public ActionResult index()
        {
            return View();
        }
    }
}