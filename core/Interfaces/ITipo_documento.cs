using System.Ling.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface ITipo_documento
{
    Task<Tipo_documento> GetByIdAsync(string id);
    Task<IEnumerable<Tipo_documento>> GetAllAsync();
    IEnumerable<Tipo_documento>  find(Expression<Func<Tipo_documento, bool>> expression);
    void Add(Tipo_documento entity);
    void AddRange(IEnumerable<Tipo_documento> entities);
    void Remove(Tipo_documento entity);
    void RemoveRange(IEnumerable<Tipo_documento> entities);
    void Update(Tipo_documento entity);


}