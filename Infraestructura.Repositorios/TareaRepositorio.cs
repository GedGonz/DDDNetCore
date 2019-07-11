using Dominio.Contratos;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Repositorios
{
    public class TareaRepositorio : BaseRepositorio<Tarea>,ITareaRepositorio
    {

        public TareaRepositorio(DbContext context):base(context)
        {

        }
    }
}
