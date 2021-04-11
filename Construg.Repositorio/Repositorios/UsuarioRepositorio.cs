using Construg.Dominio.Contratos;
using Construg.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Construg.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, Iusuario
    {
        public UsuarioRepositorio()
        {

        }

        public void Adicionar(Iusuario entity)
        {
            throw new NotImplementedException();
        }

        public Iusuario Atualizar(Iusuario entity)
        {
            throw new NotImplementedException();
        }

        public Iusuario Remover(Iusuario entity)
        {
            throw new NotImplementedException();
        }

        internal void Adicionar(UsuarioRepositorio usuario)
        {
            throw new NotImplementedException();
        }

        Iusuario IBaserepositorio<Iusuario>.ObterporId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Iusuario> IBaserepositorio<Iusuario>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
