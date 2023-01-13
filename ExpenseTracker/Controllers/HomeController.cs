using ExpenseTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ExpenseTracker.Controllers
{
 
    public class HomeController : Controller
    {
        ExpenseContext GetContext = new ExpenseContext();
        public ActionResult Index()
        {
            var exp = GetExpenses();
            var cate = GetCategories();

            //ViewBag.expenses = exp;
            //ViewBag.categories = cate;
            MultiModelData data = new MultiModelData();
            data.expenses = exp;
            data.categories = cate;

            return View(data);
            
        }

        //public ActionResult ExpenseView()
        //{
        //    var exp = GetExpenses();
        //    var cate = GetCategories();

        //    //ViewBag.expenses = exp;
        //    //ViewBag.categories = cate;
        //    MultiModelData data = new MultiModelData();
        //    data.expenses = exp;
        //    data.categories = cate;

        //    return View(data);
        //}

        public List<AddingExpense> GetExpenses()
        {
            return GetContext.Adding_Expenses.ToList();
        }

        public List<AddingCategory> GetCategories()
        {
            return GetContext.Adding_Categories.ToList();
        }
        public ActionResult ExpenseList()
        {

            IList<AddingExpense> ExpenseList = GetContext.Adding_Expenses.ToList();
            return View(ExpenseList);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}