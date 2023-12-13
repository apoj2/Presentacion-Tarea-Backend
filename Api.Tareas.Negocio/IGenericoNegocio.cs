using Api.Pruebas.Comun;
using Api.Tareas.Dominio.Util.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Negocio
{
    public interface IGenericoNegocio<TEntity,TOutput> where TEntity : class
    {
        Task<Retorno<TOutput?>> GetByIdAsync(Guid id);
        Task<Retorno<List<TOutput>?>> GetAllAsync();
        Task<Retorno<TOutput?>> CreateAsync(TEntity entidad);
        Task<Retorno<TOutput?>> ActualizarAsync(Guid id, TEntity entidad);
        Task<Retorno<bool>> EliminarAsync(Guid id);
    }
}
