using System;

namespace State.Estados
{
    public class EmAprovacao : EstadosDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado");
        }
    }
}
