using CRUD._02_Repository;
using CRUD._03_Entidades;

namespace CRUD._01_Services
{
    public class ClienteService
    {
        public ClienteRepository repository { get; set; }
        public ClienteService(string connectionString)
        {
            repository = new ClienteRepository(connectionString);
        }
        public void Adicionar(Cliente Usuario)
        {
            repository.Adicionar(Usuario);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public void Editar(int id, Cliente editUsuario)
        {
            repository.Editar(id, editUsuario);
        }

        public List<Cliente> Listar()
        {
            return repository.Listar();
        }

        public Cliente BuscarClientePorId(int id)
        {
            return repository.BuscarClientePorId(id);
        }
    }
}
