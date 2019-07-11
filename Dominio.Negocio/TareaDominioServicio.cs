using Dominio.Contratos;
using Dominio.Entidades;
using Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Dominio.Negocio
{
    public class TareaDominioServicio : ITareaDominioServicio
    {
        private readonly IUniadadTrabajoAngenda unidadTrabajoDB1;
        public TareaDominioServicio(IUniadadTrabajoAngenda unidadTrabajoDB1)
        {
            this.unidadTrabajoDB1 = unidadTrabajoDB1;
        }
        public List<Tarea> ObtenerListAll()
        {
            return unidadTrabajoDB1.tareaRepositorio.Lista().ToList();
        }
    }
}
