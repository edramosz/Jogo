using AutoMapper;
using CRUD._01_Services;
using CRUD._03_Entidades.DTOs;
using CRUD._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace JogoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {
        private BibliotecaService _service;
        public readonly string _connectionString;
        private readonly IMapper _mapper;

        public BibliotecaController(IMapper mapper, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new BibliotecaService(connectionString, _mapper);
            _mapper = mapper;
        }

        [HttpGet("Listar-Biblioteca")]

        public List<Biblioteca> ListarBiblioteca()
        {
            return _service.ListarBiblioteca();
        }

        [HttpGet("Buscar-Biblioteca-por-Id")]

        public Biblioteca BuscarPorId(int id)
        {
            return _service.BuscarBibliotecaPorId(id);
        }
    }
}
}
