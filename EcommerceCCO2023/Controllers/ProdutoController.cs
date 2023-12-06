using EcommerceCCO2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCCO2023.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult IndexProd()
        {
                return View();
           
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProdutoViewModel prod)
        {
            if (prod.Nome != null)
            {
            }          

            return RedirectToAction("IndexProd");
        }

        [HttpGet]
        public IActionResult Update(int id)
        { 
 
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, ProdutoViewModel prod)
        {

            if (prod.Nome == null)
                return View(prod);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {

            return RedirectToAction("Index", "Home");
        }
    }
}
