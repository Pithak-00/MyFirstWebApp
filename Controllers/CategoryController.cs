﻿using MyFirstWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApp.Controllers
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
            List<Category> objCategoryList = _db.Catagories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}

