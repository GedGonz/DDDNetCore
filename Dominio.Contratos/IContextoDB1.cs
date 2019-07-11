using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Contratos
{
    public interface IContextoDB1
    {
        DbSet<PersonaDB1> PersonaDB1 { get; set; }
    }
}
