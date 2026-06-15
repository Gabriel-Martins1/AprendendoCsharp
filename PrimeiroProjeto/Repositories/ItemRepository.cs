using Microsoft.Data.Sqlite;
using ControleLocacao.Models;
using System.Collections.Generic;

namespace ControleLocacao.Repositories
{
    public class ItemRepository
    {
        private readonly string _connectionString = "Data Source=locacao.db";

        public void Inserir(Item item)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Itens (Nome, ValorPorDia, Disponivel) VALUES (@nome, @valor, @disp)";
            cmd.Parameters.AddWithValue("@nome", item.Nome);
            cmd.Parameters.AddWithValue("@valor", item.ValorPorDia);
            cmd.Parameters.AddWithValue("@disp", item.Disponivel ? 1 : 0);
            cmd.ExecuteNonQuery();
        }

        public List<Item> ListarTodos()
        {
            var lista = new List<Item>();
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Nome, ValorPorDia, Disponivel FROM Itens";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new Item(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetDecimal(2)
                );
                item.Disponivel = reader.GetInt32(3) == 1;
                lista.Add(item);
            }
            return lista;
        }

        public void AtualizarDisponibilidade(int id, bool disponivel)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Itens SET Disponivel = @disp WHERE Id = @id";
            cmd.Parameters.AddWithValue("@disp", disponivel ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}