using System.Ling.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface IMedico
{
    Task<Medico> GetByIdAsync(string id);
    Task<IEnumerable<Medico>> GetAllAsync();
    IEnumerable<Medico>  find(Expression<Func<Medico, bool>> expression);
    void Add(Medico entity);
    void AddRange(IEnumerable<Medico> entities);
    void Remove(Medico entity);
    void RemoveRange(IEnumerable<Medico> entities);
    void Update(Medico entity);


}