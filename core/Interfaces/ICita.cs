using System.Ling.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface ICita
{
    Task<Cita> GetByIdAsync(string id);
    Task<IEnumerable<Cita>> GetAllAsync();
    IEnumerable<Cita>  find(Expression<Func<Cita, bool>> expression);
    void Add(Cita entity);
    void AddRange(IEnumerable<Cita> entities);
    void Remove(Cita entity);
    void RemoveRange(IEnumerable<Cita> entities);
    void Update(Cita entity);


}