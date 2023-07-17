using System.Ling.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface IGenero
{
    Task<Genero> GetByIdAsync(string id);
    Task<IEnumerable<Genero>> GetAllAsync();
    IEnumerable<Genero>  find(Expression<Func<Genero, bool>> expression);
    void Add(Genero entity);
    void AddRange(IEnumerable<Genero> entities);
    void Remove(Genero entity);
    void RemoveRange(IEnumerable<Genero> entities);
    void Update(Genero entity);


}