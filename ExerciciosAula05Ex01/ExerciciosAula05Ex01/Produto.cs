using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula05Ex01
{
    public abstract class Produto
    {
        public string nome { get; set; }
        public float preco { get; set; }
        public float qtd { get; set; }

        
        
        public virtual string Imprimir()
        {
            return this.nome + this.preco + this.preco;
        }
    }
}
