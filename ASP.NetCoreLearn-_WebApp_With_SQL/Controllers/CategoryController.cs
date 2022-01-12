﻿using ASP.NetCoreLearn__WebApp_With_SQL.Data;
using ASP.NetCoreLearn__WebApp_With_SQL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NetCoreLearn__WebApp_With_SQL.Controllers
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
            IEnumerable<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
