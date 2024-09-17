using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.DTOs
{
    public class CreateBibliotecaDTO
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<Jogo> Biblioteca { get; set; }
    }
}
