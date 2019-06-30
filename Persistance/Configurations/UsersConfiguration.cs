using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using students_task.Domain.Models;

namespace students_task.Persistance.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);
            builder.Property(u => u.Name)
                .HasColumnName("user_name")
                .HasMaxLength(64)
                .IsRequired();
            builder.Ignore(u => u.Email);
            /*/builder.Property(u => u.Email)
                .HasColumnName("email")
                .HasMaxLength(128)
                .HasColumnType("string");*/
            
            builder.Property(u => u.IsActive)
                .HasColumnName("is_active");
            
        }
    }
}