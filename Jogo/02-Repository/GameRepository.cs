using System.Data.SQLite;
using CRUD._03_Entidades;
using Dapper.Contrib.Extensions;

namespace CRUD._02_Repository
{
    public class JogoRepository
    {
        public readonly string ConnectionString;

        public JogoRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Jogo g)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Jogo>(g);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Jogo novoProduto = BuscarJogoPorId(id);
            connection.Delete<Jogo>(novoProduto);
        }
        public void Editar(int id, Jogo g)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Jogo>(g);
        }
        public List<Jogo> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Jogo>().ToList();
        }
        public Jogo BuscarJogoPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Jogo>(id);
        }
    }
}
