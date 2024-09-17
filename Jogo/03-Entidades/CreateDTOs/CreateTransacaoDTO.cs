using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.DTOs
{
    public class CreateTransacaoDTO
    {
        public int Id { get; set; }
        public int IdCompra { get; set; }
        public Compra Compra { get; set; }
        public DataType Data { get; set; }
        public int Parcelamento { get; set; }
        public string MetodoPagamento { get; set; }
    }
}
