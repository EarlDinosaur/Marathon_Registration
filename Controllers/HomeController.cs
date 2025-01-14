using System.Diagnostics;
using Marathon_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Marathon_Registration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // A static list to store registrations
        private static List<UserModel> registrations = new();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Index action - renders the home page
        public IActionResult Index()
        {
            return View();
        }

        // GET: Privacy (Registration form)
        public IActionResult Privacy()
        {
            return View(new UserModel());
        }

        // POST: Privacy (Handle form submission)
        [HttpPost]
        public IActionResult Privacy(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, redisplay the form with validation errors
                return View(model);
            }

            // Add the validated model to the registrations list
            registrations.Add(model);

            // Redirect to the ViewRegistration page
            return RedirectToAction("ViewRegistration");
        }

        // GET: ViewRegistration (List of registered users)
        public IActionResult ViewRegistration()
        {
            return View(registrations); // Pass the list to the view
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
