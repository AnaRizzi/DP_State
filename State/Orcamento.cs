using State.Estados;
using System.Collections.Generic;

namespace State
{
    public class Orcamento
    {
        public EstadosDeUmOrcamento Estado { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            //define o primeiro estado:
            Estado = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            Estado.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            Estado.Aprova(this);
        }

        public void Reprova()
        {
            Estado.Reprova(this);
        }

        public void Finaliza()
        {
            Estado.Finaliza(this);
        }
    }
}
