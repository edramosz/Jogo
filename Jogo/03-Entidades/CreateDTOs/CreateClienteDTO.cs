using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.DTOs
{
    public class CreateClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Senha { get; set; }
        public int IdBiblioteca { get; set; }
        public Biblioteca Biblioteca { get; set; }
        public int IdCarrinho { get; set; }
        public Carrinho Carrinho { get; set; }
    }
}
