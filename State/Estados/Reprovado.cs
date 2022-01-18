using System;

namespace State.Estados
{
    public class Reprovado : EstadosDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não pode aplicar desconto em orçamento reprovado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não pode ser aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }
}
