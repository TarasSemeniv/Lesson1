using Lesson1.Data;
using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers
{
    public class CateringEstablishmentController : Controller
    {
        private static readonly IDataBase<CateringEstablishment> _cateringDB = new CEDataBase();
        static CateringEstablishmentController()
        {
            _cateringDB.Add(new CateringEstablishment() { Name = "Name1", Place = "Place1", Grade = 4 });
            _cateringDB.Add(new CateringEstablishment() { Name = "Name2", Place = "Place2", Grade = 1 });
            _cateringDB.Add(new CateringEstablishment() { Name = "Name3", Place = "Place3", Grade = 3 });
            _cateringDB.Add(new CateringEstablishment() { Name = "Name4", Place = "Place4", Grade = 2 });
        }

        [HttpGet]
        public IActionResult GetCE()
        {
            var caterings = _cateringDB.Get();

            return View(caterings);
        }
        public IActionResult AddCE()
        {
            return View();
        }
        public IActionResult DeleteCE(int id)
        {
            var ce = _cateringDB.Get().First(x => x.Id == id);
            return View(ce);
        }
        public IActionResult EditCE(int id) => View(_cateringDB.Get().First(x => x.Id == id));
        [HttpPost]
        public IActionResult AddCE(CateringEstablishment catering)
        {
            _cateringDB.Add(catering);

            return RedirectToAction(nameof(GetCE));
        }
        [HttpPost]
        public IActionResult DeleteCE(CateringEstablishment ce)
        {
            _cateringDB.Remove(ce);
            return RedirectToAction(nameof(GetCE));
        }
        [HttpPost]
        public IActionResult EditCE(CateringEstablishment ce)
        {
            var oldCE = _cateringDB.Get().First(x => x.Id == ce.Id);
            _cateringDB.Update(oldCE, ce);
            return RedirectToAction(nameof(GetCE));
        }
    }
}
