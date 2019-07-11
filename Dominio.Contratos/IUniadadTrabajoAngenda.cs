using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Contratos
{
    public interface IUniadadTrabajoAngenda
    {
        ITareaRepositorio tareaRepositorio { get; }
        void commit();
        void RollBack();
        void Disposable();
    }
}
