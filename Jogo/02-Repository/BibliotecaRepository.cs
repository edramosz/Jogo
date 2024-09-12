using CRUD._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._02_Repository
{
    public class BibliotecaRepository
    {
        public readonly string ConnectionString;
        public Biblioteca ListarBibliotecaPorId(int IdBiblioteca)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Biblioteca>(IdBiblioteca);
        }
    }
}
