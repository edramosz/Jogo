using Jogo._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Jogos._03_Entidades
{
    public class Carrinho
    {

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public double Soma { get; set; }
        public List<ItemCompra> ItensCompra { get; set; }
    }
}
