using System;

namespace ExercícioAula04Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador Marcelinho = new Computador(500, 40, "Intelbras", 1000, "Brastemp", 50, "Consul");

            Console.WriteLine("Dados da Memoria RAM:");
            Console.WriteLine(Marcelinho.RAM.Capacidade);
            Console.WriteLine(Marcelinho.RAM.Marca);
            Console.WriteLine("\n");
            Console.WriteLine("Dados do HD:");
            Console.WriteLine(Marcelinho.HD.Capacidade);
            Console.WriteLine(Marcelinho.HD.Marca);
            Console.WriteLine("\n");
            Console.WriteLine("Dados da Placa de video:");
            Console.WriteLine(Marcelinho.Placa.Capacidade);
            Console.WriteLine(Marcelinho.Placa.Marca);
        }
    }
}
