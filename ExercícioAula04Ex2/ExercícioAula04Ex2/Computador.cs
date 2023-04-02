using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioAula04Ex2
{
    class Computador
    {
        public MemoriaRAM RAM;
        public HD HD;
        public Placa_de_Video Placa;

        public Computador(float capacidade, float frequencia, string marca, float capacidadehd, string marcahd, float capacidadeplaca, string marcaplaca)
        {
            this.RAM = new MemoriaRAM(capacidade, frequencia, marca);
            this.HD = new HD(capacidadehd, marcahd);
            this.Placa = new Placa_de_Video(capacidadeplaca, marcaplaca);
        }
    }
}
