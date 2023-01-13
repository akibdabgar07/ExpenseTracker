using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ExpenseTracker.Models
{
    [Table("Adding_Expenses")]
    public class AddingExpense
    {
         [Key]
        public int E_Id { get; set; }

       [Required(ErrorMessage ="Name can't be blank")]
       [StringLength(25,MinimumLength =4,ErrorMessage ="Name should be in between 4 and 25")]
        [RegularExpression(@"^(([A-za-z''-'\s]+[\s]{1}[A-za-z]+)|([A-Za-z'\s]+))$", ErrorMessage = "only insert string data")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description can't be blank")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Description should be in between 4 and 50")]
       // [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "only insert string data")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "only insert string data")]
        public string Description { get; set; }

       // public Nullable<System.DateTime> Date_Time { get; set; }
          public DateTime Date_Time { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Category can't be blank")]
  

        public string Category { get; set; }


        [Required(ErrorMessage = "Amount can't be blank")]
         [Range(1,100000,ErrorMessage ="Can only be between 1 .. 100000")]       
        public long Amount { get; set; }




    }
}