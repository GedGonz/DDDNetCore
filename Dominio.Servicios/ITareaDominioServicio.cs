using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Servicios
{
    public interface ITareaDominioServicio
    {
        List<Tarea> ObtenerListAll();
    }
}
