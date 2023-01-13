using ExpenseTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ExpenseTracker.Controllers
{
    public class Adding_CategoryController : Controller
    {
        // GET: Adding_Category
        ExpenseContext GetContext = new ExpenseContext();
        public ActionResult Index()
        { 
            IList<AddingCategory> listview = GetContext.Adding_Categories.ToList();
            return View(listview);

        }

        public ActionResult Create()
        {
            
            return View();

        }

        [HttpPost]
        public ActionResult Create(AddingCategory input)
        {
            try
            {
                GetContext.Adding_Categories.Add(input);
                int a = GetContext.SaveChanges();
                if (a > 0)
                {
                    ViewBag.InsertMessage = "<script>alert('Data Inserted !!')</script>";
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data not Inserted !!')</script>";
                }
            }
            catch (Exception)
            {
                TempData["try"] = "<script>alert('Category name already exit')</script>";


            }

            return View();

        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {
            var raw = GetContext.Adding_Categories.Where(model => model.Category == Id).FirstOrDefault();
            return View(raw);
        }

        [HttpPost]
        public ActionResult Edit(AddingCategory input)
        {
            GetContext.Entry(input).State = EntityState.Modified;
             int a = GetContext.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMesssage = "<script>alert('Data Updated !!')</script>";

            }
            else
            {
                ViewBag.UpdateMesssage = "<script>alert('Data not Updated !!')</script>";
            }

            return RedirectToAction("Index");

        }
           [HttpPost]
        public ActionResult Delete(string Id)
        {
            try
            {
                var catraw = GetContext.Adding_Categories.Where(model => model.Category == Id).FirstOrDefault();
                if (catraw != null)
                {
                    GetContext.Entry(catraw).State = EntityState.Deleted;
                    int a = GetContext.SaveChanges();
                    if (a > 0)
                    {
                        TempData["Deleted"] = "<script>alert('Data Deleted !!')</script>";
                    }
                    else
                    {
                        TempData["Deleted"] = "<script>alert('Data not Deleted !!')</script>";
                    }
                }
            }
            catch(Exception )
            {
                TempData["try"] = "<script>alert('data not deleted because expense this use category data')</script>";

               
            }

            return RedirectToAction("Index");
        }


    }
}