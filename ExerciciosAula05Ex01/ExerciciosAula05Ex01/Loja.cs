using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula05Ex01
{
    public class Loja
    {
        public List<Cliente> ListaCliente;
        public List<Pedido> ListaPedido;
        public List<Produto> ListaProduto;

        public Loja()
        {
            this.ListaCliente = new List<Cliente>();
            this.ListaPedido = new List<Pedido>();
            this.ListaProduto = new List<Produto>();
        }

        public void AddCliente(Cliente cliente)
        {
            this.ListaCliente.Add(cliente);
        }

        public void AddPedido(Pedido pedido, Pagamento_Interface pagamento)
        {
            pedido.tipoPagamento = pagamento;
            this.ListaPedido.Add(pedido);
        }

        public void ImprimirCliente()
        {
            foreach (var Cliente in ListaCliente)
            {
                Console.WriteLine(Cliente.ImprimirCliente());
            }
        }

        public void ImprimirPedido()
        {
            foreach (var Pedido in ListaPedido)
            {
                Console.WriteLine(Pedido.tipoPagamento.receberPagamento());
                Console.WriteLine(Pedido.cliente.nome + " - " + Pedido.total);
                Console.WriteLine(Pedido.tipoPagamento.processarPagamento());
            }
        }


    }
}


