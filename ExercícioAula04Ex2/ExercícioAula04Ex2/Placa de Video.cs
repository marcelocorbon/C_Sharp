using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioAula04Ex2
{
    class Placa_de_Video
    {
        public float Capacidade { get; }
        public string Marca { get; }

        public Placa_de_Video(float capacidade, string marca)
        {
            this.Capacidade = capacidade;
            this.Marca = marca;
        }
    }
}
