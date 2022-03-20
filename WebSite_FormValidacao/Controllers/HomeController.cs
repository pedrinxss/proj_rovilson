using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_FormValidacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Questionario()
        {

            return View();
        }

        public ActionResult Obrigado()
        {  
            return View();
        }

        [HttpPost]
        public ActionResult Questionario(QuestionarioModel respostas)
        {
            try
            {
                return RedirectToAction("Obrigado");
            }
            catch
            {
                return View();
            }
        }
    }
}