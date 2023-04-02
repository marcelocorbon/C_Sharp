using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula05Ex01
{
    class Roupa : Produto
    {
        public float tamanho { get; set; }

        public Roupa(float tamanho, string nome, float preco, float qtd)
        {
            this.tamanho = tamanho;
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public override string Imprimir()
        {
            return "Tamanho: " + this.tamanho + "\n" + "Nome: " + this.nome + "\n" + "Preço: " + this.preco + "\n" + "Quantidade: " + this.qtd + "\n";
        }
    }
}
