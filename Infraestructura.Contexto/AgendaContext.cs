using System;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infraestructura.Contexto
{
    public partial class AgendaContext : DbContext
    {
        public AgendaContext()
        {
        }

        public AgendaContext(DbContextOptions<AgendaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tarea> Tarea { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=GEDGONZ-PC\\EXPRESS;Initial Catalog=Agenda;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Tarea>(entity =>
            //{
            //    entity.Property(e => e.Id).HasField("Id");

            //    entity.Property(e => e.Descripcion)
            //        .HasField("descripcion")
            //        .IsUnicode(false);

            //    entity.Property(e => e.Estado).HasField("estado");
            //});
        }
    }
}
