using Api.Tareas.Dominio.Models;
using Api.Tareas.Dto.NotasDto;
using Api.Tareas.Dto.UsuariosDto;
using System.Threading;

namespace Api.Tareas.Negocio
{
    public class Mapping
    {
        public static Nota GetMapper(NotaAdministracionEntrada valor)
        {
            return new Nota()
            {
                Descripcion = valor.Descripcion,
                Estado = valor.Estado,
                FechaActivacion = valor.FechaActivacion,
                FechaModificacion = valor.FechaModificacion,
                FechaInactivacion = valor.FechaInactivacion,
                Idusuario = valor.Idusuario,
    

            };
        }
        public static NotaAdministracionSalida GetMapper(Nota valor)
        {
            return new NotaAdministracionSalida()
            {
                Id = valor.Id,
                Descripcion = valor.Descripcion,
                Estado = valor.Estado,
                FechaActivacion = valor.FechaActivacion,
                FechaModificacion = valor.FechaModificacion,
                FechaInactivacion = valor.FechaInactivacion,
                Idusuario = valor.Idusuario,


            };
        }

        public static List<NotaAdministracionSalida> GetMapper(List<Nota> valores)
        {
            List<NotaAdministracionSalida> valorSalida = new List<NotaAdministracionSalida>();
            foreach (Nota valor in valores)
            {
                valorSalida.Add(GetMapper(valor));
            }

            return valorSalida;
        }
        //-----------------------------------------------------------------------------------------------
        public static Usuario GetMapper(UsuarioAdministracionEntrada valor)
        {
            return new Usuario()
            {
                Estado = valor.Estado,
                FechaActivacion = valor.FechaActivacion,
                FechaModificacion = valor.FechaModificacion,
                FechaInactivacion = valor.FechaInactivacion,
                Nombre1 = valor.Nombre1,
                Nombre2 = valor.Nombre2,
                Apellido1 = valor.Apellido1,
                Apellido2 = valor.Apellido2,
                Apodo = valor.Apodo,
                Email = valor.Email,
                Contrasena = valor.Contrasena,
                FechaNacimiento =valor.FechaNacimiento,

            };
        }
        public static UsuarioAdministracionSalida GetMapper(Usuario valor)
        {
            return new UsuarioAdministracionSalida()
            {
                Id = valor.Id,
                Estado = valor.Estado,
                FechaActivacion = valor.FechaActivacion,
                FechaModificacion = valor.FechaModificacion,
                FechaInactivacion = valor.FechaInactivacion,
                Nombre1 = valor.Nombre1,
                Nombre2 = valor.Nombre2,
                Apellido1 = valor.Apellido1,
                Apellido2 = valor.Apellido2,
                Apodo = valor.Apodo,
                Email = valor.Email,
                Contrasena = valor.Contrasena,
                FechaNacimiento = valor.FechaNacimiento,

            };
        }

        public static List<UsuarioAdministracionSalida> GetMapper(List<Usuario> valores)
        {
            List<UsuarioAdministracionSalida> valorSalida = new List<UsuarioAdministracionSalida>();
            foreach (Usuario valor in valores)
            {
                valorSalida.Add(GetMapper(valor));
            }

            return valorSalida;
        }
        //-----------------------------------------------------------------------------------------------
    }
}