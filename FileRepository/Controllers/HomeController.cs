using FileRepository.Models;
using System.Web.Mvc;

namespace FileRepository.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register register)
        {
          
            return View();
        }
    }
}
