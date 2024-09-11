using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades
{
    public class Compra
    {
        public int Id { get; set; }
        public int IdCarrinho { get; set; }
        public int IdTransacao { get; set; }
    }
}
