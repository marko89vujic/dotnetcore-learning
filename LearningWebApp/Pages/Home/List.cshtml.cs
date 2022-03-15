using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningApp.Infrastructure;
using LearningCore.DataAccess;
using LearningCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace LearningWebApp.Pages.Home
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _configuration;

        private readonly IStudentData _studentData;

        public IEnumerable<Student> Students { get; set; }
        public string Message { get; set; }

        public string NumberOfAttempts { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration configuration, IStudentData studentData)
        {
            _configuration = configuration;
            _studentData = studentData;
        }
        public void OnGet()
        {
            Message = "Test333";
            NumberOfAttempts = _configuration["NumberOfAttempts"];
            Students = _studentData.GetStudents();
        }
    }
}
