﻿namespace Construg.Dominio.Entidades
{
    public abstract class Usuario
    {
        public int id { get; set; }

        public string Email  { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

    }
}
