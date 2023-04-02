using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02
{
    public class Círculo : Forma
    {
        public float raio { get; set; }

        public override float calcularArea()
        {
            return (float)Math.PI * (raio * 2);
        }

        public override float calcularPerimetro()
        {
            return 2 * (float)Math.PI * raio;
        }
    }
}
