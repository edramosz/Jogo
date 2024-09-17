using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.ReadDTOs
{
    public class ReadCompraDTO
    {
        public int Id { get; set; }
        public int IdCarrinho { get; set; }
        public int IdTransacao { get; set; }
        public Transacao Transacao { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
    }
}
