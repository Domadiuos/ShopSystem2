using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSystem.Models;

namespace ShopSystem.Data.Configrution
{
    public class SellerConfig : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasOne(x=>x.team).WithMany(x=>x.sellers).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
