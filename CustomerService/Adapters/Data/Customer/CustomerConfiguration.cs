using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CustomerEntity = Domain.Customer.Entities.Customer;

namespace Data.Customer
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasKey(x => x.CustomerId);

            builder.Property(x => x.DocumentType)
                .HasColumnName("DocumentTypeId")
                .IsRequired();

            builder.Property(x => x.Status)
                .HasColumnName("StatusId")
                .IsRequired();
        }       
    }
}
