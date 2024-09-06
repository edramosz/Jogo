using Dapper.Contrib.Extensions;
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
        public readonly string ConnectionString;

        public UsuarioRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Usuario g)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Usuario>(g);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Usuario novoUsuario = BuscarUsuarioPorId(id);
            connection.Delete<Usuario>(novoUsuario);
        }
        public void Editar(int id, Usuario g)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Usuario>(g);
        }
        public List<Usuario> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Usuario>().ToList();
        }
        public Usuario BuscarUsuarioPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Usuario>(id);
        }
    }
}
