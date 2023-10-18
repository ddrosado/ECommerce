using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class CategoryController : Controller // Declare a class named CategoryController that inherits from the Controller class.
    {
        private readonly ApplicationDbContext _db;
        // Declare a private, read-only field named '_db' of type 'ApplicationDbContext'.
        // This field will store a reference to the application's database context.

        public CategoryController(ApplicationDbContext db)
        {
            // Define the constructor for the CategoryController class, which takes an 'ApplicationDbContext' instance as a parameter.
            // The constructor will be used to inject the database context into the controller.

            _db = db;
            // Initialize the private '_db' field with the provided database context instance.
        }

        public IActionResult Index()
        {
            // Define an action method named 'Index' that returns an 'IActionResult'.
            // This method is responsible for handling requests to the 'Index' page for categories.

            var objCategoryList = _db.Categories.ToList();

            return View();
            // Return a view as the result of this action method. In this case, 'View()' returns the default view associated with this action.
        }
    }
}

