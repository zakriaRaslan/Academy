using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IncluedeAllHierarchy.Entities;

namespace IncluedeAllHierarchy.Data.Config
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.FName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.HasOne(x => x.office)
                .WithOne(x => x.instructor)
                .HasForeignKey<Instructor>(x => x.OfficeId)
                .IsRequired(false);

            builder.ToTable("Instructors");


        }
    }


}
