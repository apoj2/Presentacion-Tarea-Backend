using Api.Tareas.Dominio.Util.Implements;
using Api.Tareas.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Repositorio.Implements
{
    public class GenericoRepositorio<TEntity>:IGenericoRepositorio<TEntity> where TEntity : Document
    {
        private readonly TaskContext _conexion;
        private  List<TEntity> _entities;
        public GenericoRepositorio(TaskContext conexion) { 
        
            _conexion = conexion;
            _entities = new List<TEntity>();
        }

        public virtual async Task<TEntity?> ActualizarAsync(Guid id, TEntity entidad)
        {
            if (entidad == null)
            {
                return null;
            }

            TEntity? entidadid = await _conexion.FindAsync<TEntity>(id);

            if (entidadid == null)
            {
                return null;
            }

            entidadid.Id = entidad.Id;


            _conexion.Update(entidadid);
            await _conexion.SaveChangesAsync();
            return entidadid;

        }

        public async Task<TEntity?> CreateAsync(TEntity entidad)
        {
            if(entidad == null)
            {
                return null;
            }
            entidad.Id = Guid.NewGuid();
            _conexion.Add(entidad);
            await _conexion.SaveChangesAsync();
            return entidad;
        }

        public async Task<bool> EliminarAsync(Guid id)
        {
            TEntity? entidadid = await _conexion.FindAsync<TEntity>(id);

            if (entidadid == null)
            {
                return false;
            }

            _conexion.Remove(id);
            await _conexion.SaveChangesAsync();
            return true;
        }

        public async Task<List<TEntity>?> GetAllAsync()
        {
            _entities = await _conexion.Set<TEntity>().ToListAsync();

            if (_entities == null)
            {
                return null;
            }

            return _entities;
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            TEntity? entidadid = await _conexion.FindAsync<TEntity>(id);

            if (entidadid == null)
            {
                return null;
            }
            return entidadid;
        }
    }
}
