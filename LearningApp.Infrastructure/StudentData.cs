using LearningCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LearningApp.Infrastructure
{
    public class StudentData : IStudentData
    {
        private LearningWebAppContext _dbContext;

        public StudentData(LearningWebAppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddNewStudent(Student student)
        {
            _dbContext.StudentDates.Add(student);
            Commit();
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void DeleteStudent(int studentId)
        {
            var student = _dbContext.StudentDates.FirstOrDefault(x => x.Id == studentId);

            if (student != null)
            {
                _dbContext.StudentDates.Remove(student);
                Commit();
            }
        }

        public Student GetStudentById(int id)
        {
            return _dbContext.StudentDates.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Student> GetStudentByName(string studentName)
        {
            return _dbContext.StudentDates.Where(x => x.Name == studentName);
        }

        public List<Student> GetStudents()
        {
            return _dbContext.StudentDates.ToList();
        }

        public void SaveStudent(Student student)
        {
            _dbContext.StudentDates.Add(student);
            Commit();
        }

        public void Update(Student updatedStudent)
        {
            var entity = _dbContext.StudentDates.Attach(updatedStudent);
            entity.State = EntityState.Modified;
            Commit();

        }
    }
}
