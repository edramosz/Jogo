using CRUD._02_Repository;
using CRUD._03_Entidades;

namespace CRUD._01_Services
{
    public class JogoService
    {
        public JogoRepository repository { get; set; }
        public JogoService(string connectionString) 
        {
            repository= new JogoRepository(connectionString);
        }
        public void Adicionar(Jogo Jogo)
        {
            repository.Adicionar(Jogo);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public void Editar(int id, Jogo editJogo)
        {
            repository.Editar(id, editJogo);
        }

        public List<Jogo> Listar()
        {
            return repository.Listar();
        }

        public Jogo BuscarJogoPorId(int id)
        {
            return repository.BuscarJogoPorId(id);
        }
    }
}

