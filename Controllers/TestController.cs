using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TestController : Controller
    {
        [HttpPost("/Authentication")]
        public IActionResult Login(string usuario, string contraseña)
        {
            // Verificar si el usuario y la contraseña son correctos para el administrador
            if (usuario == "user" && contraseña == "user12345")
            {
                return Ok(new { message = "Inicio de sesión exitoso" });
            }

            return Unauthorized(new { message = "Credenciales incorrectas" });

        }
    }
}
