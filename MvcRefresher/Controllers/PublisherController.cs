﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRefresher.Controllers
{
    public class PublisherController : Controller
    {
        // GET: Publisher
        public ActionResult Index()
        {
            return View();
        }

        // GET: Publisher/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Publisher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publisher/Create
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

        // GET: Publisher/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Publisher/Edit/5
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

        // GET: Publisher/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Publisher/Delete/5
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
