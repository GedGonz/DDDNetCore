using Dominio.Contratos;
using Dominio.Negocio;
using Dominio.Servicios;
using Infraestructura.Repositorios;
using Infraestructura.UoW;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.IoC
{
    public static class ServicioIoC
    {
        public static IServiceCollection Service(IServiceCollection services)
        {
            
            services.AddScoped<IUnidadTrabajoDB1, UnidadTrabajoDB1>();
            services.AddScoped<IUniadadTrabajoAngenda, UnidadTrabajoAgenda>();
            services.AddScoped<IPersonaDB1Repositorio, PersonaDB1Repositorio>();
            services.AddScoped<IPersonaDB1DominioServicio, PersonaDB1DominioServicio>();

            services.AddScoped<ITareaRepositorio, TareaRepositorio>();
            services.AddScoped<ITareaDominioServicio, TareaDominioServicio>();

            return services;
        }
    }
}
