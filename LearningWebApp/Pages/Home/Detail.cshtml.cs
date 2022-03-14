using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCore.DataAccess;
using LearningCore.Entities;
using LearningCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningWebApp.Pages.Home
{
    public class DetailModel : PageModel
    {
        private readonly IStudentService studentService;

        public Student Student { get; set; }

        public DetailModel()
        {
            studentService = new StudentService();
        }
        public void OnGet(int studentId)
        {
            Student = studentService.GetStudentById(studentId);
        }
    }
}
