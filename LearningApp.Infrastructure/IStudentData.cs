using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCore.Entities;

namespace LearningApp.Infrastructure
{
    public interface IStudentData
    {
        void SaveStudent(Student student);

        Student GetStudentById(int id);

        List<Student> GetStudents();

        IEnumerable<Student> GetStudentByName(string studentName);

        void Update(Student updatedStudent);

        void AddNewStudent(Student student);

        void DeleteStudent(int studentId);

        int Commit();
    }
}
