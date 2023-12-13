using Api.Tareas.Dominio.Util.Implements;
using System;
using System.Collections.Generic;

namespace Api.Tareas.Dominio.Models
{
    public partial class Nota:Document
    {
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaActivacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaInactivacion { get; set; }
        public Guid? Idusuario { get; set; }

        public virtual Usuario? IdusuarioNavigation { get; set; }
    }
}
