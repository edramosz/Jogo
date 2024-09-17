using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.DTOs
{
    public class CreateItemBibliotecaDTO
    {
        public int Id { get; set; }
        public int IdBiblioteca { get; set; }
        public Biblioteca Biblioteca { get; set; }
    }
}
