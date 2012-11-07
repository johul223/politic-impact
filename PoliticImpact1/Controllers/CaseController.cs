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
        //[HttpPost]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create1()
        {
            return View();
        }

        public ActionResult ShowCase()
        {
            //Här ska vi skicka data till view från databasen.
             
            return View();
        }
        public ActionResult HandleLikes()
        {
            //skickar likes till databasen och uppdaterar sidan med antalet likes
            return View();
        }
        public ActionResult HandleComments()
        {
            //skickar commentarer till databsen och uppdaterar sidan med antalet likes
            return View();
        }
        public ActionResult HandleSignatures()
        {
            //skickar signaturer till databasen och uppdaterar sidan med att du har signerat
            return View();
        }
        
    }
}
