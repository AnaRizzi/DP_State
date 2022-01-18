using System;

namespace State.Estados
{
    public class Finalizado : EstadosDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não pode aplicar desconto em orçamento finalizado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
    }
}
