using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Finalizado : IEstadosDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não é possível aplicar desconto para orçamento finalizado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já foi finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O orçamento já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já foi finalizado");
        }
    }
}
