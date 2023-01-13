using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class MultiModelData
    {
        public List<AddingExpense> expenses { get; set; }

        public List<AddingCategory> categories { get; set; }
    }
}