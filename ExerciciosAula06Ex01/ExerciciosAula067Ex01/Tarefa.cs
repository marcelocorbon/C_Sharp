using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula067Ex01
{
    public class Tarefa
    {
        string Titulo { get; set; }
        string Descricao { get; set; }
        string Data { get; set; }
        string Status { get; set; }
     
        public Tarefa(string titulo, string descricao, string data)
        {
            this.Data = data;
            this.Descricao = descricao;
            this.Titulo = titulo;
            this.Status = "Tarefa em andamento";
        }

        public void Concluida()
        {
            this.Status = "Concluída com sucesso"; 
        }
    }
}
