using Jogo._01_Services;
using Jogo._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace JogoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private GameService _service;
        public readonly string _connectionString;

        public GameController(IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new GameService(connectionString);
        }

        [HttpPost("Adicionar-Game")]

        public void AdicionarGame(Game t)
        {
            _service.Adicionar(t);
        }
        [HttpGet("Listar-Game")]

        public List<Game> ListarGame()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Game")]

        public void DeletarGame(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Game")]

        public void EditarGame(int id, Game Game)
        {
            _service.Editar(id, Game);
        }

        [HttpGet("Buscar-Game-por-Id")]

        public Game BuscarPorId(int id)
        {
            return _service.BuscarGamePorId(id);
        }
    }
}
