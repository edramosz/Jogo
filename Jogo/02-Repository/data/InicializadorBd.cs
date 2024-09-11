using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Entidades.data
{
    public class InicializadorBd
    {
        public static void Inicializador()
        {
            //Criando conexão
            using var connection = new SQLiteConnection("Data Source=LojaJogo.db");//parâmetros da criação, nome e senha são dois exemplos
                string commandoSQL = @"
                 CREATE TABLE IF NOT EXISTS Jogos(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Preco REAL NOT NULL,
                    Genero TEXT NOT NULL,
                    Descricao TEXT NOT NULL
                );";

                commandoSQL += @"
                 CREATE TABLE IF NOT EXISTS Clientes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Idade INTEGER NOT NULL,
                    Senha TEXT NOT NULL
                );";
                connection.Execute(commandoSQL);
            }
        }
    }

