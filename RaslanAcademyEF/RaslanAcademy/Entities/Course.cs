
using System.ComponentModel.DataAnnotations.Schema;

namespace IncluedeAllHierarchy.Entities
{

    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public Decimal Price { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }
}
