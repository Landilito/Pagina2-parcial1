using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina2Parcial1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Historia()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Productos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Categorias()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Diferentes formas de contacto.";

            return View();
        }
    }
}