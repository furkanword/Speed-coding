using System.Ling.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface IConsultorio
{
    Task<consultorio> GetByIdAsync(string id);
    Task<IEnumerable<consultorio>> GetAllAsync();
    IEnumerable<consultorio>  find(Expression<Func<consultorio, bool>> expression);
    void Add(consultorio entity);
    void AddRange(IEnumerable<consultorio> entities);
    void Remove(consultorio entity);
    void RemoveRange(IEnumerable<consultorio> entities);
    void Update(consultorio entity);


}