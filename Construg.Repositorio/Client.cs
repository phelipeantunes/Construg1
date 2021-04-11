using Construg.Dominio.Entidades;
using Construg.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Construg.Repositorio
{
   public class Client
    {
        public  Client()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var servico = new Service();
            var usuario = new UsuarioRepositorio();

            usuarioRepositorio.Adicionar(usuario);

        }
    }
}
