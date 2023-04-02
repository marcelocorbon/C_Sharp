using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioAula04
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Editora { get; set; }

        public Livro(string nome, string autor, int ano, string editora)
        {
            this.Titulo = nome;
            this.Ano = ano;
            this.Autor = autor;
            this.Editora = editora;
        }
    }
}
