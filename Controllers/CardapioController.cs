using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class CardapioController : Controller
    {
        //
        // GET: /Cardapio/

        public ActionResult Index()
        {
            return View("IndexCardapio");
        }

    }
}
