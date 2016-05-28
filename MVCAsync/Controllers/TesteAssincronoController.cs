using System.Web.Mvc;

namespace MVCAsync.Controllers
{
    public class TesteAssincronoController : Controller
    {
        // GET: TesteAssincrono
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sincrono()
        {

            return View("Index");
        }

        public ActionResult Assincrono()
        {

            return View("Index");
        }
    }
}