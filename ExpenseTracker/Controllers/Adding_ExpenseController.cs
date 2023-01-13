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
    public class Adding_ExpenseController : Controller
    {
        // GET: Adding_Expense
        ExpenseContext GetContext = new ExpenseContext();
        public ActionResult Index()
        {


            IList<AddingExpense> listview = GetContext.Adding_Expenses.ToList();

            return View(listview);
        }

        public ActionResult Create()
        {
            List<AddingCategory> cid =GetContext.Adding_Categories.ToList();
            TempData["cname"] = new SelectList(cid, "Category", "Category");
            return View();
           
        }

        [HttpPost]
        public ActionResult Create(AddingExpense input)
        {
            var getcategoryamount = GetContext.Adding_Categories.Where(x => x.Category == input.Category).FirstOrDefault();
            if (getcategoryamount.Category_Expense_Limit > input.Amount)
            {
                List<AddingCategory> cid = GetContext.Adding_Categories.ToList();
                TempData["cname"] = new SelectList(cid, "Category", "Category");

                GetContext.Adding_Expenses.Add(input);
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
            else
            {
                List<AddingCategory> cid = GetContext.Adding_Categories.ToList();
                TempData["cname"] = new SelectList(cid, "Category", "Category");

                ViewBag.InsertMessage = "<script>alert('category limit check !!')</script>";
            }
            return View();

        }
        [HttpGet]
        public ActionResult Edit(int Id)

        {
            List<AddingCategory> cid = GetContext.Adding_Categories.ToList();
            TempData["cname"] = new SelectList(cid, "Category", "Category");
            var raw = GetContext.Adding_Expenses.Where(model => model.E_Id == Id).FirstOrDefault();
            return View(raw);
        }

        [HttpPost]
        public ActionResult Edit(AddingExpense input)
        {
            var getcategoryamount = GetContext.Adding_Categories.Where(x => x.Category == input.Category).FirstOrDefault();
            if (getcategoryamount.Category_Expense_Limit > input.Amount)
            {
                List<AddingCategory> cid = GetContext.Adding_Categories.ToList();
                TempData["cname"] = new SelectList(cid, "Category", "Category");

                GetContext.Entry(input).State = EntityState.Modified;
                int a = GetContext.SaveChanges();
                if (a > 0)
                {
                    TempData["update"] = "<script>alert('Data Updated !!')</script>";

                }
                else
                {
                    TempData["update"] = "<script>alert('Data not Updated !!')</script>";
                }
            }
            else
            {
                List<AddingCategory> cid = GetContext.Adding_Categories.ToList();
                TempData["cname"] = new SelectList(cid, "Category", "Category");

                ViewBag.InsertMessage = "<script>alert('category limit check !!')</script>";
            }

            return View();

        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            if(Id>0)
            {
                var catraw = GetContext.Adding_Expenses.Where(model => model.E_Id == Id).FirstOrDefault();
                if(catraw!= null)
                {
                    GetContext.Entry(catraw).State = EntityState.Deleted;
                    int a = GetContext.SaveChanges();
                    if(a>0)
                    {
                        TempData["Deleted"] = "<script>alert('Data Deleted !!')</script>";
                    }
                    else
                    {
                        TempData["Deleted"] = "<script>alert('Data not Deleted !!')</script>";
                    }
                }
            }

            return RedirectToAction("Index");
        }

       
    }
}