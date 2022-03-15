using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCore.DataAccess;
using LearningCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningWebApp.Pages.Home
{
    public class CreateModel : PageModel
    {
        private IStudentService _studentService;

        [BindProperty]
        public Student Student { get; set; }

        public CreateModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _studentService.AddNewStudent(Student);
                _studentService.Commit();
                return RedirectToPage("./List");
            }

            return Page();
        }
    }
}
