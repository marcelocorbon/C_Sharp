using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02
{
    public class Retângulo: Forma
    {
        public float lado { get; set; }
        public float altura { get; set; }

        public Retângulo(float lado, float altura)
        {
            this.lado = lado;
            this.altura = altura;
        }

        public override float calcularArea()
        {
            return lado * altura;
        }

        public override float calcularPerimetro()
        {
            return (lado * 2) + (altura * 2);
        }

    }
}
