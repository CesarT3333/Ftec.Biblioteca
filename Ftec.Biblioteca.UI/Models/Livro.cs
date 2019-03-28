using System;
using System.ComponentModel.DataAnnotations;

namespace Ftec.Biblioteca.UI.Models
{
    public class Livro
    {
        public Int64 Id { get; set; }
        
        public Guid Uuid { get; set; }
        
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Isbn { get; set; }
        public int Paginas { get; set; }
        public string Editora { get; set; }
        public string Edicao { get; set; }
        public string Categoria { get; set; }

        public Livro()
        {
            Uuid = Guid.NewGuid();
        }
    }
}