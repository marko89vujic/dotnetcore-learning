using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningApp.Infrastructure;
using LearningCore.DataAccess;
using LearningCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningWebApp.Pages.Home
{
    public class CreateModel : PageModel
    {
        private IStudentData _studentData;

        [BindProperty]
        public Student Student { get; set; }

        public CreateModel(IStudentData studentData)
        {
            _studentData = studentData;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _studentData.AddNewStudent(Student);
                _studentData.Commit();
                return RedirectToPage("./List");
            }

            return Page();
        }
    }
}
