using Dotnet6MvcLogin.Models.Domain;
using Dotnet6MvcLogin.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dotnet6MvcLogin.Controllers
{
    public class GenreController : Controller
    {
        private readonly IBaseRepository<Genre> _genreRepos;
        public GenreController(IBaseRepository<Genre> genreRepos)
        {
            this._genreRepos = genreRepos;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Genre model)
        {
            if (!this.ModelState.IsValid)
                return View(model);
            if(_genreRepos.Create(model))
            {
                TempData["msg"] = "Added successfully";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error";
            return View(model);
        }

        public IActionResult GetAll()
        {
            var data = _genreRepos.GetAll();
            return Ok(data);
        }

       
    }
}
