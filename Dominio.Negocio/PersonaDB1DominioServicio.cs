using Dominio.Contratos;
using Dominio.Entidades;
using Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Dominio.Negocio
{
    public class PersonaDB1DominioServicio : IPersonaDB1DominioServicio
    {
        private readonly IUnidadTrabajoDB1 unidadTrabajoDB1;
        public PersonaDB1DominioServicio(IUnidadTrabajoDB1 unidadTrabajoDB1)
        {
            this.unidadTrabajoDB1 = unidadTrabajoDB1;
        }

        public List<PersonaDB1> Obteneristado()
        {
            return unidadTrabajoDB1.PersonaDB.Lista().ToList();
        }
    }
}
