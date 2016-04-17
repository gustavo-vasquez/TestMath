using Capa_Entidades;
using Capa_Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing.Controllers
{
    public class HomeController : Controller
    {
        static EcuacionServices servicios = new EcuacionServices();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Database()
        {
            ecuacion eq = new ecuacion();
            return View(eq);
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Database(ecuacion eq)
        {
            servicios.SaveToDatabase(eq);
            return RedirectToAction("Resultado");
        }

        public ActionResult Resultado()
        {            
            return View(servicios.GetFirstEquation());
        }
        
        [HttpPost]
        public ActionResult Resultado(int id)
        {
            return View(servicios.SearchEquation(id));
        }
    }
}