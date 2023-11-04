using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArcApi.Domain.Entities;

namespace OnionArcApi.Persistence.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(256);

        Category category1 = new() { Id = 1, Name = "Elektirik", Priorty = 1, ParentId = 0, CreatedDate = DateTime.Now, IsDeleted = false };
        Category category2 = new() { Id = 2, Name = "Moda", Priorty = 2, ParentId = 0, CreatedDate = DateTime.Now, IsDeleted = false };
        Category parent1 = new() { Id = 3, Name = "Bilgisayar", Priorty = 1, ParentId = 1, CreatedDate = DateTime.Now, IsDeleted = false };
        Category parent2 = new() { Id = 4, Name = "Kadın", Priorty = 1, ParentId = 2, CreatedDate = DateTime.Now, IsDeleted = false };

        builder.HasData(category1, category2, parent1, parent2);
    }
}
