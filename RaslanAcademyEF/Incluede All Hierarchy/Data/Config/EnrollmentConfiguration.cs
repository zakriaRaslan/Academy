using IncluedeAllHierarchy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncluedeAllHierarchy.Data.Config
{
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(x => new { x.participantId, x.SectionId });


            builder.ToTable("Enrollments");


        }
    }


}
