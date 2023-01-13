using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ExpenseTracker.Models
{
    [Table("Adding_Categories")]
    public class AddingCategory
    {
        [Key]
        [Required(ErrorMessage = "Name can't be blank")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Name should be in between 4 and 25")]
        [RegularExpression(@"^(([A-za-z''-'\s]+[\s]{1}[A-za-z]+)|([A-Za-z'\s]+))$", ErrorMessage = "only insert string data")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Category_Expense_Limit can't be blank")]
        [Range(1, 100000, ErrorMessage = "Can only be between 1 .. 100000")]
        public long Category_Expense_Limit { get; set; }


    }

}