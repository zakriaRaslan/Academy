using IncluedeAllHierarchy.Data;
using IncluedeAllHierarchy.Entities;

namespace IncluedeAllHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participant1 = new Individual
            {
                Id = 1,
                FName = "Mohsen",
                LName = "Saeed",
                IsIntern = true,
                University = "Must",
                YearOfGraduation = 2024
            };
            var participant2 = new Corporate
            {
                Id = 2,
                FName = "Mohamed",
                LName = "Saeed",
                CompanyName = "apple",
                JopTitle = "Developer",
            };
            var participant3 = new Corporate
            {
                Id = 3,
                FName = "Eslam",
                LName = "Mohamed",
                CompanyName = "apple",
                JopTitle = "HR",
            };

            using (var context = new AppDbContext())
            {
                context.participants.Add(participant1);
                context.participants.Add(participant2);
                context.participants.Add(participant3);
                context.SaveChanges();
            }

            using (var context = new AppDbContext())
            {
                Console.WriteLine("The Individual Members");
                foreach (var participant in context.Set<Participant>().OfType<Individual>())
                {
                    Console.WriteLine(participant);
                }
                Console.WriteLine("The Corporate Members");
                foreach (var participant in context.Set<Participant>().OfType<Corporate>())
                {
                    Console.WriteLine(participant);
                }
            }

            Console.ReadKey();
        }
    }
}