using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCore.DataAccess;
using LearningCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearningWebApp.Pages.Home
{
    public class EditModel : PageModel
    {
        private IStudentService _studentService;

        private IHtmlHelper _htmlHelper;

        [BindProperty]
        public Student Student { get; set; }

        public IEnumerable<Level> Levels { get; set; }

        public EditModel(IStudentService studentService, IHtmlHelper htmlHelper)
        {
            _studentService = studentService;
            _htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int studentId)
        {
            Student = _studentService.GetStudentById(studentId);
            // Levels = (IEnumerable<Level>)_htmlHelper.GetEnumSelectList<Level>();
            if (Student == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Student = _studentService.Update(Student);
                _studentService.Commit();
            }
            
            return Page();
        }
    }
}
