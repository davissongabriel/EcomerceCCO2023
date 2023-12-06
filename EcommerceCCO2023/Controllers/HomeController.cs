using EcommerceCCO2023.Models;
using EcommerceCCO2023.Models.Tabelas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EcommerceCCO2023Context _db;


        public HomeController(ILogger<HomeController> logger, EcommerceCCO2023Context db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var testeBanco = new Cliente
            {
                NomeCli = "Daivão",
                Email = "davisson@gmail.com",
                Senha = "davisson@123",
                Status = 0 //vamos supor que isso é um status kkkk
            };


            _db.Clientes.Add(testeBanco);

            _db.SaveChanges();


            return View();
        }

        [Route("Deletar")]
        public IActionResult Deletar()
        {
            var cliente = _db.Clientes.FirstOrDefault();

            if (cliente != null)
            {
                _db.Remove(cliente);

                _db.SaveChanges();
            }

            return View("Index");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar()
        {
            var cliente = _db.Clientes.FirstOrDefault();

            if (cliente != null)
            {
                cliente.NomeCli = "luanzin do gral";

                _db.Update(cliente);

                _db.SaveChanges();
            }
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
