using Microsoft.Data.Sqlite;
using ControleLocacao.Models;
using System.Collections.Generic;

namespace ControleLocacao.Repositories
{
    public class LocacaoRepository
    {
        private readonly string _connectionString = "Data Source=locacao.db";

        public void Inserir(Locacao locacao)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Locacoes 
                (ClienteId, ItemId, DataRetirada, DataPrevistaDevolucao, Devolvida) 
                VALUES (@clienteId, @itemId, @retirada, @devolucao, @devolvida)";
            cmd.Parameters.AddWithValue("@clienteId", locacao.Cliente.Id);
            cmd.Parameters.AddWithValue("@itemId", locacao.Item.Id);
            cmd.Parameters.AddWithValue("@retirada", locacao.DataRetirada.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@devolucao", locacao.DataPrevistaDevolucao.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@devolvida", locacao.Devolvida ? 1 : 0);
            cmd.ExecuteNonQuery();
        }

        public List<Locacao> ListarAtivas(List<Cliente> clientes, List<Item> itens)
        {
            var lista = new List<Locacao>();
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, ClienteId, ItemId, DataRetirada, DataPrevistaDevolucao FROM Locacoes WHERE Devolvida = 0";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int clienteId = reader.GetInt32(1);
                int itemId = reader.GetInt32(2);

                var cliente = clientes.Find(c => c.Id == clienteId);
                var item = itens.Find(i => i.Id == itemId);

                if (cliente != null && item != null)
                {
                    var loc = new Locacao(
                        reader.GetInt32(0),
                        cliente,
                        item,
                        DateTime.Parse(reader.GetString(3)),
                        DateTime.Parse(reader.GetString(4))
                    );
                    lista.Add(loc);
                }
            }
            return lista;
        }

        public void RegistrarDevolucao(int id)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Locacoes SET Devolvida = 1 WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}