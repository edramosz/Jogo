﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.DTOs
{
    public class CreateCompraDTO
    {
        public int Id { get; set; }
        public Carrinho Carrinho { get; set; }
        public Transacao Transacao { get; set; }
    }
}
