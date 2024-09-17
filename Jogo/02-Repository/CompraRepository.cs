using AutoMapper;
using CRUD._03_Entidades;
using CRUD._03_Entidades.DTOs;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._02_Repository
{
    public class CompraRepository
    {
        private readonly string ConnectionString;
        private readonly IMapper _mapper;
        private readonly CarrinhoRepository _repositoryCarrinho;
        private readonly TransacaoRepository _repositoryTransacao;
        private readonly ClienteRepository _repositoryCliente;

        public CompraRepository(string connectionString, IMapper mapper)
        {
            ConnectionString = connectionString;
            _mapper = mapper;
        }
        public void RealizarCompra(Compra c)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Compra>(c);
        }

        public List<CreateCompraDTO> ListarCompras()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Compra> compras = connection.GetAll<Compra>().ToList();
            List<CreateCompraDTO> comprasDTO = new List<CreateCompraDTO>();//_mapper.Map<List<ReadRotinaDTO>>(lista);
            foreach (Compra c in compras)
            {
                CreateCompraDTO compraDTO = new CreateCompraDTO();
                compraDTO.IdCarrinho = c.IdCarrinho;
                compraDTO.IdTransacao = c.IdTransacao;
                compraDTO.IdCliente = c.IdCliente;

                comprasDTO.Add(compraDTO);
            }
            return comprasDTO;
        }
    }
}
