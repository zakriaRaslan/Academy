namespace IncluedeAllHierarchy.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public String? FName { get; set; }
        public String? LName { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }
}
