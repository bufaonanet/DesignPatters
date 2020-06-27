using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Reprovado : IEstadosDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não é possível aplicar desconto para orçamento " +
                " reprovado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já foi reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado(); 
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já está reprovado");
        }
    }
}
