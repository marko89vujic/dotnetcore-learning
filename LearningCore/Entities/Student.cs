namespace LearningCore.Entities
{
    public enum Level
    {
        Beginner = 0,
        Medium = 1,
        Professional = 2,
    }
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public Level Level { get; set; }
    }
}
