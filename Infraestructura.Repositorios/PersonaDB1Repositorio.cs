using Dominio.Contratos;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Repositorios
{
    public class PersonaDB1Repositorio : BaseRepositorio<PersonaDB1>, IPersonaDB1Repositorio
    {
        public PersonaDB1Repositorio(DbContext Contexto) : base(Contexto)
        {
        }
    }
}
