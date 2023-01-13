Setup
  
    ASP.NET MVC Application for Visual C#
   selet mvc template
   Expense Tracker application is web app that built using the asp.net mvc framework 

 
    Select MVC for Add folders and core references for.

    ASP.NET Web Application for Visual C#
    Leave Create directory for solution unchecked.
    Create new Git repository checked.
    Select Empty template.
    Select MVC for Add folders and core references for.

Adding a Controller

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
    

Add Third Party Files

    Once you add it in the root of the project, you'll need to click on the Show All Files icon to see it in Visual Studios

//generates a link in Razor
@Html.ActionLink("Dashboard", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })

Create  Model class

name Adding

   

    

# ![Dashboard](https://user-images.githubusercontent.com/122620403/212378654-29561907-ef38-4197-beb7-71e2d66cc4d5.png)
![adding_expense](https://user-images.githubusercontent.com/122620403/212378690-e62ff977-b1f4-4419-95f8-f95281a53b1c.png)
![edit_expense](https://user-images.githubusercontent.com/122620403/212378732-def20ce9-42b5-4ac3-a1cd-262829cf449a.png)

