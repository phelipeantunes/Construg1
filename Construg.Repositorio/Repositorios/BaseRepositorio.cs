using Construg.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Construg.Repositorio.Repositorios
{
    public class BaseRepositorio<Tentity> : IBaserepositorio<Tentity> where Tentity : class
    {
        public BaseRepositorio()
        {

        }
        public void Adicionar(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public Tentity Atualizar(Tentity entity)
        {
            throw new NotImplementedException();
        }

      

        public Tentity ObterporId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tentity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Tentity Remover(Tentity entity)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
