using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formatif3.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Plan()
        {
            ViewBag.Message = "plan";

            return View();
        }

        public ActionResult Travaux()
        {
            ViewBag.Message = "travaux";

            return View();
        }

        public ActionResult Examens()
        {
            ViewBag.Message = "exams";

            return View();
        }
      
        public ActionResult Etudiant()
        {
            ViewBag.Message = "etudiants";

            return View();
        }
        [HttpPost]
        public ActionResult EtudiantNew()
        {
            string nom = Request.Form["nom"];
            string prog = Request.Form["prog"];
            string annee = Request.Form["etude"];
            string nais = Request.Form["nais"];


            ViewBag.Nom = nom;
            ViewBag.Prog = prog;
            ViewBag.Annee = annee;
            ViewBag.Nais = nais;
            ViewBag.Age = 2020 - Int64.Parse(nais); 

            return View();
        }
    }
}