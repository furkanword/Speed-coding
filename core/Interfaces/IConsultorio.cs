
using System.Linq.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface IConsultorio
{
    Task<Consultorio> GetByIdAsync(string id);
    Task<IEnumerable<Consultorio>> GetAllAsync();
    IEnumerable<Consultorio>  find(Expression<Func<Consultorio, bool>> expression);
    void Add(Consultorio entity);
    void AddRange(IEnumerable<Consultorio> entities);
    void Remove(Consultorio entity);
    void RemoveRange(IEnumerable<Consultorio> entities);
    void Update(Consultorio entity);


}