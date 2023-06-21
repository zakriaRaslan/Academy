namespace IncluedeAllHierarchy.Entities
{
    public class Enrollment
    {

        public int participantId { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; } = null!;
        public Participant participant { get; set; } = null!;


    }
}
