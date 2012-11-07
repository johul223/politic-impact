using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PoliticImpact.Models;

namespace PoliticImpact.Controllers
{   
    public class CaseItemsController : Controller
    {
		private readonly ICaseItemRepository caseitemRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public CaseItemsController() : this(new CaseItemRepository())
        {
        }

        public CaseItemsController(ICaseItemRepository caseitemRepository)
        {
			this.caseitemRepository = caseitemRepository;
        }

        //
        // GET: /CaseItems/

        public ViewResult Index()
        {
            return View(caseitemRepository.All);
        }

        //
        // GET: /CaseItems/Details/5

        public ViewResult Details(int id)
        {
            return View(caseitemRepository.Find(id));
        }

        //
        // GET: /CaseItems/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /CaseItems/Create

        [HttpPost]
        public ActionResult Create(CaseItem caseitem)
        {
            caseitem.Owner = 1337;  //TODO should be the logged in users facebook-id
            caseitem.Created = DateTime.Now;
            caseitem.LastEdited = Convert.ToDateTime("2012-01-01");
            if (ModelState.IsValid) {
                caseitemRepository.InsertOrUpdate(caseitem);
                caseitemRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /CaseItems/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(caseitemRepository.Find(id));
        }

        //
        // POST: /CaseItems/Edit/5

        [HttpPost]
        public ActionResult Edit(CaseItem caseitem)
        {
            if (ModelState.IsValid) {
                caseitemRepository.InsertOrUpdate(caseitem);
                caseitemRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /CaseItems/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(caseitemRepository.Find(id));
        }

        //
        // POST: /CaseItems/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            caseitemRepository.Delete(id);
            caseitemRepository.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                caseitemRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

