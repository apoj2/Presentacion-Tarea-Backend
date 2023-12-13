using Api.Tareas.Dominio.Models;
using Api.Tareas.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Repositorio.Implements
{
    public class UsuarioRepositorio : GenericoRepositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly TaskContext _conexion;

        public UsuarioRepositorio(TaskContext conexion) : base(conexion)
        {
            _conexion = conexion;
        }
        public override async Task<Usuario?> ActualizarAsync(Guid id, Usuario entidad)
        {
            if (entidad == null)
            {
                return null;
            }

            Usuario? entidadid = await _conexion.FindAsync<Usuario>(id);

            if (entidadid == null)
            {
                return null;
            }

            entidadid.Id = entidad.Id;


            _conexion.Update(entidadid);
            await _conexion.SaveChangesAsync();
            return entidadid;

        }


    }
}
