using System;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Retângulo retângulo = new Retângulo(4, 2);
            Círculo círculo = new Círculo();
            Quadrado quadrado = new Quadrado(3);

            círculo.raio = 5;

            Console.WriteLine("----- RETÂNGULO -----");
            Console.WriteLine("O lado deste retângulo é: " + retângulo.lado);
            Console.WriteLine("A altura é: " + retângulo.altura);
            Console.WriteLine("Portanto, sua área é: " + retângulo.calcularArea() +
                " e seu perímetro é: " + retângulo.calcularPerimetro());

            Console.WriteLine("\n");

            Console.WriteLine("----- CÍRCULO -----");
            Console.WriteLine("O raio deste círculo é: " + círculo.raio);
            Console.WriteLine("Portanto, sua área é: " + círculo.calcularArea());

            Console.WriteLine("\n");

            Console.WriteLine("----- QUADRADO -----");
            Console.WriteLine("O lado deste quadrado é: " + quadrado.lado);
            Console.WriteLine("A altura é: " + quadrado.altura); 
            Console.WriteLine("Portanto, sua área é: " + quadrado.calcularArea() +
                " e seu perímetro é: " + quadrado.calcularPerimetro());

        }
    }
}
