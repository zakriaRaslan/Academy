namespace IncluedeAllHierarchy.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public String? FName { get; set; }
        public String? LName { get; set; }

        public int? OfficeId { get; set; }
        public Office? office { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();


    }
}
