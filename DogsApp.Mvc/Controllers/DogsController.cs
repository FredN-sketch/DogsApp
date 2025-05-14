using DogsApp.Mvc.Models;
using DogsApp.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace DogsApp.Mvc.Controllers
{
    public class DogsController : Controller
    {
        static DogService dogService = new DogService();
        
        [HttpGet("")]
        public IActionResult Index()
        {
            var model = dogService.GetAllDogs();
            return View(model);
        }

        [HttpPost("")]
        public IActionResult Delete(int id)
        {
            dogService.DeleteDog(id);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dog dog)
        {
            dogService.AddDog(dog);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var dog = dogService.GetDogById(id);
            return View(dog);
        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit(Dog dog)
        {
            dogService.EditDog(dog);
            return RedirectToAction(nameof(Index));
        }
    }
}
