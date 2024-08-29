using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo._03_Entidades.data
{
    public class InicializadorBd
    {
        public const string ConnectionString = "Data Source=LojaJogo.db";

        public static void Inicializador()
        {
            //Criando conexão
            using (var connection = new SQLiteConnection(ConnectionString))//parâmetros da criação, nome e senha são dois exemplos
            {
                connection.Open();
                string commandoSQL = @"
                 CREATE TABLE IF NOT EXISTS Jogos(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Preco REAL NOT NULL,
                    GeneroId INTEGER NOT NULL
                );";

                commandoSQL += @"
                 CREATE TABLE IF NOT EXISTS Generos(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL
                );";

                commandoSQL += @"
                 CREATE TABLE IF NOT EXISTS Usuarios(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Idade INTEGER NOT NULL,
                    Senha TEXT NOT NULL
                );";

                using (var command = new SQLiteCommand(commandoSQL, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
