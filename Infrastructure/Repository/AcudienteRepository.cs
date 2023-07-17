using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository;

public class AcudienteRepository : IAcudiente
{
    protected readonly InventarioContext _context;

    public AcudienteRepository (InventarioContext context){

        _context = context;
    }

    public virtual void Add(Acudiente entity){

        _context.set<Acudiente>().Add(entity);

    }

    public virtual void AddRange(IEnumerable<Acudiente> entities){

        _context.set<Acudiente>().AddRange(entities);
    }

    public IEnumerable<Acudiente> find(Expression<Func<Acudiente, bool>> expression){

        return _context.Set<Acudiente>().where(expression);
    }

    public async Task<IEnumerable<Acudiente>> GetAsync(){

        return await _context.Set<Acudiente>().ToListAsync();
    }

    public async Task<Acudiente> GetAcudienteAsync(string id){

        return await _context.Set<Acudiente>().FindAsync(id);    
    }
    public void Remove(Acudiente entity){

        _context.Set<Acudiente>().Remove(entity);
    }
    
    public void RemoveRange(IEnumerable<Acudiente> entities){
        _context.Set<Acudiente>().RemoveRange(entities);
    }
    
    public void Update(Acudiente entity){
        _context.Set<Acudiente>().Update(entity);
    }
}
