Setup
  
    ASP.NET MVC Application for Visual C#
   selet mvc template
   Expense Tracker application is web app that built using the asp.net mvc framework 
   Expense Tracker Expense Tracker is a web application built using Web API with ASP.Net MVC and Entity Framework.
   
   ( ExpenseTracker.bacpac )  this file import sql server database
   or
    (script) this script file exexute in ssms
    any one 


Technologies Used ->Visual Studio 2019 ->SQL Server 2012

NuGet packages: ->Entity Framework -
    
  CHANGE THE SERVERNAME
     <connectionStrings>
      <add name="ExpenseContext" connectionString="data source=DESKTOP-T39D065\SQLEXPRESS;    database=ExpenseTracker;persist security info=True;     Integrated Security=SSPI;" providerName="System.Data.SqlClient" />
     </connectionStrings>
   

Features ->Add, edit, and delete expenses ->View 
 
Features ->Add, edit, and delete Category ->View

Featured -> On the dashboard. the list of categories should be visible along with the list of expenses.  
           When the user clicks on any specific category, it should be highlighted and the expense list should be filtered. 
          On the dashboard itself. total expense and total expense limit should be visible.
   
Featured -> for deleting category/expense

·         A dialog/alert while deleting a category/expense

·         Validations of incorrect input
Featured ->When user adds and expense, if the category is selected then the expense should be added in that category only. If the category is not selected, then the user should be given a dropdown for selecting the category.

STRUCTURE BASED ON MVC
Adding a Controller

 Adding CategoryController.cs
 Adding ExpenseController.cs
 HomeController.cs

    Right click Controllers folder in the project > Add > Class
    Filename for a controller class must end in Controller so Visual Studio can distinguish controllers from regular classes.
    Our controller must inherit from the MVC controller base class and include using System.Web.Mvc
    Controller must be public so its accessible.
    See Controller/HomeController.cs

Adding Action Method

    Methods need to be public so its accessible.
   
 EXAMPLE
    public class Home : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    URL routing is controller/action
    ContentResult, ViewResult, and RedirectResult are a type of action result type.
    Had to modify the return type to ActionResult. In order to find out that was the correct type to return that works for both ContentResult and RedirectResult you can hover over those types and click on F12 (to view the code) or ALT+F12 (to peek the code).

Adding View

    In View folder right click Add > MVC 5 View Page (Razor) to add a view or right click on a controller method.
    You may need to create a folder for each controller and have the view be inside that folder. See Views/.cshtml files
    Razor is a view language allowing you to create views by combining C# and HMTL.
    For Razor, you can edit without having to recompile.
    

USE CSS, JavaScript ,jQuery 

//generates a link in Razor
@Html.ActionLink("Dashboard", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })

Create  Model class

AddingCategory.cs
AddingExpense.cs
ExpenseContext.cs
MultiModelData.cs

   

    

# ![Dashboard](https://user-images.githubusercontent.com/122620403/212378654-29561907-ef38-4197-beb7-71e2d66cc4d5.png)
![adding_expense](https://user-images.githubusercontent.com/122620403/212378690-e62ff977-b1f4-4419-95f8-f95281a53b1c.png)
![edit_expense](https://user-images.githubusercontent.com/122620403/212378732-def20ce9-42b5-4ac3-a1cd-262829cf449a.png)

