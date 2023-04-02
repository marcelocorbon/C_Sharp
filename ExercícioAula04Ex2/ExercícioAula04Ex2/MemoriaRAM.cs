using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioAula04Ex2
{
    public class MemoriaRAM
    {
        public float Capacidade { get; }
        public float Freq { get; }
        public string Marca { get; }

        public MemoriaRAM(float capacidade, float frequencia, string marca)
        {
            this.Capacidade = capacidade;
            this.Freq = frequencia;
            this.Marca = marca;
        }
    }
}
