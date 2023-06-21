namespace IncluedeAllHierarchy.Entities
{
    public abstract class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
    }

    public class MultipleChoiseQuiz : Quiz
    {
        public string Choise1 { get; set; }
        public string Choise2 { get; set; }
        public string Choise3 { get; set; }
        public string Choise4 { get; set; }
        public byte CorrectAnser { get; set; }
    }

    public class TrueAndFalseQuiz : Quiz
    {
        public bool CorrectAnswer { get; set; }
    }

}
