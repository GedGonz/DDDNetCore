using Dominio.Contratos;
using Infraestructura.Contexto;
using Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.UoW
{
    public class UnidadTrabajoAgenda : IUniadadTrabajoAngenda
    {
        private ITareaRepositorio _tareaRepositorio;
        private readonly AgendaContext agendaContext;

        public UnidadTrabajoAgenda(AgendaContext contextoDB1)
        {
            this.agendaContext = contextoDB1;
        }

        public ITareaRepositorio tareaRepositorio
        {
            get
            {
                _tareaRepositorio = new TareaRepositorio(agendaContext);
                return _tareaRepositorio;
            }
        }

        public void commit()
        {
            agendaContext.SaveChanges();
            if (agendaContext.Database.CurrentTransaction != null)
            {
                agendaContext.Database.CurrentTransaction.Commit();
            }
        }
        public void RollBack()
        {
            agendaContext.Database.CurrentTransaction.Rollback();
        }

        public void Disposable()
        {
            GC.KeepAlive(this);
            agendaContext.Dispose();
        }
    }
}
