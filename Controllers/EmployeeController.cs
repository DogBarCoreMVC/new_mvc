using Microsoft.AspNetCore.Mvc;
using new_mvc.DataConnect;
using new_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace new_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Context _db;

        public EmployeeController(Context db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> Obj = _db.EmployeesTbl;
            return View(Obj);
        }

        public IActionResult Create()//ดักเข้าหน้ากรอกข้อมูล
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee EmAdd)
        {
            if (ModelState.IsValid)
            {
                _db.EmployeesTbl.Add(EmAdd);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(EmAdd);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var Enter = _db.EmployeesTbl.Find(id);
            if (Enter == null)
            {
                return NotFound();
            }
            return View(Enter);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee EmEitd)
        {
            if (ModelState.IsValid)
            {
                _db.EmployeesTbl.Update(EmEitd);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(EmEitd);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var Enter = _db.EmployeesTbl.Find(id);
            if (Enter == null)
            {
                return NotFound();
            }
            return View(Enter);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var Enter = _db.EmployeesTbl.Find(id);
                _db.EmployeesTbl.Remove(Enter);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}
