using AutoMapper;
using CRUD._01_Services;
using CRUD._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace JogoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompraController : ControllerBase
    {
        private CompraService _service;
        public readonly string _connectionString;
        private readonly IMapper _mapper;

        public CompraController(IMapper mapper, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new CompraService(connectionString, mapper);
            _mapper = mapper;
        }

        [HttpGet("Listar-Compras")]

        public List<Compra> ListarBiblioteca()
        {
            return _service.ListarCompras();
        }

        [HttpGet("Buscar-Compra-por-Id")]

        public Compra BuscarPorId(int id)
        {
            return _service.BuscarCompraPorId(id);
        }
    }
}
