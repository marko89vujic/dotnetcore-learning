using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningApp.Infrastructure;
using LearningCore.DataAccess;
using LearningCore.Entities;
using LearningCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningWebApp.Pages.Home
{
    public class DetailModel : PageModel
    {
        private readonly IStudentData _studentData;

        public Student Student { get; set; }

        public DetailModel(IStudentData studentData)
        {
            _studentData = studentData;
        }
        public IActionResult OnGet(int studentId)
        {

            Student = _studentData.GetStudentById(studentId);

            if (Student == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}
