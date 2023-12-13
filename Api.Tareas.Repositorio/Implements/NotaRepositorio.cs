using Api.Tareas.Dominio.Models;
using Api.Tareas.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Repositorio.Implements
{
    public class NotaRepositorio:GenericoRepositorio<Nota>,INotaRepositorio
    {
        private readonly TaskContext _conexion;

        public NotaRepositorio(TaskContext conexion):base (conexion) { 
            _conexion = conexion;

        }

        public override async Task<Nota?> ActualizarAsync(Guid id, Nota entidad)
        {
            if (entidad == null)
            {
                return null;
            }

            Nota? entidadid = await _conexion.FindAsync<Nota>(id);

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
