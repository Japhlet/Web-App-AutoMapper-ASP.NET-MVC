using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAutoMapper.Models;
using WebAppAutoMapper.ViewModel;

namespace WebAppAutoMapper.Controllers
{
    public class HomeController : Controller
    {
        private Db db;

        public HomeController()
        {
            db = new Db();
        }
        public ActionResult Index()
        {
            IEnumerable<CategoriesVM> listOfCategoriesVM = (from objCategory in db.Categories
                                                            select new CategoriesVM()
                                                            {
                                                                CategoryID = objCategory.CategoryID,
                                                                CategoryName = objCategory.CategoryName,
                                                                Description = objCategory.Description

                                                            }).ToList();
            return View(listOfCategoriesVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}