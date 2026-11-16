using Microsoft.EntityFrameworkCore;
using ShopSystem.Data;
using ShopSystem.Models;

namespace ShopSystem.Repo
{
    public class SellerRepo : Generic<Seller>
    {

        public SellerRepo(App_DbContext db) : base(db)
        {
        }
        //Add Seller 
        public override async Task Add(Seller entity)
        {
            if (entity.team != null)
             await  _db.teams.AddAsync(entity.team);
           

             _db.Add(entity);
            await _db.SaveChangesAsync();
        }
        //GET By Id 
        public override async Task<Seller?> GetById(int id)
        {
            return await _db.sellers.Include(x => x.team).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
