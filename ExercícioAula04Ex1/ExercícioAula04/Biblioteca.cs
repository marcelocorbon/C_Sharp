using System;
using System.Collections.Generic;
using System.Text;


namespace ExercícioAula04
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public List<Livro> ListaLivros;

        public Biblioteca(string nome, string endereco)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.ListaLivros = new List<Livro>();
        }
    }

    
}
