using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRefresher.Controllers
{
    public class BoardGameController : Controller
    {
        // GET: BoardGame
        public ActionResult Index()
        {
            return View();
        }

        // GET: BoardGame/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BoardGame/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoardGame/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BoardGame/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BoardGame/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BoardGame/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BoardGame/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
