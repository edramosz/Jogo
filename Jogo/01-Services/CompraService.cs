using AutoMapper;
using CRUD._02_Repository;
using CRUD._03_Entidades;
using CRUD._03_Entidades.DTOs;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._01_Services
{
    public class CompraService
    {
        public readonly string ConnectionString;
        public CompraRepository repository { get; set; }
        public CompraService(string connectionString, IMapper mapper) 
        {
            repository = new CompraRepository(connectionString, mapper);
        }

        public void RealizarCompra()
        {

        }
        public Compra ListarCompras()
        {

        }
        public List<Compra> BuscarCompraPorId()
        {
          
        }
    }
}
