using System.Web.Mvc;

namespace MVCATM.Controllers.Transaction
{
    public class BankingController : Controller
    {
        public ActionResult CreateAccount()
        {
            return View();
        }

        public ActionResult ViewBalance()
        {
            return View();
        }

        public ActionResult Withdrawal()
        {
            return View();
        }

        public ActionResult UpdatePin()
        {
            return View();
        }

        public ActionResult ViewStatement()
        {
            return View();
        }
    }
}