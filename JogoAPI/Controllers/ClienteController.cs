using AutoMapper;
using CRUD._01_Services;
using CRUD._03_Entidades;
using CRUD._03_Entidades.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace JogoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private ClienteService _service;
        private readonly IMapper _mapper;
        public ClienteController(IMapper mapper, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new ClienteService(connectionString);
            _mapper = mapper;
        }

        [HttpPost("Adicionar-Cliente")]

        public void AdicionarCliente(CreateClienteDTO c)
        {
            Cliente cliente = _mapper.Map<Cliente>(c);
            _service.Adicionar(cliente);
        }
        [HttpGet("Listar-Cliente")]

        public List<Cliente> ListarCliente()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Cliente")]

        public void DeletarCliente(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Cliente")]

        public void EditarCliente(int id, Cliente Cliente)
        {
            _service.Editar(id, Cliente);
        }

        [HttpGet("Buscar-Cliente-por-Id")]

        public Cliente BuscarPorId(int id)
        {
            return _service.BuscarClientePorId(id);
        }
    }
}
