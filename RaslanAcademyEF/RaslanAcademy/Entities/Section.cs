namespace IncluedeAllHierarchy.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }

        public int CourseId { get; set; }
        public Course course { get; set; }
        public TimeSlot TimeSlot { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public int? instructorId { get; set; }
        public Instructor? instructor { get; set; }

        public ICollection<Student> Student { get; set; }
    }

    public class TimeSlot
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public override string ToString()
        {
            return $"{StartTime.ToString("hh\\:mm")} - {EndTime.ToString("hh\\:mm")}";
        }
    }

}
