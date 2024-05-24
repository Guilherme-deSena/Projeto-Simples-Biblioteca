using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca
{
    static class Database
    {
        public static List<Biblioteca> BibliotecaQuery()
        {
            string query = "SELECT * FROM Biblioteca";
            string connectionString = "server=localhost;user=root;password=root;database=bibliotecas";
            MySqlConnection connection = new MySqlConnection(connectionString);
            List<Biblioteca> bibliotecasList = [];

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Biblioteca biblioteca = new Biblioteca();

                    biblioteca.BibliotecaId = reader.GetInt32("id");
                    biblioteca.Nome = reader.GetString("nome");
                    biblioteca.Endereco = reader.GetString("endereco");

                    bibliotecasList.Add(biblioteca);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Erro ocorrido: {e.Message}");
            }

            connection.Close();
            return bibliotecasList;
        }

        public static List<Livro> LivroQuery()
        {
            string query = "SELECT * FROM Livro JOIN Biblioteca ON Livro.id_biblioteca = Biblioteca.id";
            string connectionString = "server=localhost;user=root;password=root;database=bibliotecas";
            List<Livro> livrosList = [];
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Livro livro = new Livro();

                    livro.LivroId = reader.GetInt32("id");
                    livro.Titulo = reader.GetString("titulo");
                    livro.Autor = reader.GetString("autor");
                    livro.Ano = reader.GetInt32("ano");
                    livro.BibliotecaId = reader.GetInt32("id_biblioteca");
                    livro.BibliotecaNome = reader.GetString("nome");

                    livrosList.Add(livro);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Erro ocorrido: {e.Message}");
            }

            connection.Close();
            return livrosList;
        }

        public static void InserirBiblioteca(string nome, string endereco)
        {
            string connectionString = "server=localhost;user=root;password=root;database=bibliotecas";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string insert = $"INSERT INTO Biblioteca (nome, endereco) VALUES ('{nome}', '{endereco}')";
                MySqlCommand command = new MySqlCommand(insert, connection);
                command.ExecuteNonQuery();
            } catch (Exception e)
            {
                Debug.WriteLine($"Erro ocorrido: {e.Message}");
            }
        }

        public static void InserirLivro(string titulo, string autor, int ano, int idBiblioteca)
        {
            string connectionString = "server=localhost;user=root;password=root;database=bibliotecas";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string insert = $"INSERT INTO Livro (titulo, autor, ano, id_biblioteca) VALUES ('{titulo}', '{autor}', {ano}, {idBiblioteca})";
                MySqlCommand command = new MySqlCommand(insert, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Erro ocorrido: {e.Message}");
            }
        }

        public static int ObterBibliotecaId(string nomeBiblioteca)
        {
            string query = $"SELECT id FROM Biblioteca WHERE nome = '{nomeBiblioteca}'";
            string connectionString = "server=localhost;user=root;password=root;database=bibliotecas";
            List<Livro> livrosList = [];
            MySqlConnection connection = new MySqlConnection(connectionString);

            int idBiblioteca = -1;

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    idBiblioteca = reader.GetInt32("id");
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Erro ocorrido: {e.Message}");
            }

            connection.Close();

            return idBiblioteca;
        }
    }

    public class Biblioteca
    {
        public int BibliotecaId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }

    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public int BibliotecaId { get; set; }
        public string BibliotecaNome { get; set; }
    }
}
