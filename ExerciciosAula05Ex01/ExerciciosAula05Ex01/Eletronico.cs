using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula05Ex01
{
    class Eletronico : Produto
    {
        public string modelo { get; set; }

        public Eletronico(string modelo, string nome, float preco, float qtd)
        {
            this.modelo = modelo;
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public override string Imprimir()
        {
            return "Modelo: " + this.modelo + "\n" + "Nome: " + this.nome + "\n" + "Preço: " + this.preco + "\n" + "Quantidade: " + this.qtd + "\n";
        }


        
    }
}
