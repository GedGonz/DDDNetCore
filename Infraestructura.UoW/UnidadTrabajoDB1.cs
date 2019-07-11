using Dominio.Contratos;
using Infraestructura.Contexto;
using Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.UoW
{
    public class UnidadTrabajoDB1 :  IUnidadTrabajoDB1
    {
        private IPersonaDB1Repositorio personaRepositorio;
        private readonly ContextoDB1 contextoDB1;

        public UnidadTrabajoDB1(ContextoDB1 contextoDB1)
        {
            this.contextoDB1 = contextoDB1;
        }

        public IPersonaDB1Repositorio PersonaDB
        {
            get
            {
                personaRepositorio = new PersonaDB1Repositorio(contextoDB1);
                return personaRepositorio;
            }
        }

        public void commit()
        {
            contextoDB1.SaveChanges();
            if (contextoDB1.Database.CurrentTransaction != null)
            {
                contextoDB1.Database.CurrentTransaction.Commit();
            }
        }
        public void RollBack()
        {
            contextoDB1.Database.CurrentTransaction.Rollback();
        }

        public void Disposable()
        {
            GC.KeepAlive(this);
            contextoDB1.Dispose();
        }
    }
}
