using AutoMapper;
using CRUD._03_Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._02_Repository
{
    public class TransacaoRepository
    {
        public readonly string ConnectionString;
        public readonly IMapper _mapper;

        public TransacaoRepository(string connectionString, IMapper mapper)
        {
            ConnectionString = connectionString;
            _mapper = mapper;
        }

        public void AdicionarTransacaoCarrinho(Transacao t)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Transacao>(t);
        }
        public Transacao BuscarTransacaoPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Transacao>(id);
        }
    }
}
