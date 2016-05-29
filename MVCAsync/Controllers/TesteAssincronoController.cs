using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Application;

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
            ViewBag.Inicio = DateTime.Now;
            TesteAsync t = new TesteAsync();
            var x = t.Processar1();
            var y = t.Processar2();
            var z = t.Processar3();
            ViewBag.Fim = DateTime.Now;
            return View("Index");
        }

        public async Task<ActionResult> Assincrono()
        {
            ViewBag.Inicio = DateTime.Now;
            TesteAsync t = new TesteAsync();
            var x = t.ProcessarAsync1();
            var y = t.ProcessarAsync2();
            var z = t.ProcessarAsync3();

            await Task.WhenAll(x, y, z);

            var a = x.Result;
            var b = y.Result;
            var c = z.Result;

            ViewBag.Fim = DateTime.Now;
            return View("Index");
        }
    }
}