using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula05Ex01
{
    public class Cliente
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }

        public string ImprimirCliente()
        {
            return "Nome: " + this.nome + "\n" + "Endereço: " + this.endereco + "\n" + "Telefone: " + this.telefone;
        }
    }
}
