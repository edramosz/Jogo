using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades
{
    public class Biblioteca
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public List<Jogo> JogosComprados { get; set; }
    }
}
