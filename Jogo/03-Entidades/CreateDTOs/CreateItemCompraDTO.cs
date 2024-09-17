using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.DTOs
{
    public class CreateItemCompraDTO
    {
        public int ID { get; set; }
        public int JogoId { get; set; }
        public Jogo Jogo { get; set; }
        public int CarrinhoId { get; set; }
        public Carrinho Carrinho { get; set; }
    }
}
