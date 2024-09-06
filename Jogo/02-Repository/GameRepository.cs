using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Jogo._03_Entidades;

namespace Jogo._02_Repository
{
    public class GameRepository
    {
        public readonly string ConnectionString;

        public GameRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Game g)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Game>(g);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Game novoProduto = BuscarGamePorId(id);
            connection.Delete<Game>(novoProduto);
        }
        public void Editar(int id, Game g)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Game>(g);
        }
        public List<Game> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Game>().ToList();
        }
        public Game BuscarGamePorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Game>(id);
        }
    }
}
