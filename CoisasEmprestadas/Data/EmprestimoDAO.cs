using CoisasEmprestadas.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace CoisasEmprestadas.Data
{
    public class EmprestimoDAO
    {
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["CoisasEmprestadasConnection"].ConnectionString;

        public List<Emprestimo> ListarTodos()
        {
            var lista = new List<Emprestimo>();

            using (var conn = new SqlConnection(_connectionString))
            {
                var sql = @"SELECT Id, Item, DataEmprestimo, NomeAmigo, ContatoAmigo,
                                   DataCombinadaDevolucao, DataDevolucaoReal
                            FROM Emprestimos
                            ORDER BY DataEmprestimo DESC";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Emprestimo
                            {
                                Id = reader.GetInt32(0),
                                Item = reader.GetString(1),
                                DataEmprestimo = reader.GetDateTime(2),
                                NomeAmigo = reader.GetString(3),
                                ContatoAmigo = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                DataCombinadaDevolucao = reader.GetDateTime(5),
                                DataDevolucaoReal = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6)
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Inserir(Emprestimo e)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var sql = @"INSERT INTO Emprestimos
                                (Item, DataEmprestimo, NomeAmigo, ContatoAmigo, DataCombinadaDevolucao)
                            VALUES
                                (@Item, @DataEmprestimo, @NomeAmigo, @ContatoAmigo, @DataCombinadaDevolucao)";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Item", e.Item);
                    cmd.Parameters.AddWithValue("@DataEmprestimo", e.DataEmprestimo);
                    cmd.Parameters.AddWithValue("@NomeAmigo", e.NomeAmigo);
                    cmd.Parameters.AddWithValue("@ContatoAmigo", (object)e.ContatoAmigo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataCombinadaDevolucao", e.DataCombinadaDevolucao);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MarcarComoDevolvido(int id, DateTime dataDevolucao)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE Emprestimos
                            SET DataDevolucaoReal = @DataDevolucaoReal
                            WHERE Id = @Id";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DataDevolucaoReal", dataDevolucao);
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}