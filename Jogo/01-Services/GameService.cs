using Jogo._02_Repository;
using Jogo._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo._01_Services
{
    public class GameService
    {
        public GameRepository repository { get; set; }
        public GameService(string connectionString) 
        {
            repository= new GameRepository(connectionString);
        }
        public void Adicionar(Game Game)
        {
            repository.Adicionar(Game);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public void Editar(int id, Game editGame)
        {
            repository.Editar(id, editGame);
        }

        public List<Game> Listar()
        {
            return repository.Listar();
        }

        public Game BuscarGamePorId(int id)
        {
            return repository.BuscarGamePorId(id);
        }
    }
}

