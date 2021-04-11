using System;
using System.Collections.Generic;
using System.Text;

namespace Construg.Dominio.Contratos
{
   public interface IBaserepositorio<TEntity> : IDisposable where TEntity: class
    {
        void Adicionar(TEntity entity);



        TEntity ObterporId (int id);

        IEnumerable<TEntity> ObterTodos();

        TEntity Atualizar (TEntity entity);
        TEntity Remover (TEntity entity);

    }
}
