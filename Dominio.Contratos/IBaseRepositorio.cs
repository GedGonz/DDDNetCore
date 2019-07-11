using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Contratos
{
    public interface IBaseRepositorio<T> where T : class
    {
        bool Add(T Entidad);
        bool Update(T Entidad);
        IEnumerable<T> Lista();
    }
}
