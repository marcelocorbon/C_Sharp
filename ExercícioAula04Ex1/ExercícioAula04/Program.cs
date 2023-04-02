using System;

namespace ExercícioAula04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Alice", "Chales", 2002, "Editora");
            Livro l2 = new Livro("Pequeno Príncipe", "Anitta", 2009, "Editora1");
            Livro l3 = new Livro("Anitta", "Juliette", 2022, "Editora2");

            Biblioteca Anitters = new Biblioteca("Os fâs de Anitta", "Rua comendador");

            Anitters.ListaLivros.Add(l1);
            Anitters.ListaLivros.Add(l2);
            Anitters.ListaLivros.Add(l3);

            Console.Write("DENTRO DA BIBLIOTECA HÁ OS LIVROS: \n");

            foreach(var i in Anitters.ListaLivros)
            {
                Console.WriteLine("LIVRO:");
                Console.WriteLine("\n");
                Console.WriteLine(i.Titulo);
                Console.WriteLine(i.Autor);
                Console.WriteLine(i.Editora);
                Console.WriteLine(i.Ano);
                Console.WriteLine("\n");
            }

        }
    }
}
