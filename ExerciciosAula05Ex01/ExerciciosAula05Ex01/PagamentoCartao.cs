using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAula05Ex01
{
    public class PagamentoCartao : Pagamento_Interface
    {

        public int cartao;
        public string validade;
        public int seg;
        public string processarPagamento()
        {
            return "Pagamento aceito com sucesso";
        }

        public string receberPagamento()
        {
            return "Pagamento recebido com sucesso";
        }
    }
}
