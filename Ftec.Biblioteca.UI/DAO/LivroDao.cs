using System;
using System.Collections.Generic;
using System.IO;
using Ftec.Biblioteca.UI.Models;
using Ftec.Biblioteca.UI.utils;
using Newtonsoft.Json;
using Npgsql;

namespace Ftec.Biblioteca.UI.DAO
{
    public class LivroDao
    {
        public List<Livro> BuscarTodosOsLivros()
        {
            List<Livro> listLivros = new List<Livro>();

            String connString = CredentialsUtils.getPostgresConnectionString();

            try
            {
                using (var conn =
                    new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT id, titulo FROM \"Livros\"", conn))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            Livro livro = new Livro();

                            livro.Id = (Int64) reader["id"];
                            livro.Titulo = reader.GetString(1);

                            listLivros.Add(livro);
                        }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("============");
                Console.WriteLine(ex);
                Console.WriteLine("============");
                string teste = ex.Message;
            }

            return listLivros;
        }

        public Livro BuscarLivroPorId(Int64 id)
        {
            var livro = new Livro();

            using (var conn = new NpgsqlConnection(""))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM \"Livros\" WHERE id =" + id, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        livro.Titulo = reader.GetString(1);
                    }

                return livro;
            }
        }

        public void CadastrarLivro(Livro livro)
        {
        }
    }
}