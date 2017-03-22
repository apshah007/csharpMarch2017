using CLproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLproject.Controllers
{
    public class GroceryController : Controller
    {
        // GET: Grocery
        [HttpGet]
        public ActionResult Index()
        {
            
            var model = new GroceryViewModel();
            //load from the database 
            model.Groceries.Add(new GroceryItem() { ProductName="apple" });
            model.Groceries.Add(new GroceryItem() { ProductName="milk"});
            model.Groceries.Add(new GroceryItem() { ProductName="cheese"});
            model.Groceries.Add(new GroceryItem() { ProductName="oranges"});
            


            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GroceryViewModel model)
        {
            i
            {f (ModelState.IsValid)
                // save here

                return RedirectToAction("Index");
            }
            //must reload view model list here before return 
            return View(model);
        }


        // GET: Grocery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grocery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grocery/Create
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

        // GET: Grocery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grocery/Edit/5
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

        // GET: Grocery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grocery/Delete/5
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
