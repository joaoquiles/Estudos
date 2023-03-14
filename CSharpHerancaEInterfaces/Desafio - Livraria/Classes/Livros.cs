using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio___Livraria.Classes
{
    public class Livros
    {
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string Isbn { get; private set; }
        public int AnoDaPublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDePublicacao { get; set; }

        public Livros(string titulo, string isbn)
        {
            this.Titulo = titulo;
            this.Autor = isbn;
        }



    }
}
