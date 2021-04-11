using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Construg.Dominio.Entidades
{
   public class Orcamento : Entidade
    {
        public int Id { get; set; }
        public int IdService { get; set; }
        public DateTime DatadoPedido { get; set; }
        public decimal BDI { get; set; }
        public decimal LeisSocias { get; set; }
        public decimal Resultado { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime DataPrevisao { get; set; }

        //Um usuario pode ter um ou mais itens adicionados no orçamento
        public ICollection<Service> Servicos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
