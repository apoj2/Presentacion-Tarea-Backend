using Api.Tareas.Dominio.Util.Implements;

namespace Api.Tareas.Repositorio
{
    public interface IGenericoRepositorio<TEntity> where TEntity : Document
    {
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<List<TEntity>?> GetAllAsync();
        Task<TEntity?> CreateAsync(TEntity entidad);
        Task<TEntity?> ActualizarAsync(Guid id, TEntity entidad);
        Task<bool> EliminarAsync(Guid id);


    }
}