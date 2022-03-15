using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningApp.Infrastructure;
using LearningCore.DataAccess;
using LearningCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearningWebApp.Pages.Home
{
    public class EditModel : PageModel
    {
        private IStudentData _studentData;

        private IHtmlHelper _htmlHelper;

        [BindProperty]
        public Student Student { get; set; }

        public IEnumerable<Level> Levels { get; set; }

        public EditModel(IStudentData studentData, IHtmlHelper htmlHelper)
        {
            _studentData = studentData;
            _htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int studentId)
        {
            Student = _studentData.GetStudentById(studentId);
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
                _studentData.Update(Student);
                return RedirectToPage("./Detail", new { studentId = Student.Id});
            }
            
            return Page();
        }
    }
}
