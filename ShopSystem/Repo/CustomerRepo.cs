using Microsoft.EntityFrameworkCore;
using ShopSystem.Data;
using ShopSystem.Models;

namespace ShopSystem.Repo
{
    public class CustomerRepo : Generic<Customer>
    {
        public CustomerRepo(App_DbContext db) : base(db)
        {

        }
        //Add
        public override async Task Add(Customer entity)
        {
            if (entity.card != null)
                await _db.cards.AddAsync(entity.card);

            await _db.customers.AddAsync(entity);
            await _db.SaveChangesAsync();
        }
        //GET By Id
        public override async Task<Customer?> GetById(int id)
        {
            return await _db.customers.Include(x=>x.sellers).Include(x=>x.card).FirstOrDefaultAsync(x=>x.Id==id);
        }
    }
}
