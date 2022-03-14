using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCore.Entities;

namespace LearningCore.DataAccess
{
    public interface IStudentService
    {
        void SaveStudent(Student student);

        Student GetStudentById(int id);

        List<Student> GetStudents();

        IEnumerable<Student> GetStudentByName(string studentName);

        Student Update(Student updatedStudent);

        int Commit();
    }
}
