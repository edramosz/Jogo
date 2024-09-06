using Jogo._02_Repository;
using Jogo._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo._01_Services
{
    public class UsuarioService
    {
        public UsuarioRepository repository { get; set; }
        public UsuarioService(string connectionString)
        {
            repository = new UsuarioRepository(connectionString);
        }
        public void Adicionar(Usuario Usuario)
        {
            repository.Adicionar(Usuario);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public void Editar(int id, Usuario editUsuario)
        {
            repository.Editar(id, editUsuario);
        }

        public List<Usuario> Listar()
        {
            return repository.Listar();
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return repository.BuscarUsuarioPorId(id);
        }
    }
}
