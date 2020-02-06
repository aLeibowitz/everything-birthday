using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using everything_birthday.Models;
using everything_birthday.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace everything_birthday.Controllers
{
    public class EventEntryController : Controller
    {
        private ApplicationDbContext dbContext;

        public EventEntryController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        // GET: EventEntry
        public ActionResult Index()
        {
            var eventEntries = dbContext.EventEntries.Include(e => e.EventType);
            eventEntries.Include(m => m.Month);
            eventEntries.Include(d => d.Day);
            eventEntries.ToList();
            return View(eventEntries);


        }

        // GET: EventEntry/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventEntry/Create
        public ActionResult Create()
        {
            var eventTypes = dbContext.EventTypes.ToList();
            var months = dbContext.Months.ToList();
            var days = dbContext.Days.ToList();

            var viewModel = new EventEntryViewModel { EventTypes = eventTypes, Months = months, Days = days };

            return View("Create", viewModel);
        }

        // POST: EventEntry/Create
        [HttpPost]
        public ActionResult Create(EventEntry eventEntry)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                // TODO: Add insert logic here
                dbContext.EventEntries.Add(eventEntry);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventEntry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventEntry/Edit/5
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

        // GET: EventEntry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventEntry/Delete/5
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
