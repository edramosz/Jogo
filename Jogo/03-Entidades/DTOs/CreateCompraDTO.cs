using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.DTOs
{
    public class CreateCompraDTO
    {
        public Carrinho carrinho { get; set; }
        public Transacao transacao { get; set; }
    }
}
