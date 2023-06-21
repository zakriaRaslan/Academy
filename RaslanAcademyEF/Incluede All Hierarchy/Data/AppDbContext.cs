using IncluedeAllHierarchy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IncluedeAllHierarchy.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Participant> participants { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        //public DbSet<Individual> Individuals { get; set; }
        //public DbSet<Corporate> Corporates { get; set; }

        public DbSet<MultipleChoiseQuiz> MultipleChoiseQuizs { get; set; }
        public DbSet<TrueAndFalseQuiz> TrueAndFalseQuizs { get; set; }

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
