using System;

namespace Ex01
{
    class Disciplina
    {
        public int ID { get; set; }
        public String Nome { get; set; }

        public Disciplina(int id, String nome)
        {
            this.ID = id;
            this.Nome = nome;
        }
    }
}