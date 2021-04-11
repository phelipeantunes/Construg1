using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Construg.Dominio.Entidades
{
   public abstract class Entidade
    {
        public List<string> _mensagemvalidacao { get; set; }

        protected List<string> MensagemValidacao
        {
            get { return _mensagemvalidacao ?? (_mensagemvalidacao = new List<string>()); }
        }

        public abstract void Validate();

        protected bool EhValido
        { get { return !MensagemValidacao.Any(); } }
    }
}
