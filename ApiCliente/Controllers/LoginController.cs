using ApiCliente.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ICliente cliente;
        public LoginController(ICliente _cliente)
        {
            this.cliente = _cliente;
        }

        [HttpPost]
        public ActionResult Login (string Email, string Password)
        {
            string respuesta = cliente.Login(Email, Password);
            return Ok(respuesta);
        }
    }
}
