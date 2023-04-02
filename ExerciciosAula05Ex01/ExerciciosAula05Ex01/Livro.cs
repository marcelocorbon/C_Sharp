using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula05Ex01
{
    class Livro : Produto
    {
        public string autor { get; set; }

        public string ImprimirAutor()
        {
            return this.autor;
        }

        public Livro(string autor, string nome, float preco, float qtd)
        {
            this.autor = autor;
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public override string Imprimir()
        {
            return "Autor: " + this.autor + "\n" + "Nome: " + this.nome + "\n" + "Preço: " + this.preco + "\n" + "Quantidade: " + this.qtd;
        }
    }

}
