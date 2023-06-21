using IncluedeAllHierarchy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncluedeAllHierarchy.Data.Config
{
    internal class IndividualsConfiguration : IEntityTypeConfiguration<Individual>
    {
        public void Configure(EntityTypeBuilder<Individual> builder)
        {
            builder.ToTable("Individuals");
        }
    }
    internal class CorporatesConfiguration : IEntityTypeConfiguration<Corporate>
    {


        public void Configure(EntityTypeBuilder<Corporate> builder)
        {
            builder.ToTable("Corporates");

        }
    }
}
