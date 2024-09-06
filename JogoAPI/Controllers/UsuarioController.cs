using Jogo._01_Services;
using Jogo._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace JogoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _service;
        public UsuarioController(IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new UsuarioService(connectionString);
        }

        [HttpPost("Adicionar-Usuario")]

        public void AdicionarUsuario(Usuario t)
        {
            _service.Adicionar(t);
        }
        [HttpGet("Listar-Usuario")]

        public List<Usuario> ListarUsuario()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Usuario")]

        public void DeletarUsuario(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Usuario")]

        public void EditarUsuario(int id, Usuario Usuario)
        {
            _service.Editar(id, Usuario);
        }

        [HttpGet("Buscar-Usuario-por-Id")]

        public Usuario BuscarPorId(int id)
        {
            return _service.BuscarUsuarioPorId(id);
        }
    }
}
