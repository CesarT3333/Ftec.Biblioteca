using System;
using System.Collections.Generic;
using Ftec.Biblioteca.UI.DAO;
using Ftec.Biblioteca.UI.Models;

namespace Ftec.Biblioteca.UI.BLL
{
    public class BLivro
    {
        public List<Livro> RetornarLivros()
        {
            return new LivroDao().BuscarTodosOsLivros();
        }

        public Livro buscarPorId(Int64 id)
        {
            return new LivroDao().BuscarLivroPorId(id);
        }

        public void cadastrarLivro(Livro livro)
        {
            new LivroDao().CadastrarLivro(livro);
        }
    }
}