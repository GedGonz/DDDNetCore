using Dominio.Contratos;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Contexto
{
    public class ContextoDB1:DbContext
    {
        public ContextoDB1(DbContextOptions<ContextoDB1> option) : base(option)
        {

        }

        public DbSet<PersonaDB1> PersonaDB1 { get; set; }

        protected override void OnModelCreating(ModelBuilder migrationBuilder)
        {
            base.OnModelCreating(migrationBuilder);

        }
    }
}
