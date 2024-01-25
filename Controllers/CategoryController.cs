using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BulkyWeb.Data;
using BulkyWeb.Models;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCatList = _db.Categories.ToList();
            return View(objCatList);
        }
        public IActionResult AddCategory() {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category newCat)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(newCat);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newCat);
        }
        public IActionResult EditCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category categoryFromDb = _db.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult EditCategory(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category categoryFromDb = _db.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost,ActionName("DeleteCategory")]
        public IActionResult DeletePOST(int? id)
        {
            Category retrievedCat = _db.Categories.Find(id);
            if (retrievedCat == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(retrievedCat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

