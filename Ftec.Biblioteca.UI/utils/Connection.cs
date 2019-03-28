using System;
using System.Data;
using Npgsql;

namespace Ftec.Biblioteca.UI.utils
{
    public class Connection
    {
        const string connString =
            "";

        public static void doConnection(string command)
        {
            Console.WriteLine(command);
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id, titulo  FROM  \"Livros\" ", conn);

//            cmd.CommandType = CommandType.TableDirect;

//            try
//            {
//                conn.Open();
//
//                var reader = cmd.ExecuteReaderAsync();
//
//                return reader;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("=============");
//                Console.WriteLine("=============");
//                Console.WriteLine(ex);
//                Console.WriteLine("=============");
//                Console.WriteLine("=============");
//                return null;
//            }
//            finally
//            {
//                conn.Close();
//            }
        }
    }
}