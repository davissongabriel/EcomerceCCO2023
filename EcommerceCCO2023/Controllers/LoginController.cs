using System.Linq;
using EcommerceCCO2023.Models.Login;
using EcommerceCCO2023.Models.Tabelas;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCCO2023.Controllers {
    public class LoginController : Controller {
        private readonly EcommerceCCO2023Context _db;

        public LoginController(EcommerceCCO2023Context db) {
            _db = db;
        }

        public IActionResult Index() {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Autenticar(AutenticarViewModel model) {
            if (model.Senha != null && model.Email != null) {

                var clienteEncontrado = _db.Clientes
                    .Any(cliente => cliente.Email == model.Email && cliente.Senha == model.Senha);

                if (clienteEncontrado) {
                    return RedirectToAction("Index", "Home");
                }

            } else {
                ModelState.AddModelError("Email", "É necessário informar um 'Email' e 'Senha' para autenticar no ecommerce.");

                return View("Login", model);
            }

            return View("Login");
        }

        [HttpGet]
        public IActionResult Cadastrar() {
            return View("Registrar");
        }

        [HttpPost]
        public IActionResult Registrar(LoginViewModel model) {
            if (model.Senha != null && model.Email != null) {
                var cliente = new Cliente {
                    NomeCli = model.Nome,
                    Email = model.Email,
                    Status = model.Status,
                    Senha = model.Senha
                };

                _db.Clientes.Add(cliente);

                _db.SaveChanges();

            } else {
                ModelState.AddModelError("Email", "É necessário informar um 'Email' e 'Senha' para cadastrar o cliente");

                return View("Registrar", model);
            }

            return View("Login");
        }
    }
}
