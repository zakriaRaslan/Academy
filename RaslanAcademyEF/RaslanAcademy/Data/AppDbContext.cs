using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using IncluedeAllHierarchy.Entities;

namespace IncluedeAllHierarchy.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionstring = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new CourseConfiguration()); //Not Best Practice lank httr t3ml satr lkol Class
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly); //de htgeeb kol el classes bta3t el configuration



        }
    }
}
