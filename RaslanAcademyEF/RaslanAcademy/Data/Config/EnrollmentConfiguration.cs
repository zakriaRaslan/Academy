using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IncluedeAllHierarchy.Entities;

namespace IncluedeAllHierarchy.Data.Config
{
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.SectionId });


            builder.ToTable("Enrollments");


        }
    }


}
