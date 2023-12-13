using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Dto.UsuariosDto
{
    public class UsuarioAdministracionSalida
    {
        public Guid Id { get; set; }

        public string? Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? Email { get; set; }
        public string? Contrasena { get; set; }
        public string? Apodo { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaActivacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaInactivacion { get; set; }
    }
}
