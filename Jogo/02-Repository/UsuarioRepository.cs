using Jogo._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo._02_Repository
{
    public class UsuarioRepository
    {
        public const string ConnectionString = "Data Source=LojaJogo.db";

        public void Adicionar(Usuario u)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string comandInsert = @"INSERT INTO Usuarios(Nome, Idade, Senha) VALUES (@Nome, @Idade, @Senha)";

                using (var command = new SQLiteCommand(comandInsert, connection))
                {
                    command.Parameters.AddWithValue("@Nome", u.Nome);
                    command.Parameters.AddWithValue("@Preco", u.Idade);
                    command.Parameters.AddWithValue("@Descricao", u.Senha);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Remover(int id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string deleteCommand = "DELETE FROM Usuarios WHERE Id = @Id";
                using (var command = new SQLiteCommand(deleteCommand, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Editar(int id, Usuario u)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string updateCommand = @"UPDATE Usuarios
                                   SET Nome = @Nome, Idade = @Idade, Senha = @Senha
                                   WHERE Id = @Id";
                using (var command = new SQLiteCommand(updateCommand, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nome", u.Nome);
                    command.Parameters.AddWithValue("@Idade", u.Idade);
                    command.Parameters.AddWithValue("@Senha", u.Senha);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectCommand = "SELECT Id, Nome, Idade, Senha FROM Usuarios";
                using (var command = new SQLiteCommand(selectCommand, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario u = new Usuario();
                            u.Id = int.Parse(reader["Id"].ToString());
                            u.Nome = reader["Nome"].ToString();
                            u.Idade = int.Parse(reader["Idade"].ToString());
                            u.Senha = reader["Senha"].ToString();
                            usuarios.Add(u);
                        }
                    }
                }
                return usuarios;
            }
        }
        public Usuario BuscarUsuarioPorId(int id)
        {
            Usuario u = new Usuario();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectCommand = "SELECT Id, Nome, Idade, Senha FROM Usuarios WHERE Id = @Id";
                using (var command = new SQLiteCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            u.Id = int.Parse(reader["Id"].ToString());
                            u.Nome = reader["Nome"].ToString();
                            u.Idade = int.Parse(reader["Idade"].ToString());
                            u.Senha = reader["Senha"].ToString();
                        }
                    }
                }
            }
            return u;
        }
    }
}
