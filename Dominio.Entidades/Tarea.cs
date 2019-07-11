using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public partial class Tarea
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
    }
}
