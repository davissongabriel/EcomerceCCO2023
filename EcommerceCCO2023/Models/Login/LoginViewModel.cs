using EcommerceCCO2023.Modelo.Enums;

namespace EcommerceCCO2023.Models.Login {
    public class LoginViewModel {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public StatusCliente Status => StatusCliente.Ativo;
    }
}
