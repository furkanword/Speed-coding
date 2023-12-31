
using System.Linq.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface IAcudiente
{
    Task<Acudiente> GetByIdAsync(string id);
    Task<IEnumerable<Acudiente>> GetAllAsync();
    IEnumerable<Acudiente>  find(Expression<Func<Acudiente, bool>> expression);
    void Add(Acudiente entity);
    void AddRange(IEnumerable<Acudiente> entities);
    void Remove(Acudiente entity);
    void RemoveRange(IEnumerable<Acudiente> entities);
    void Update(Acudiente entity);


}
