using System;

namespace Construg.Dominio.Entidades
{
    public abstract class Usuario : Entidade
    {
        public int id { get; set; }

        public string Email  { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                MensagemValidacao("Email nao informado");

            if (string.IsNullOrEmpty(Senha))
                MensagemValidacao("Senha nao informada");
                }
        

        protected abstract void MensagemValidacao(string v);
    }
}
