using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula05Ex01
{
    public class Pedido
    {
        public List<Produto> ListaProduto;
        public Cliente cliente;
        public float total;
        public Pagamento_Interface tipoPagamento { get; set; }

        public Pedido(string nome, string endereco, string telefone)
        {
            this.cliente = new Cliente();
            this.ListaProduto = new List<Produto>();
            this.cliente.nome = nome;
            this.cliente.endereco = endereco;
            this.cliente.telefone = telefone;
        }

        public float CalcularPedido()
        {
            this.total = 0;

            foreach (var Produto in this.ListaProduto)
            {
                this.total = this.total + Produto.preco;
            }
            return this.total;
        }

    }
}
