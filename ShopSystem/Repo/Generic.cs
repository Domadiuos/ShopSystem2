
using Microsoft.EntityFrameworkCore;
using ShopSystem.Data;

namespace ShopSystem.Repo
{
    public class Generic<T> : IGeneric<T> where T : class
    {
        protected App_DbContext _db;

        public Generic(App_DbContext db) 
        {
            _db = db;
        }

        //GET All
        public virtual async Task<IEnumerable<T>> GetAll()
        {
          return  await _db.Set<T>().ToListAsync();
            
        }
        //GET By Id
        public virtual async Task<T?> GetById(int id)
        {
           return await _db.Set<T>().FindAsync(id);
        }

        //Delete
        public async Task<bool> Delete(int id)
        {
            var result = await _db.Set<T>().FindAsync(id);
            if (result == null)
                return false;

             _db.Set<T>().Remove(result);
            await _db.SaveChangesAsync();
            return true;

        }
        //Add

        public virtual async Task Add(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        //Update
        public async Task Update(T entity)
        {
             _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
        }
    }

}
