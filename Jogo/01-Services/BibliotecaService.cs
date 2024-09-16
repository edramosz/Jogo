using AutoMapper;
using CRUD._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._01_Services
{
    public class BibliotecaService
    {
        public readonly string _connectionString;
        private readonly IMapper _mapper;
        public BibliotecaService(string connectionString, IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Biblioteca> ListarBiblioteca()
        {
            //foreach(Jogo jogo in )
            //{

            //}
            return new List<Biblioteca>();
        }

        public Biblioteca ListarBibliotecaPorId()
        {
            return new Biblioteca();
        }
    }
}
