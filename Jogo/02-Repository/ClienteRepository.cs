using CRUD._03_Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._02_Repository
{
    public class ClienteRepository
    {
        public readonly string ConnectionString;

        public ClienteRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Cliente g)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Cliente>(g);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Cliente novoCliente = BuscarClientePorId(id);
            connection.Delete<Cliente>(novoCliente);
        }
        public void Editar(int id, Cliente g)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Cliente>(g);
        }
        public List<Cliente> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Cliente>().ToList();
        }
        public Cliente BuscarClientePorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Cliente>(id);
        }
    }
}
