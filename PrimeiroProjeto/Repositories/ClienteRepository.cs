using Microsoft.Data.Sqlite;
using ControleLocacao.Models;
using System.Collections.Generic;

namespace ControleLocacao.Repositories
{
    public class ClienteRepository
    {
        private readonly string _connectionString = "Data Source=locacao.db";

        public void Inserir(Cliente cliente)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Clientes (Nome, Contato) VALUES (@nome, @contato)";
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@contato", cliente.Contato);
            cmd.ExecuteNonQuery();
        }

        public List<Cliente> ListarTodos()
        {
            var lista = new List<Cliente>();
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Nome, Contato FROM Clientes";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Cliente(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                ));
            }
            return lista;
        }
    }
}