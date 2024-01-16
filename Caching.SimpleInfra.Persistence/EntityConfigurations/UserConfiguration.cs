using Caching.SimpleInfra.Domain.Entities;
using Caching.SimpleInfra.Persistence.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Caching.SimpleInfra.Persistence.EntityConfigurations;

public class UserConfiguration(IdentityDbContext dbContext) : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(user => user.FirstName).IsRequired().HasMaxLength(64);
        builder.Property(user => user.LastName).IsRequired().HasMaxLength(64);
    }
}
