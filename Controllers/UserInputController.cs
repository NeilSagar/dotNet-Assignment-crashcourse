// Controllers/UserInputController.cs
using Microsoft.AspNetCore.Mvc;
using NameFormMVCApp.Models;
using System;

namespace NameFormMVCApp.Controllers
{
    public class UserInputController : Controller
    {
        // Display the form (GET request)
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Handle form submission (POST request)
        [HttpPost]
        public IActionResult Index(UserInput userInput)
        {
            if (ModelState.IsValid)
            {
                // Print values to the console
                Console.WriteLine("First Name: " + userInput.FirstName);
                Console.WriteLine("Middle Name: " + userInput.MiddleName);
                Console.WriteLine("Last Name: " + userInput.LastName);
                Console.WriteLine("Manager Name: " + userInput.ManagerName);
                Console.WriteLine("Date: " + userInput.Date);
                Console.WriteLine("Message: " + userInput.Message);

                // Redirect to a "Success" view or the same form with a success message
                return RedirectToAction("Success");
            }
            return View(userInput);
        }

        // Display a success message after form submission
        public IActionResult Success()
        {
            return View();
        }
    }
}
