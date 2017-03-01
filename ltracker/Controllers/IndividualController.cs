using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ltracker.Data;
using ltracker.Data.Repositories;
using ltracker.Data.Entities;
using ltracker.Models;
using ltracker.Helpers;

namespace ltracker.Controllers
{
    public class IndividualController : Controller
    {
        LearningContext context = new LearningContext();

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Individual
        /// <summary>
        /// Lista de individuals y se la va a pasar a la vista Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var repository = new IndividualRepository(context);
            var individuals = repository.GetAll();
            var models = MapperHelper.Map <IEnumerable<IndividualViewModel>>(individuals);
            return View(models);
        }

        // GET: Individual/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Individual/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Individual/Create
        [HttpPost]
        public ActionResult Create(IndividualViewModel model)
        {
            try
            {
                if (ModelState.IsValid) {

                    var repository = new IndividualRepository(context);
                    var individual = MapperHelper.Map<Individual>(model);
                    repository.Insert(individual);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Individual/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Individual/Edit/5
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

        // GET: Individual/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Individual/Delete/5
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
