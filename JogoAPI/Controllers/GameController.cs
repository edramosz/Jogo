using AutoMapper;
using CRUD._01_Services;
using CRUD._03_Entidades;
using CRUD._03_Entidades.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace JogoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : ControllerBase
    {
        private JogoService _service;
        public readonly string _connectionString;
        private readonly IMapper _mapper;

        public JogoController(IMapper mapper, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new JogoService(connectionString);
            _mapper = mapper;
        }

        [HttpPost("Adicionar-Jogo")]

        public void AdicionarJogo(CreateJogoDTO t)
        {
            Jogo jogo= _mapper.Map<Jogo>(t);          
            _service.Adicionar(jogo);
        }
        [HttpGet("Listar-Jogo")]

        public List<Jogo> ListarJogo()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Jogo")]

        public void DeletarJogo(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Jogo")]

        public void EditarJogo(int id, Jogo Jogo)
        {
            _service.Editar(id, Jogo);
        }

        [HttpGet("Buscar-Jogo-por-Id")]

        public Jogo BuscarPorId(int id)
        {
            return _service.BuscarJogoPorId(id);
        }
    }
}
