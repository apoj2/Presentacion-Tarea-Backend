using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Dto.NotasDto
{
    public class NotaAdministracionSalida
    {
        public Guid Id { get; set; }

        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaActivacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaInactivacion { get; set; }
        public Guid? Idusuario { get; set; }

    }
}
