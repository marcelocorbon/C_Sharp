using System;
using System.Collections.Generic;

namespace ExerciciosAula067Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tarefa> Lista = new List<Tarefa>();

            Console.WriteLine("---------------------");
            Console.WriteLine("       MENU");
            Console.WriteLine("---------------------");
            Console.WriteLine("1 - CRIAR TAREFA");
            Console.WriteLine("2 - EDITAR TAREFA");
            Console.WriteLine("3 - REMOVER TAREFA");
            Console.WriteLine("1 - CONCLUIR TAREFA");
            Console.WriteLine("---------------------");

            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1 {
                        Tarefa t1 = new Tarefa("Beber água", "Beber agua a cada 2hs", "11/06/2023");
                        Lista.Add(t1);
    }
            }



           
        }
    }
}
