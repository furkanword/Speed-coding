
using System.Linq.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface IEstado_cita
{
    Task<Estado_cita> GetByIdAsync(string id);
    Task<IEnumerable<Estado_cita>> GetAllAsync();
    IEnumerable<Estado_cita>  find(Expression<Func<Estado_cita, bool>> expression);
    void Add(Estado_cita entity);
    void AddRange(IEnumerable<Estado_cita> entities);
    void Remove(Estado_cita entity);
    void RemoveRange(IEnumerable<Estado_cita> entities);
    void Update(Estado_cita entity);
}