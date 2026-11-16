using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSystem.Models;

namespace ShopSystem.Data.Configrution
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasMany(x => x.sellers).WithMany(x => x.customers);


            builder.HasOne(x=>x.card)
                .WithOne(x=>x.customer)
                .HasForeignKey<Card>(x=>x.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
