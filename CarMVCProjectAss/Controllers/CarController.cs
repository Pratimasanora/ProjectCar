using CarMVCProjectAss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarMVCProjectAss.Controllers
{
    public class CarController : Controller
    {
        ApplicationDbContext _context;
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CarForm(Car car)
        {
            return View(car);
        }
        public ActionResult Save(Car car)
        {
            if (car.Id == 0)
                _context.Cars.Add(car);
            else
            {
                var carInDb = _context.Cars.Single(m => m.Id == car.Id);
                carInDb.VIN = car.VIN;
                carInDb.Make = car.Make;
                carInDb.Model = car.Model;
                carInDb.Style = car.Style;
                carInDb.Year = car.Year;
                carInDb.Miles = car.Miles;
                carInDb.Color = car.Color;


            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Car");
        }
        public ActionResult Edit(int id)
        {
            var car = _context.Cars.SingleOrDefault(p => p.Id == id);
            if (car == null)
                return HttpNotFound();

            return View("Edit");
        }
    }
}