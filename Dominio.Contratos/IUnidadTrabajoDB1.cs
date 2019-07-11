using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contratos
{
    public interface IUnidadTrabajoDB1
    {
        IPersonaDB1Repositorio PersonaDB { get; }
        void commit();
        void RollBack();
        void Disposable();
    }
}
