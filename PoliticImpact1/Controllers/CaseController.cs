using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoliticImpact1.Controllers
{
    public class CaseController : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }
    }
}
