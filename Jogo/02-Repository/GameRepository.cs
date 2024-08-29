using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo._03_Entidades;

namespace Jogo._02_Repository
{
    public class GameRepository
    {
        public const string ConnectionString = "Data Source=LojaJogo.db";

        public void Adicionar(Game g)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string comandInsert = @"INSERT INTO Jogos(Nome, Preco, Descricao, GeneroId) VALUES (@Nome, @Preco, @Descricao)";

                using (var command = new SQLiteCommand(comandInsert, connection))
                {
                    command.Parameters.AddWithValue("@Nome", g.Nome);
                    command.Parameters.AddWithValue("@Preco", g.Preco);
                    command.Parameters.AddWithValue("@Descricao", g.Descricao);
                    command.Parameters.AddWithValue("@GeneroId", g.GeneroId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Remover(int id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string deleteCommand = "DELETE FROM Jogos WHERE Id = @Id";
                using (var command = new SQLiteCommand(deleteCommand, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Editar(int id, Game g)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string updateCommand = @"UPDATE Jogos
                                   SET Nome = @Nome, Preco = @Preco, Descricao = @Descricao, GeneroId = @GeneroId
                                   WHERE Id = @Id";
                using (var command = new SQLiteCommand(updateCommand, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nome", g.Nome);
                    command.Parameters.AddWithValue("@Preco", g.Preco);
                    command.Parameters.AddWithValue("@Descricao", g.Descricao);
                    command.Parameters.AddWithValue("@GeneroId", g.GeneroId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Game> Listar()
        {
            List<Game> jogos = new List<Game>();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectCommand = "SELECT Id, Nome, Preco, Descricao, GeneroId FROM Jogos";
                using (var command = new SQLiteCommand(selectCommand, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Game g = new Game();
                            g.Id = int.Parse(reader["Id"].ToString());
                            g.Nome = reader["Nome"].ToString();
                            g.Preco = int.Parse(reader["Preco"].ToString());
                            g.Descricao = reader["Descricao"].ToString();
                            g.GeneroId = int.Parse(reader["GeneroId"].ToString());
                            jogos.Add(g);
                        }
                    }
                }
                return jogos;
            }
        }
        public Game BuscarGamePorId(int id)
        {
            Game g = new Game();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectCommand = "SELECT Id, Nome, Preco, Descricao, GeneroId FROM Jogos WHERE Id = @Id";
                using (var command = new SQLiteCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            g.Id = int.Parse(reader["Id"].ToString());
                            g.Nome = reader["Nome"].ToString();
                            g.Preco = int.Parse(reader["Preco"].ToString());
                            g.Descricao = reader["Descricao"].ToString();
                            g.GeneroId = int.Parse(reader["GeneroId"].ToString());
                        }
                    }
                }
            }
            return g;
        }
    }
}
