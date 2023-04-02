using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Aluno
    {
        public String Nome { get; set; }
        public int RA { get; set; }
        public String Sexo { get; set; }

        public List<Disciplina> Disciplinas;

        public Aluno(String nome, int ra, String sexo)
        {
            this.Nome = nome;
            this.RA = ra;
            this.Sexo = sexo;
            this.Disciplinas = new List<Disciplina>();
        }
        

    }
}