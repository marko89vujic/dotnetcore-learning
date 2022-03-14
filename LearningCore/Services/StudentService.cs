using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCore.DataAccess;
using LearningCore.Entities;

namespace LearningCore.Services
{
    public class StudentService : IStudentService
    {
        private List<Student> students;


        public StudentService()
        {
            students = GetInitialStudents();
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(x => x.StudentId == id);
        }

        public void SaveStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            return new List<Student>
                { new Student { Name = "Test1", LastName = "Test2", Level = Level.Beginner, StudentId = 1 }, new Student { Name = "test3", LastName = "test3", Level = Level.Professional, StudentId = 4} };
        }

        public IEnumerable<Student> GetStudentByName(string studentName)
        {
            return string.IsNullOrEmpty(studentName) ? students : students.Where(x => x.Name.StartsWith(studentName));
        }

        public Student Update(Student updatedStudent)
        {
            var student = GetStudents().FirstOrDefault(x => x.StudentId == updatedStudent.StudentId);

            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.LastName = updatedStudent.LastName;
                student.Level = updatedStudent.Level;
            }

            return student;
        }

        public int Commit()
        {
            return 1;
        }


        private List<Student> GetInitialStudents()
        {
            return new List<Student>
                { new Student { Name = "Test1", LastName = "Test2", Level = Level.Beginner, StudentId = 1 }, new Student { Name = "test3", LastName = "test3", Level = Level.Professional, StudentId = 4}, new Student { Name = "test4", LastName = "test4", Level = Level.Professional, StudentId = 5} };
        }
    }
}
