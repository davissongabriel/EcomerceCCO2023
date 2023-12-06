using EcommerceCCO2023.Models;
using EcommerceCCO2023.Models.Tabelas;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EcommerceCCO2023.Controllers
{
    public class ClienteViewModelController : Controller
    {
        private readonly EcommerceCCO2023Context _db;

        public ClienteViewModelController(EcommerceCCO2023Context db)
        {
            _db = db;
        }

        public IActionResult IndexCli()
        {
            return View("IndexCli", new ClienteViewModel{});
        }

        public IActionResult CreateCli()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCli(ClienteViewModel model)
        {
            if (model.NomeCli != null)
            {
                var clienteCadastrar = new Cliente
                {
                    IdCliente = model.IdCliente,
                    NomeCli = model.NomeCli
                    //preencher todos
                };

                _db.Clientes.Add(clienteCadastrar);

                _db.SaveChanges();
            }

            return RedirectToAction("IndexCli");
        }

        [HttpGet]
        public IActionResult UpdateCli(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCli(int id, ClienteViewModel model)
        {
            if (model.NomeCli == null) {
                var clienteAtualizar = _db.Clientes.FirstOrDefault(f => f.IdCliente == id);


                clienteAtualizar.NomeCli = model.NomeCli;
                //preencher todos


                _db.Update(clienteAtualizar);

                _db.SaveChanges();
            }

            return View(model);
        }

        public IActionResult DeleteCli(int id)
        {
            return RedirectToAction("IndexCli");
        }
    }
}
