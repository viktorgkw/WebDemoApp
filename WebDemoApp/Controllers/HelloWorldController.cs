using Microsoft.AspNetCore.Mvc;
using WebDemoApp.Models;

namespace WebDemoApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogViewModel = new DogViewModel();

            return View(dogViewModel);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
