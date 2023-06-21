namespace IncluedeAllHierarchy.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public String? FName { get; set; }
        public String? LName { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }
    public class Individual : Participant
    {
        public string University { get; set; }
        public int YearOfGraduation { get; set; }
        public bool IsIntern { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} - {FName} {LName} - University:{University} - Year Of Graduation: {YearOfGraduation} - ({(IsIntern ? "Is Intern" : "")})";
        }
    }

    public class Corporate : Participant
    {
        public string CompanyName { get; set; }
        public string JopTitle { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} - {FName} {LName} - He is {JopTitle} in {CompanyName}";

        }
    }
}
