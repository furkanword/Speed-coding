
using System.Linq.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface IEspecialidad
{
    Task<Especialidad> GetByIdAsync(string id);
    Task<IEnumerable<Especialidad>> GetAllAsync();
    IEnumerable<Especialidad>  find(Expression<Func<Especialidad, bool>> expression);
    void Add(Especialidad entity);
    void AddRange(IEnumerable<Especialidad> entities);
    void Remove(Especialidad entity);
    void RemoveRange(IEnumerable<Especialidad> entities);
    void Update(Especialidad entity);


}