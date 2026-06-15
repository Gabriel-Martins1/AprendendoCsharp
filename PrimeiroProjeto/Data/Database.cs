using Microsoft.Data.Sqlite;

namespace ControleLocacao.Data
{
    public class Database
    {
        // caminho do arquivo do banco — fica na mesma pasta do programa
        private const string ConnectionString = "Data Source=locacao.db";

        public static SqliteConnection GetConnection()
        {
            // cria e retorna uma conexão com o banco
            return new SqliteConnection(ConnectionString);
        }

        public static void Initialize()
        {
            // cria as tabelas se ainda não existirem
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Clientes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Contato TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Itens (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    ValorPorDia REAL NOT NULL,
                    Disponivel INTEGER NOT NULL DEFAULT 1
                );

                CREATE TABLE IF NOT EXISTS Locacoes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClienteId INTEGER NOT NULL,
                    ItemId INTEGER NOT NULL,
                    DataRetirada TEXT NOT NULL,
                    DataPrevistaDevolucao TEXT NOT NULL,
                    Devolvida INTEGER NOT NULL DEFAULT 0,
                    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id),
                    FOREIGN KEY (ItemId) REFERENCES Itens(Id)
                );
            ";
            cmd.ExecuteNonQuery();
        }
    }
}