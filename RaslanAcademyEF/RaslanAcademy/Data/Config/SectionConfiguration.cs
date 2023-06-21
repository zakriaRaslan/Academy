using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IncluedeAllHierarchy.Entities;

namespace IncluedeAllHierarchy.Data.Config
{

    internal partial class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.SectionName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.OwnsOne(x => x.TimeSlot, ts =>
            {
                ts.Property(x => x.StartTime).HasColumnType("Time").HasColumnName("StartTime");
                ts.Property(x => x.EndTime).HasColumnType("Time").HasColumnName("EndTime");

            });

            builder.HasOne(x => x.course)
                 .WithMany(x => x.Sections)
                 .HasForeignKey(x => x.CourseId)
                 .IsRequired();

            builder.HasOne(x => x.instructor)
               .WithMany(x => x.Sections)
               .HasForeignKey(x => x.instructorId)
               .IsRequired(false);

            builder.HasMany(x => x.Student)
           .WithMany(x => x.Sections)
           .UsingEntity<Enrollment>();


            builder.HasOne(x => x.Schedule)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.ScheduleId)
                .IsRequired();


            builder.ToTable("Sections");

        }
    }

}
