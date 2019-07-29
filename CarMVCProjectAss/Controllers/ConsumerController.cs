using CarMVCProjectAss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarMVCProjectAss.Controllers
{
    public class ConsumerController : Controller
    {
        ApplicationDbContext _context;
        // GET: Consumer
        public ConsumerController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var cons = _context.Consumers.ToList();
            return View(cons);
            
            
        }
        public ActionResult CustForm(Consumer consumer)
        {
            return View(consumer);
        }
        public ActionResult Details(int id)
        {
            var consumer = _context.Consumers.SingleOrDefault(p => p.Id == id);


            return View(consumer);
        }
        public ActionResult Save(Consumer consumer)
        {
            if (consumer.Id == 0)
                _context.Consumers.Add(consumer);
            else
            {
                var consumerInDb = _context.Consumers.Single(c => c.Id == consumer.Id);
                consumerInDb.FirstName = consumer.FirstName;
                consumerInDb.LastName = consumer.LastName;
                consumerInDb.Email = consumer.Email;
                consumerInDb.PhoneNumber= consumer.PhoneNumber;
                consumerInDb.Address = consumer.Address;
                consumerInDb.City = consumer.City;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Consumer");
        }
        public ActionResult Edit(int id)
        {
            var consumer = _context.Consumers.SingleOrDefault(p => p.Id == id);
            if (consumer == null)
                return HttpNotFound();

            return View("EditForm");
        }
        public ActionResult Delete(int id)
        {
            Consumer consumer = _context.Consumers.Find(id);
            _context.Consumers.Remove(consumer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}
        