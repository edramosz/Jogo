using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.DTOs
{
    public class CreateCompraDTO
    {      
        public int IdCarrinho { get; set; }
        public int IdTransacao { get; set; }
        public int IdCliente { get; set; }
    }
}
