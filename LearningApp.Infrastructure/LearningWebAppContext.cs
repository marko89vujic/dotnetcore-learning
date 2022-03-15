using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningApp.Infrastructure
{
    public class LearningWebAppContext : DbContext
    {

        public LearningWebAppContext(DbContextOptions<LearningWebAppContext> options):base(options)
        {

        }


        public DbSet<Student> StudentDates { get; set; }
    }
}
