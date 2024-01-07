using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TodoMVC.Models.EntityConfig
{
    public class TodoEntityConfig : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("todo");

            builder.HasKey(t => t.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasColumnType("nvarchar(150)")
                .HasColumnName("title");
            
            builder.Property(x => x.Description)
                .HasColumnType("nvarchar(450)")
                .HasColumnName("description");

            builder.Property(x => x.CreatedDate)
                .HasColumnName("createDate")
                .HasColumnType("date")
                .IsRequired()
                .HasDefaultValue(DateTime.Now.Date);

            builder.Property(x => x.IsCompleted)
                .HasColumnName("isCompleted")
                .HasColumnType ("bit")
                .IsRequired()
                .HasDefaultValue(false);

        }
    }
}
