using System.Ling.Expressions;
using core.Entities;

namespace core.Interfaces;

public interface IUsuario
{
    Task<Usuario> GetByIdAsync(string id);
    Task<IEnumerable<Usuario>> GetAllAsync();
    IEnumerable<Usuario>  find(Expression<Func<Usuario, bool>> expression);
    void Add(Usuario entity);
    void AddRange(IEnumerable<Usuario> entities);
    void Remove(Usuario entity);
    void RemoveRange(IEnumerable<Usuario> entities);
    void Update(Usuario entity);


}