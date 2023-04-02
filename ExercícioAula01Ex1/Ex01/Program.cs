using System;
using System.Collections.Generic;

namespace Ex01
{
    class Program
    {

        static void Main(string[] args)
        {
            // CRIANDO OS ALUNOS

            Aluno a1 = new Aluno("Marcelo", 111790, "Masculino");
            Aluno a2 = new Aluno("Selena Gomez", 116890, "Feminino");
            Aluno a3 = new Aluno("Ariana Grande", 345908, "Feminino");
            Aluno a4 = new Aluno("Miley Cyrus", 213453, "Feminino");
            Aluno a5 = new Aluno("Demi Lovato", 189238, "Feminino");

            // CRIANDO AS DISCIPLINAS

            Disciplina b1 = new Disciplina(01, "Português");
            Disciplina b2 = new Disciplina(02, "Matemática");
            Disciplina b3 = new Disciplina(03, "Ciências");
            Disciplina b4 = new Disciplina(04, "História");
            Disciplina b5 = new Disciplina(05, "Geografia");

            // LISTA DO PRIMEIRO ALUNO

            a1.Disciplinas.Add(b1);
            a1.Disciplinas.Add(b2);

            // LISTA DO SEGUNDO ALUNO

            a2.Disciplinas.Add(b1);
            a2.Disciplinas.Add(b2);
            a2.Disciplinas.Add(b3);
            a2.Disciplinas.Add(b4);
            a2.Disciplinas.Add(b5);

            // LISTA DO TERCEIRO ALUNO
            a3.Disciplinas.Add(b3);
            a3.Disciplinas.Add(b4);
            a3.Disciplinas.Add(b5);

            a3 = a2;
            b4 = b1;
            b5 = b1;


            b5.Nome = "Diego";
            a2.Disciplinas[2].Nome = "Como ser igual a Pipokinha";

            Console.WriteLine(a2.Disciplinas[2].Nome);
        }
}
}
