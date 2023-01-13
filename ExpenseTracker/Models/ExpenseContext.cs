using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExpenseTracker.Models
{
    public class ExpenseContext:DbContext
    {

        public DbSet<AddingExpense> Adding_Expenses { get; set; }
        public DbSet<AddingCategory> Adding_Categories { get; set; }

        //public DbSet<ViewExpense> GetViewExpenses { get; set; }
        //public DbSet<ViewCategory> GetViewCategories { get; set; }
    }
}