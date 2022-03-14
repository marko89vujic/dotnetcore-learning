using System.ComponentModel.DataAnnotations;

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

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(80)]
        public string LastName { get; set; }

        public Level Level { get; set; }
    }
}
