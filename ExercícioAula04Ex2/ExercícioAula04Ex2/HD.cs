using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioAula04Ex2
{
    class HD
    {
        public float Capacidade { get; }
        public string Marca { get; }

        public HD(float capacidade, string marca)
        {
            this.Capacidade = capacidade;
            this.Marca = marca;
        }
    }
}
